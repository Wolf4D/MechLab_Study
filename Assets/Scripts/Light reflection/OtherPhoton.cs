using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPhoton : MonoBehaviour
{
	private Transform Empty_Position;
	private Transform Wall4_PosZ;

	private IEnumerator Destroying()
	{
		yield return new WaitForSeconds((24 - (Empty_Position.position.z - Wall4_PosZ.position.z)) / 5);

		Destroy(gameObject);
	}

	private void Update()
    {
		transform.Translate(Vector3.back * 5 * Time.deltaTime);
	}

	private void Start()
	{
		Empty_Position = GameObject.Find("Empty_Position").transform;
		Wall4_PosZ = GameObject.Find("Wall4_PosZ").transform;

		StartCoroutine(Destroying());
	}
}
