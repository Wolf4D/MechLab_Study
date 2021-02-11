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
	private GameObject AngleSqrt1;
	private Text AngleSqrt1_Text;
	private Text AngleSqrt_Text;

	private int angle;
	private bool isHidden;
	private bool isHidden1;

	public void Instruction()
	{
		isHidden = !isHidden;
	}

	public void Instruction1()
	{
		isHidden1 = !isHidden1;
	}

	private void Update()
	{
		Manual.SetActive(!isHidden);
		AngleSqrt1.SetActive(!isHidden1);

		AngleSqrt1_Text.text = AngleSqrt_Text.text;

		try
		{
			PhotonDoing_Script.angle_x = (float)Convert.ToDouble(AngleText.text);
		}
		catch { }
	}

	private void Start()
	{
		Manual = GameObject.Find("Manual");
		AngleSqrt1 = GameObject.Find("AngleSqrt1");
		AngleSqrt1_Text = GameObject.Find("AngleSqrt1").GetComponent<Text>();
		AngleSqrt_Text = GameObject.Find("AngleSqrt").GetComponent<Text>();
		isHidden = true;
		isHidden1 = true;

		AngleText = GameObject.Find("AngleText").GetComponent<Text>();

		PhotonDoing_Script = GameObject.Find("Lightbulb").GetComponent<PhotonDoing>();
	}
}
