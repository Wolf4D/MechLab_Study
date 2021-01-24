using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_2 : MonoBehaviour
{
	private int angle;

	private Text AngleText;
	private PhotonDoing PhotonDoing_Script;

	private void Update()
	{
		try
		{
			PhotonDoing_Script.angle_x = (float)Convert.ToDouble(AngleText.text);
		}

		catch { }
	}

	private void Start()
	{
		AngleText = GameObject.Find("AngleText").GetComponent<Text>();

		PhotonDoing_Script = GameObject.Find("Lightbulb").GetComponent<PhotonDoing>();
	}
}
