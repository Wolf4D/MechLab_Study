using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring1 : MonoBehaviour
{
	private GameObject cube1;
	private Rigidbody _rigidbodyCube1;
	private ConfigurableJoint _configurableJointCube1;
	private GameObject upCube1;

	private float height;
	private float springHeight;

	public float F; // Не изменяется человеком
	public float x; // Не изменяется человеком
	public float k; // Жёсткость каждой пружины; Может меняться человеком
	public float m; // Может меняться человеком

	private void Update()
	{
		height = upCube1.transform.position.y - cube1.transform.position.y - 1;
		transform.localScale = new Vector3(15, height * 15, 15);
		transform.position = new Vector3(500, (upCube1.transform.position.y - 1) - (height - 1) / 2, 498.5f);

		x = upCube1.transform.position.y - cube1.transform.position.y - 2;
		_configurableJointCube1.yDrive = new JointDrive() { positionSpring = 2 * k, positionDamper = 0, maximumForce = 3.402823e+38f };
		_rigidbodyCube1.mass = m;
		F = Math.Abs(2 * k * x);
	}

	private void Start()
	{
		cube1 = GameObject.Find("Cube1");
		_rigidbodyCube1 = cube1.GetComponent<Rigidbody>();
		_configurableJointCube1 = cube1.GetComponent<ConfigurableJoint>();
		upCube1 = GameObject.Find("upCube1");

		k = cube1.GetComponent<ConfigurableJoint>().yDrive.positionSpring;
		m = cube1.GetComponent<Rigidbody>().mass;
	}
}