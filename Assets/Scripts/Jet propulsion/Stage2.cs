using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
	private GameObject Stupen2;
	private Rigidbody _rigidbody2stupen;

	private IEnumerator Jetting ()
	{
		yield return new WaitForSeconds(72);

		_rigidbody2stupen.isKinematic = false;
		Stupen2.transform.parent = null;
	}

	private void Start()
    {
		Stupen2 = GameObject.Find("2stupen");
		_rigidbody2stupen = Stupen2.GetComponent<Rigidbody>();

		StartCoroutine(Jetting());
    }
}
