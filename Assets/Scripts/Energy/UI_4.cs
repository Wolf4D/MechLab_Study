using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_4 : MonoBehaviour
{
	private ObjectScript ObjectScript_;

	private Text Mass;
	private Text M;
	private Text T0;

	private Text H;
	private Text V;
	private Text Ek;
	private Text Ep;
	private Text Ftr;
	private Text T;
	private Text Q;

	private void Update()
	{
		H.text = $"Высота: {Math.Round(ObjectScript_.h, 1)} м";
		V.text = $"Скорость: {Math.Round(ObjectScript_.v, 1)} м/с";
		Ek.text = $"Ек: {(int)ObjectScript_.Ek} Дж";
		Ep.text = $"Еп: {(int)ObjectScript_.Ep} Дж";
		Ftr.text = $"Сила трения: {Math.Round(ObjectScript_.Ftr, 1)} Н";
		T.text = $"Температура: {Math.Round(ObjectScript_.t, 4)} °C";
		Q.text = $"Выделенное тепло: {(int)ObjectScript_.Q} Дж";
		
		try
		{
			ObjectScript_.mass = (float)Convert.ToDouble(Mass.text);
		}
		catch { }

		try
		{
			ObjectScript_.M = (float)Convert.ToDouble(M.text);
		}
		catch { }

		try
		{
			ObjectScript_.t0 = (float)Convert.ToDouble(T0.text);
		}
		catch { }
	}

	private void Start()
	{
		ObjectScript_ = GameObject.Find("Object").GetComponent<ObjectScript>();

		Mass = GameObject.Find("Mass").GetComponent<Text>();
		M = GameObject.Find("M").GetComponent<Text>();
		T0 = GameObject.Find("T0").GetComponent<Text>();

		H = GameObject.Find("H").GetComponent<Text>();
		V = GameObject.Find("V").GetComponent<Text>();
		Ek = GameObject.Find("Ek").GetComponent<Text>();
		Ep = GameObject.Find("Ep").GetComponent<Text>();
		Ftr = GameObject.Find("Ftr").GetComponent<Text>();
		T = GameObject.Find("T").GetComponent<Text>();
		Q = GameObject.Find("Q").GetComponent<Text>();
	}
}
