﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_3 : MonoBehaviour
{
	private Spring1 Spring1_Script;
	private BigSpring BigSpring_Script;
	private GameObject Manual;

	private Text Input_k_parallel;
	private Text Input_m_parallel;
	private Text Input_k_posl;
	private Text Input_m_posl;
	private Text x1;
	private Text x2;

	private bool isHidden;

	public void Instruction()
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

		if (Spring1_Script.x < 0)
			Spring1_Script.x = 0;
		else
			x1.text = $"Δx: {Math.Round(Spring1_Script.x, 2)} м";

		if (BigSpring_Script.x < 0)
			BigSpring_Script.x = 0;
		else
			x2.text = $"Δx: {Math.Round(BigSpring_Script.x, 2)} м";

		try
		{
			Spring1_Script.k = (float)Convert.ToDouble(Input_k_parallel.text);
		}
		catch { }

		try
		{
			Spring1_Script.m = (float)Convert.ToDouble(Input_m_parallel.text);
		}
		catch { }

		try
		{
			BigSpring_Script.k = (float)Convert.ToDouble(Input_k_posl.text);
		}
		catch { }

		try
		{
			BigSpring_Script.m = (float)Convert.ToDouble(Input_m_posl.text);
		}
		catch { }
	}

	private void Start()
	{
		Manual = GameObject.Find("Manual");
		isHidden = true;

		Spring1_Script = GameObject.Find("Spring1").GetComponent<Spring1>();
		BigSpring_Script = GameObject.Find("BigSpring").GetComponent<BigSpring>();

		Input_k_parallel = GameObject.Find("Input_k_parallel").GetComponent<Text>();
		Input_m_parallel = GameObject.Find("Input_m_parallel").GetComponent<Text>();
		Input_k_posl = GameObject.Find("Input_k_posl").GetComponent<Text>();
		Input_m_posl = GameObject.Find("Input_m_posl").GetComponent<Text>();
		x1 = GameObject.Find("x1").GetComponent<Text>();
		x2 = GameObject.Find("x2").GetComponent<Text>();
	}
}
