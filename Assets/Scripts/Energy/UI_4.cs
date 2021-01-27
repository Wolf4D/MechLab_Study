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
	private Transform Arrow;
	private Transform ArrowCanvas;

	private Text Mass;
	private Text M;
	private Text T0;

	private Text H;
	private Text V;
	public static Transform V1;
	private Text Vector123;
	private Text Ek;
	private Text Ep;
	private Text Ftr;
	private Text T;
	private Text Q;

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
		Arrow.localScale =	new Vector3(1 + ObjectScript_.v / 10, 0.25f + ObjectScript_.v / 35, 0);
		Arrow.eulerAngles = new Vector3(0, 0, _Object.eulerAngles.z - 90);
		ArrowCanvas.position = new Vector3(_Object.position.x, _Object.position.y, 500);

		if (isHidden == true)
			Manual.SetActive(false);
		else
			Manual.SetActive(true);

		H.text = $"h: {Math.Round(ObjectScript_.h, 1)} м";
		V.text = $"V: {Math.Round(ObjectScript_.v, 1)} м/с";
		Ek.text = $"Ек: {(int)ObjectScript_.Ek} Дж";
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
		Arrow = GameObject.Find("Arrow").transform;
		ArrowCanvas = GameObject.Find("ArrowCanvas").transform;
		V1 = GameObject.Find("V1").transform;
		Vector123 = GameObject.Find("Vector123").GetComponent<Text>();

		Manual = GameObject.Find("Manual");
		isHidden = true;

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
