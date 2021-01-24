using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring2 : MonoBehaviour
{
	private GameObject cube1;
	private GameObject upCube1;

	private float height;
	private float springHeight;

	private void Update()
	{
		height = upCube1.transform.position.y - cube1.transform.position.y - 1;

		transform.localScale = new Vector3(15, height * 15, 15);
		transform.position = new Vector3(500, (upCube1.transform.position.y - 1) - (height - 1) / 2, 501.5f);
	}

	private void Start()
	{
		cube1 = GameObject.Find("Cube1");
		upCube1 = GameObject.Find("upCube1");
	}
}
