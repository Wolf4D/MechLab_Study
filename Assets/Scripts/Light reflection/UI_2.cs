using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_2 : MonoBehaviour
{
	private PhotonDoing PhotonDoing_Script;
	private Text AngleText;
	private GameObject Manual;

	private int angle;
	private bool isHidden;

	public void Instruction ()
	{
		if (isHidden == true)
			isHidden = false;
		else
			isHidden = true;
	}

	private void Update()
	{
		if (isHidden == true)
			Manual.SetActive(false);
		else
			Manual.SetActive(true);

		try
		{
			PhotonDoing_Script.angle_x = (float)Convert.ToDouble(AngleText.text);
		}

		catch { }
	}

	private void Start()
	{
		Manual = GameObject.Find("Manual");
		isHidden = true;

		AngleText = GameObject.Find("AngleText").GetComponent<Text>();

		PhotonDoing_Script = GameObject.Find("Lightbulb").GetComponent<PhotonDoing>();
	}
}
