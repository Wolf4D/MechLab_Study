using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AF_Gold : MonoBehaviour
{
	private Rigidbody _rigidbody;

	[SerializeField]
	public float forceArchimed;

	private GameObject Water;
	public float PartUnderWater;
	private float objectScaleY;

	public float objectDensity;
	private float objectVolume;
	public float mg;

	public const float waterDensity = 1000f;
	private const float g = 9.81f;
	private float submergedVolume;

	private float damper;
	public float dampingForce;

	private void OnTriggerStay(Collider col)
	{
		PartUnderWater = 1 - (transform.position.y + objectScaleY / 2 - Water.transform.position.y) / objectScaleY;
		if (PartUnderWater < 0f)
			PartUnderWater = 0f;
		else if (PartUnderWater > 1f)
			PartUnderWater = 1f;
		else
			PartUnderWater = (float)Math.Round(PartUnderWater, 2);

		submergedVolume = PartUnderWater * objectVolume;

		forceArchimed = waterDensity * g * submergedVolume;

		dampingForce = -_rigidbody.velocity.y * damper;
	}

	private void FixedUpdate()
	{
		_rigidbody.AddForce(0, forceArchimed + dampingForce, 0);
	}

	private void Start()
	{
		Water = GameObject.Find("Water");
		_rigidbody = GetComponent<Rigidbody>();

		objectDensity = 19300f;
		objectVolume = 2f * 0.33f * 0.6f;
		objectScaleY = 0.33f;

		_rigidbody.mass = objectDensity * objectVolume;
		mg = _rigidbody.mass * g;

		damper = _rigidbody.mass * 2f;
	}
}