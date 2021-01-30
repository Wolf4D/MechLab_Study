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
		if (isHidden == true)
			isHidden = false;
		else
			isHidden = true;
	}

	public void Instruction1()
	{
		if (isHidden1 == true)
			isHidden1 = false;
		else
			isHidden1 = true;
	}

	private void Update()
	{
		if (isHidden == true)
			Manual.SetActive(false);
		else
			Manual.SetActive(true);

		if (isHidden1 == true)
			k.SetActive(false);
		else
			k.SetActive(true);

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
	}
}
