using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	private GameObject Object;

	private void Update()
	{
		transform.position = new Vector3(Object.transform.position.x, Object.transform.position.y + 2, 495);
	}

	private void Start()
	{
		Object = GameObject.Find("Object");
	}
}
