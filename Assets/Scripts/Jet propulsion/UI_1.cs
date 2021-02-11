using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_1 : MonoBehaviour
{
	private GameObject h;
	private Rigidbody _rigidbody;
	private Text[] Texts = new Text[4];

	public static int a;
	private bool isHidden;

	public void Instruction()
	{
		isHidden = !isHidden;
	}

	private IEnumerator A()
	{
		yield return new WaitForSeconds(261);

		a = 0;
	}

	private void Update()
	{
		h.SetActive(!isHidden);

		Texts[0].text = $"Масса ракеты: {(int)Stages.Mass / 1000} т";
		Texts[1].text = $"Скорость ракеты: {(int)_rigidbody.velocity.y} м/с";
		Texts[2].text = $"Скорость вырывающихся газов: {a} м/с";
		Texts[3].text = $"Расход топлива за секунду: {Stages.UI_Δf / 1000f} т";
	}

	private void Start()
	{
		_rigidbody = GameObject.Find("Stage3").GetComponent<Rigidbody>();

		isHidden = true;

		h = GameObject.Find("h");
		Texts[0] = GameObject.Find("m1").GetComponent<Text>();
		Texts[1] = GameObject.Find("v").GetComponent<Text>();
		Texts[2] = GameObject.Find("u").GetComponent<Text>();
		Texts[3] = GameObject.Find("df").GetComponent<Text>();

		a = 2500;
		StartCoroutine(A());
	}
}