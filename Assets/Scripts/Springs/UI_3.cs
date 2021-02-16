using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_3 : MonoBehaviour
{
	private Spring1 Spring1_Script;
	private BigSpring BigSpring_Script;
	private GameObject Manual;
	private GameObject k;

	private Text Input_m_parallel;
	private Text Input_m_posl;

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
		k.SetActive(!isHidden1);

		try
		{
			Spring1_Script.m = (float)Convert.ToDouble(Input_m_parallel.text);
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
		k = GameObject.Find("k");
		isHidden = true;
		isHidden1 = true;

		Spring1_Script = GameObject.Find("Spring1").GetComponent<Spring1>();
		BigSpring_Script = GameObject.Find("BigSpring").GetComponent<BigSpring>();

		Input_m_parallel = GameObject.Find("Input_m_parallel").GetComponent<Text>();
		Input_m_posl = GameObject.Find("Input_m_posl").GetComponent<Text>();

		Time.timeScale = 1;
	}
}
