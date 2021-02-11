using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AF_Log : MonoBehaviour
{
	private Rigidbody _rigidbody;

	[SerializeField]
	public float forceArchimed;

	private Transform Water;
	public float h;
	public float PartUnderWater;
	private float objectScaleY;

	public float objectDensity;
	public float objectVolume;

	public const float waterDensity = 1000f;
	private const float g = 9.81f;
	private float submergedVolume;

	private float damper;
	public float dampingForce;

	private void OnTriggerStay(Collider col)
	{
		PartUnderWater = 1 - (transform.position.y + objectScaleY / 2 - Water.position.y) / objectScaleY;
		if (PartUnderWater < 0f)
			PartUnderWater = 0f;
		else if (PartUnderWater > 1f)
			PartUnderWater = 1f;
		else
			PartUnderWater = (float)Math.Round(PartUnderWater, 2);

		submergedVolume = PartUnderWater * objectVolume;
		h = submergedVolume / 12.5f;
		Water.position = new Vector3(500, 3 + h, 500);

		forceArchimed = waterDensity * g * submergedVolume;

		dampingForce = -_rigidbody.velocity.y * damper;
	}

	private void FixedUpdate()
	{
		_rigidbody.AddForce(0, forceArchimed + dampingForce, 0);
	}

	private void Start()
	{
		Water = GameObject.Find("Water").transform;
		_rigidbody = GetComponent<Rigidbody>();

		objectDensity = 500f;
		objectVolume = 3f * 1.1f * 1f;
		objectScaleY = 1.1f;

		_rigidbody.mass = objectDensity * objectVolume;

		damper = _rigidbody.mass * 2f;
	}
}