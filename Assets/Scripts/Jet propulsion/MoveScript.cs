using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
	private Rigidbody _rigidbody;

	public int rocketMass;
	public float rocketSpeed;
	public int fuelMass;
	private int fuelMassSpeedOut;
	private int fuelSpeed;
	public int fuelImpulse;

	private const float g = 9.81f;

	private IEnumerator FuelAcceleration()
	{
		yield return new WaitForSeconds(3);

		while (fuelMass != 0)
		{
			fuelSpeed += 1;
			yield return new WaitForSeconds(1 / 90);
		}
	}

	private IEnumerator FuelFunc()
	{
		while (fuelMass != 0)
		{
			fuelMass -= 50;
			rocketMass = fuelMass + 30000;

			yield return new WaitForSeconds(0.02f);
		}
	}

	private IEnumerator Translating()
	{
		yield return new WaitForSeconds(3);

		while (fuelMass != 0)
		{
			rocketSpeed = fuelImpulse / rocketMass;

			transform.Translate(0, rocketSpeed / 50, 0);

			yield return new WaitForSeconds(0.02f);
		}

		rocketSpeed = 0;
		fuelImpulse = 0;
	}

	private void Update()
	{
		fuelImpulse = fuelSpeed * fuelMassSpeedOut;
	}

	private void Start()
	{
		rocketMass = 300000;
		rocketSpeed = 0;
		fuelMass = 270000;
		rocketSpeed = 0;
		fuelMassSpeedOut = 2500;
		fuelImpulse = 0;

		_rigidbody = GetComponent<Rigidbody>();

		StartCoroutine(FuelAcceleration());
		StartCoroutine(Translating());
		StartCoroutine(FuelFunc());
	}
}