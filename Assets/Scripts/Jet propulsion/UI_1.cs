using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_1 : MonoBehaviour
{
	private Rigidbody _rigidbody;

	private Text[] Texts = new Text[4];
	public static int a;

	private void Update()
	{
		if (gameObject.name == Texts[0].name)
			Texts[0].text = $"Масса ракеты: {MoveScript.m1 / 1000} т";
		else if (gameObject.name == Texts[1].name)
			Texts[1].text = $"Скорость ракеты: {(int)_rigidbody.velocity.y} м/с";
		else if (gameObject.name == Texts[2].name)
			Texts[2].text = $"Скорость вырывающихся газов: {a} м/с";
		else if (gameObject.name == Texts[3].name)
			Texts[3].text = $"Расход топлива за секунду: {Math.Round(a / 1000f, 1)} т";
	}

	private void Start()
	{
		_rigidbody = GameObject.Find("Stage3").GetComponent<Rigidbody>();

		Texts[0] = GameObject.Find("m1").GetComponent<Text>();
		Texts[1] = GameObject.Find("v").GetComponent<Text>();
		Texts[2] = GameObject.Find("u").GetComponent<Text>();
		Texts[3] = GameObject.Find("df").GetComponent<Text>();

		a = 2500;
	}
}