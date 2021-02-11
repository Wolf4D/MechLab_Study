using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_4 : MonoBehaviour
{
	private ObjectScript ObjectScript_;
	private GameObject Manual;
	private Transform _Object;
	private Transform ArrowCanvas;
	private GameObject Ek;

	private Text Mass;
	private Text M;
	private Text T0;

	private Text H;
	private Text V;
	private Text Vector123;
	private Text Ek_Text;
	private Text Ep;
	private Text Ftr;
	private Text T;
	private Text Q;

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
		Ek.SetActive(!isHidden1);

		ArrowCanvas.position = new Vector3(_Object.position.x, _Object.position.y, 500);

		H.text = $"h: {Math.Round(ObjectScript_.h, 1)} м";
		V.text = $"V: {Math.Round(ObjectScript_.v, 1)} м/с";
		Ek_Text.text = $"Ек: {(int)ObjectScript_.Ek} Дж";
		Ep.text = $"Еп: {(int)ObjectScript_.Ep} Дж";
		Ftr.text = $"Fтр: {Math.Round(ObjectScript_.Ftr, 1)} Н";
		T.text = $"t: {Math.Round(ObjectScript_.t, 4)} °C";
		Q.text = $"Q: {(int)ObjectScript_.Q} Дж";
		
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
		_Object = GameObject.Find("Object").transform;
		ArrowCanvas = GameObject.Find("ArrowCanvas").transform;
		Vector123 = GameObject.Find("Vector123").GetComponent<Text>();

		Manual = GameObject.Find("Manual");
		Ek = GameObject.Find("Ek");
		isHidden = true;
		isHidden1 = true;

		ObjectScript_ = GameObject.Find("Object").GetComponent<ObjectScript>();

		Mass = GameObject.Find("Mass").GetComponent<Text>();
		M = GameObject.Find("M").GetComponent<Text>();
		T0 = GameObject.Find("T0").GetComponent<Text>();

		H = GameObject.Find("H").GetComponent<Text>();
		V = GameObject.Find("V").GetComponent<Text>();
		Ek_Text = GameObject.Find("Ek").GetComponent<Text>();
		Ep = GameObject.Find("Ep").GetComponent<Text>();
		Ftr = GameObject.Find("Ftr").GetComponent<Text>();
		T = GameObject.Find("T").GetComponent<Text>();
		Q = GameObject.Find("Q").GetComponent<Text>();
	}
}
