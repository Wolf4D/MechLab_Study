using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_1 : MonoBehaviour
{
	private GameObject h;
	private GameObject Manual;
	private Rigidbody _rigidbody;
	private Text[] Texts = new Text[4];

	public static int a;
	private bool isHidden;
	private bool isHidden1;
	private bool paused = true;

	public void Instruction()
	{
		isHidden = !isHidden;
	}

	public void Instruction1()
	{
		isHidden1 = !isHidden1;
	}

	private IEnumerator A()
	{
		yield return new WaitForSeconds(261);

		a = 0;
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(1))
			if (!paused)
			{
				Time.timeScale = 0;
				paused = true;
			}
			else if (paused)
			{
				Time.timeScale = 5;
				paused = false;
			}

		h.SetActive(!isHidden);
		Manual.SetActive(!isHidden1);

		Texts[0].text = $"Масса ракеты: {(int)Stages.Mass / 1000} т";
		Texts[1].text = $"Скорость ракеты: {(int)_rigidbody.velocity.y} м/с";
		Texts[2].text = $"Скорость вырывающихся газов: {a} м/с";
		Texts[3].text = $"Расход топлива за секунду: {Stages.UI_Δf / 1000f} т";
	}

	private void Start()
	{
		_rigidbody = GameObject.Find("Stage3").GetComponent<Rigidbody>();

		isHidden = true;
		isHidden1 = true;

		h = GameObject.Find("h");
		Manual = GameObject.Find("Manual");
		Texts[0] = GameObject.Find("m1").GetComponent<Text>();
		Texts[1] = GameObject.Find("v").GetComponent<Text>();
		Texts[2] = GameObject.Find("u").GetComponent<Text>();
		Texts[3] = GameObject.Find("df").GetComponent<Text>();

		a = 2500;
		Time.timeScale = 0;
		StartCoroutine(A());
	}
}