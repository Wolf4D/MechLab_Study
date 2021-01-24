using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
	private Transform upCube1Transform;
	private Vector3 upCube1PosInit;

	private Transform upCube2Transform;
	private Vector3 upCube2PosInit;

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
		if (Input.GetKeyDown(KeyCode.A))
			transform.position = new Vector3(509, 5, 500);
		if (Input.GetKeyDown(KeyCode.D))
			transform.position = new Vector3(509, 5, 526);

		if (Input.GetKeyDown(KeyCode.R))
			StartCoroutine(Springing());
	}

	private void Start()
	{
		upCube1Transform = GameObject.Find("upCube1").transform;
		upCube1PosInit = upCube1Transform.position;

		upCube2Transform = GameObject.Find("upCube2").transform;
		upCube2PosInit = upCube2Transform.position;
	}
}
