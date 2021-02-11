using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBMove : MonoBehaviour
{
	private void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.LeftControl))
			transform.Translate(8 * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.LeftAlt))
			transform.Translate(-8 * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.LeftShift))
			transform.Translate(0, 0, 6 * Time.deltaTime);
		if (Input.GetKey(KeyCode.CapsLock))
			transform.Translate(0, 0, -6 * Time.deltaTime);
	}
}
