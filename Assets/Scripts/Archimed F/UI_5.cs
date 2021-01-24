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

	private Text Density;
	private Text MG;
	private Text PUW;
	private Text FA;

	private void Update()
	{
		if (MoveTo.whichObj == '1')
		{
			Density.text = $"Плотность: {Ice_Script.objectDensity}";
			MG.text = $"mg: {Ice_Script.mg}";
			PUW.text = $"Погруженная часть: {Ice_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Ice_Script.forceArchimed}";
		}
		else if (MoveTo.whichObj == '2')
		{
			Density.text = $"Плотность: {Log_Script.objectDensity}";
			MG.text = $"mg: {Log_Script.mg}";
			PUW.text = $"Погруженная часть: {Log_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Log_Script.forceArchimed}";
		}
		else if (MoveTo.whichObj == '3')
		{
			Density.text = $"Плотность: {Bottle_Script.objectDensity}";
			MG.text = $"mg: {Bottle_Script.mg}";
			PUW.text = $"Погруженная часть: {Bottle_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Bottle_Script.forceArchimed}";
		}
		else if (MoveTo.whichObj == '4')
		{
			Density.text = $"Плотность: {Gold_Script.objectDensity}";
			MG.text = $"mg: {Gold_Script.mg}";
			PUW.text = $"Погруженная часть: {Gold_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Gold_Script.forceArchimed}";
		}
		else if (MoveTo.whichObj == '5')
		{
			Density.text = $"Плотность: {Glass_Script.objectDensity}";
			MG.text = $"mg: {Glass_Script.mg}";
			PUW.text = $"Погруженная часть: {Glass_Script.PartUnderWater}";
			FA.text = $"Сила архимеда: {Glass_Script.forceArchimed}";
		}
	}

	private void Start()
	{
		Ice_Script = GameObject.Find("Ice").GetComponent<AF_Ice>();
		Log_Script = GameObject.Find("Log").GetComponent<AF_Log>();
		Bottle_Script = GameObject.Find("Bottle").GetComponent<AF_Bottle>();
		Gold_Script = GameObject.Find("Gold").GetComponent<AF_Gold>();
		Glass_Script = GameObject.Find("Glass").GetComponent<AF_Glass>();

		Density = GameObject.Find("Density").GetComponent<Text>();
		MG = GameObject.Find("MG").GetComponent<Text>();
		PUW = GameObject.Find("PUW").GetComponent<Text>();
		FA = GameObject.Find("FA").GetComponent<Text>();
	}
}
