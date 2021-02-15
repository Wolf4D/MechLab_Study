using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stages : MonoBehaviour
{
	// GameObject, FixedJoint and parent = null
	private GameObject[] Stage1_gameObjects = new GameObject[4]; // Отделение - 60 сек
	private GameObject Stage2_gameObj; // Отделение - 60 сек
	private GameObject Stage3_gameObj;
	private FixedJoint[] Stage2toX_1 = new FixedJoint[4];
	private FixedJoint Stage3to2_fixedJoint;
	// Rigidbody (for AddForce)
	private Rigidbody[] Stage1_rbs = new Rigidbody[4];
	private Rigidbody Stage2_rb;
	private Rigidbody Stage3_rb;
	// Dry mass (const)
	private const float Stage1_dry_mass = 3750f; // (4) 15 тонн
	private const float Stage2_dry_mass = 6000f; // 6 тонн
	private const float Stage3_dry_mass = 10000f; // 10 тонн
	// Fuel mass
	private float Stage1_fuel_mass;
	private float Stage2_fuel_mass;
	// Скорость истечения газов
	private const float ū = 2500f;
	// Расход массы топлива в секунду
	private const float Stage1_Δf = 10000f / 60f; // (4) all_fuel_mass / time
	private const float Stage2_Δf = 30000f / 60f;
	// Сила, прикладываемая к каждой ступени каждом этапе
	private const float F1 = ū * Stage1_Δf; // (4)
	private const float F2 = ū * Stage2_Δf;
	// Определяет в зависимости от пройденного времени какая сейчас ступень; isFly для задержки перед стартом; UI_Δf для UI-скрипта
	private byte whichStage;
	private byte isFly;
	public static int UI_Δf;
	// Масса всей ракеты
	public static float Mass;

	// Just calculate all Mass
	private void Update()
	{
		foreach (Rigidbody rb in Stage1_rbs)
			rb.mass = Stage1_dry_mass + Stage1_fuel_mass;
		Stage2_rb.mass = Stage2_dry_mass + Stage2_fuel_mass;

		Mass = Stage1_rbs[0].mass * 4 + Stage2_rb.mass + Stage3_rb.mass;
	}

	// (Stages timing; Start delay) and (parent = null; fixedJoint = null)
	private IEnumerator Which_Stage_Now()
	{
		{
		yield return new WaitForSeconds(1);

		isFly = 1;
		whichStage = 1;
		UI_Δf = 330 * 4;
		}
	
		yield return new WaitForSeconds(60);

		whichStage = 2;
		foreach (GameObject stage in Stage1_gameObjects)
			stage.transform.parent = null;
		foreach (Rigidbody rb in Stage1_rbs)
			rb.mass = Stage1_dry_mass;
		foreach (FixedJoint fj in Stage2toX_1)
			Destroy(fj);
		UI_Δf = (int)Stage2_Δf;

		yield return new WaitForSeconds(60);

		whichStage = 0;
		Stage2_gameObj.transform.parent = null;
		Destroy(Stage3to2_fixedJoint);
		UI_Δf = 0;
	}

	// Трата топлива
	private IEnumerator Fuel_Spending()
	{
		yield return new WaitForSeconds(1);

		while (whichStage != 0)
		{
			if (whichStage == 1)
			{
				Stage1_fuel_mass -= Stage1_Δf;
				yield return new WaitForSeconds(1f);
			}
			else if (whichStage == 2)
			{
				Stage1_fuel_mass = 0;
				Stage2_fuel_mass -= Stage2_Δf;
				yield return new WaitForSeconds(1f);
			}
		}
		Stage2_fuel_mass = 0;
		Stage2_rb.isKinematic = true;
	}

	// Actually rb.AddFoce (автоматизировано полностью)
	private void FixedUpdate()
	{
		if (whichStage == 1)
		{
			foreach (Rigidbody stage in Stage1_rbs)
				stage.AddForce(0, F1 * isFly, 0);
		}
		else if (whichStage == 2)
			Stage2_rb.AddForce(0, F2, 0);
	}

	private void Start()
	{
		// Initial fuel mass
		Stage1_fuel_mass = 10000f; // (4) 120 тонн
		Stage2_fuel_mass = 30000f; // 60 тонн

		// GameObject, FixedJoint and Rigidbody initialization
		for (int i = 0; i < 4; ++i)
		{
			Stage1_gameObjects[i] = GameObject.Find($"Stage1_{i + 1}");
			Stage1_rbs[i] = Stage1_gameObjects[i].GetComponent<Rigidbody>();
			Stage1_rbs[i].mass = Stage1_dry_mass + Stage1_fuel_mass;
		}
		Stage2_gameObj = GameObject.Find("Stage2");
		Stage3_gameObj = GameObject.Find("Stage3");
		Stage2toX_1 = Stage2_gameObj.GetComponents<FixedJoint>();
		Stage3to2_fixedJoint = Stage3_gameObj.GetComponent<FixedJoint>();
		Stage2_rb = Stage2_gameObj.GetComponent<Rigidbody>();
		Stage3_rb = Stage3_gameObj.GetComponent<Rigidbody>();
		Stage2_rb.mass = Stage2_dry_mass + Stage2_fuel_mass;
		Stage3_rb.mass = Stage3_dry_mass;

		isFly = 0;

		StartCoroutine(Which_Stage_Now());
		StartCoroutine(Fuel_Spending());

		Time.timeScale = 5;
	}
}
