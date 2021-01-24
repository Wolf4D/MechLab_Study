using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPhoton : MonoBehaviour
{
	private IEnumerator Destroying()
	{
		yield return new WaitForSeconds((24 - (GameObject.Find("Empty_Position").transform.position.z - GameObject.Find("Wall4_PosZ").transform.position.z)) / 5);

		Destroy(gameObject);
	}

	private void Update()
    {
		transform.Translate(Vector3.back * 5 * Time.deltaTime);
	}

	private void Start()
	{
		StartCoroutine(Destroying());
	}
}
