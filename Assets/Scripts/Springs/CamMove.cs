using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
	private Transform upCube1Transform;
	private Vector3 upCube1PosInit;

	private Transform upCube2Transform;
	private Vector3 upCube2PosInit;

	private Transform ForRuler;

	private bool is_init;

	private IEnumerator Springing()
	{
		upCube1Transform.position = new Vector3(500, 5.7f, 500);
		upCube2Transform.position = new Vector3(500, 6.8f, 526);

		yield return new WaitForSeconds(0.1f);

		upCube1Transform.position = upCube1PosInit;
		upCube2Transform.position = upCube2PosInit;
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(1) && is_init == false)
		{
			transform.position = new Vector3(507, 4, 500);
			ForRuler.position = new Vector3(500.5f, 2.17f, 497.01f);

			is_init = true;
		}
		else if (Input.GetMouseButtonDown(1) && is_init == true)
		{
			transform.position = new Vector3(507, 4, 526);
			ForRuler.position = new Vector3(500.5f, 2.17f, 525.01f);

			is_init = false;
		}

		if (Input.GetMouseButtonDown(2))
			StartCoroutine(Springing());
	}

	private void Start()
	{
		upCube1Transform = GameObject.Find("upCube1").transform;
		upCube1PosInit = upCube1Transform.position;

		upCube2Transform = GameObject.Find("upCube2").transform;
		upCube2PosInit = upCube2Transform.position;

		ForRuler = GameObject.Find("ForRuler").transform;

		is_init = true;
	}
}
