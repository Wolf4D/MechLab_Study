using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_5 : MonoBehaviour
{
	private AF_Ice Ice_Script;
	private AF_Log Log_Script;
	private AF_Bottle Bottle_Script;
	private AF_Gold Gold_Script;
	private AF_Glass Glass_Script;
	private GameObject Manual;
	private GameObject PUW;

	private Text Density;
	private Text V;
	private Text PUW_Text;
	private Text FA;

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
			PUW.SetActive(false);
		else
			PUW.SetActive(true);

		if (MoveTo.whichObj == '1')
		{
			Density.text = $"Плотность: {Ice_Script.objectDensity} кг/м³";
			V.text = "V: 1 м³";
			PUW_Text.text = $"Погруженная часть: {Ice_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Ice_Script.forceArchimed} Н";
		}
		else if (MoveTo.whichObj == '2')
		{
			Density.text = $"Плотность: {Log_Script.objectDensity} кг/м³";
			V.text = "V: 3,3 м³";
			PUW_Text.text = $"Погруженная часть: {Log_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Log_Script.forceArchimed} Н";
		}
		else if (MoveTo.whichObj == '3')
		{
			Density.text = $"Плотность: {Bottle_Script.objectDensity} кг/м³";
			V.text = "V: 0,0000315 м³";
			if (Bottle_Script.PartUnderWater == 0.02f | Bottle_Script.PartUnderWater == 0.03f)
				PUW_Text.text = "Погруженная часть: 0,03";
			else
				PUW_Text.text = $"Погруженная часть: {Bottle_Script.PartUnderWater}";
			if (Bottle_Script.PartUnderWater == 0.02f | Bottle_Script.PartUnderWater == 0.03f)
				FA.text = "Сила архимеда: 0,009 Н";
			else
				FA.text = $"Сила архимеда: {Bottle_Script.forceArchimed} Н";
		}
		else if (MoveTo.whichObj == '4')
		{
			Density.text = $"Плотность: {Gold_Script.objectDensity} кг/м³";
			V.text = "V: 0,4 м³";
			PUW_Text.text = $"Погруженная часть: {Gold_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Gold_Script.forceArchimed} Н";
		}
		else if (MoveTo.whichObj == '5')
		{
			Density.text = $"Плотность: {Glass_Script.objectDensity} кг/м³";
			V.text = "V: 0,52 м³";
			PUW_Text.text = $"Погруженная часть: {Glass_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Glass_Script.forceArchimed} Н";
		}
	}

	private void Start()
	{
		Manual = GameObject.Find("Manual");
		PUW = GameObject.Find("PUW");
		isHidden = true;
		isHidden1 = true;

		Ice_Script = GameObject.Find("Ice").GetComponent<AF_Ice>();
		Log_Script = GameObject.Find("Log").GetComponent<AF_Log>();
		Bottle_Script = GameObject.Find("Bottle").GetComponent<AF_Bottle>();
		Gold_Script = GameObject.Find("Gold").GetComponent<AF_Gold>();
		Glass_Script = GameObject.Find("Glass").GetComponent<AF_Glass>();

		Density = GameObject.Find("Density").GetComponent<Text>();
		V = GameObject.Find("V").GetComponent<Text>();
		PUW_Text = GameObject.Find("PUW").GetComponent<Text>();
		FA = GameObject.Find("FA").GetComponent<Text>();
	}
}