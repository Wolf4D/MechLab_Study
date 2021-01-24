using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSpring : MonoBehaviour
{
	private GameObject cube2;
	private Rigidbody _rigidbodyCube2;
	private ConfigurableJoint _configurableJointCube2;
	private GameObject upCube2;

	private float height;
	private float springHeight;

	public float F; // Не изменяется человеком
	public float x; // Не изменяется человеком
	public float k; // Жёсткость каждой пружины; Может меняться человеком
	public float m; // Может меняться человеком

	private void Update()
	{
		height = upCube2.transform.position.y - cube2.transform.position.y - 1;
		transform.localScale = new Vector3(15, height * 8.5f, 15);
		transform.position = new Vector3(500, (upCube2.transform.position.y - 1) - (height - 1) / 2, 526);

		x = upCube2.transform.position.y - cube2.transform.position.y - 2;
		_configurableJointCube2.yDrive = new JointDrive() { positionSpring = k, positionDamper = 0, maximumForce = 3.402823e+38f };
		_rigidbodyCube2.mass = m;
		F = Math.Abs(1 / (1 / k + 1 / k) * x);
		// k = 1 / (1/k1 + 1/k2)
		// F = Math.Abs(k * x);
	}

	private void Start()
	{
		cube2 = GameObject.Find("Cube2");
		_rigidbodyCube2 =cube2.GetComponent<Rigidbody>();
		_configurableJointCube2 = cube2.GetComponent<ConfigurableJoint>();
		upCube2 = GameObject.Find("upCube2");

		k = cube2.GetComponent<ConfigurableJoint>().yDrive.positionSpring;
		m = cube2.GetComponent<Rigidbody>().mass;
	}
}