using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
	private GameObject Stage_2;
	private Rigidbody _rigidbodyStage2;

	private IEnumerator Jetting ()
	{
		yield return new WaitForSeconds(72);

		_rigidbodyStage2.isKinematic = false;
		Stage_2.transform.parent = null;
	}

	private void Start()
    {
		Stage_2 = GameObject.Find("Stage2");
		_rigidbodyStage2 = Stage_2.GetComponent<Rigidbody>();

		StartCoroutine(Jetting());
    }
}
