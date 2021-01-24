using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBMove : MonoBehaviour
{
	private void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.A))
			transform.Translate(8 * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.D))
			transform.Translate(-8 * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.W))
			transform.Translate(0, 0, 6 * Time.deltaTime);
		if (Input.GetKey(KeyCode.S))
			transform.Translate(0, 0, -6 * Time.deltaTime);
	}
}
