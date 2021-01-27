using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stages : MonoBehaviour
{
	private GameObject[] turbines = new GameObject[4];
	private Rigidbody[] rbTurbines = new Rigidbody[4];

	public IEnumerator Jetting ()
	{
		yield return new WaitForSeconds(36);

		foreach (Rigidbody rbTurbine in rbTurbines)
			rbTurbine.isKinematic = false;

		foreach (GameObject turbine in turbines)
			turbine.transform.parent = null;
	}

	void Start()
    {
		for (int i = 0; i < 4; ++i)
		{
			turbines[i] = GameObject.Find($"Turbine{i + 1}");
			rbTurbines[i] = turbines[i].GetComponent<Rigidbody>();
		}

		StartCoroutine(Jetting());
	}
}
