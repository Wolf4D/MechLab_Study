using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_1 : MonoBehaviour
{
	private MoveScript stupen3;

	private float rocketMass;
	private int rocketSpeed;
	private float fuelMass;
	private float fuelImpulse;

	private Text[] Texts = new Text[4];

	private void Update()
	{
		rocketMass = stupen3.rocketMass;
		rocketSpeed = (int)stupen3.rocketSpeed;
		fuelMass = stupen3.fuelMass;
		fuelImpulse = stupen3.fuelImpulse;

		if(gameObject.name == Texts[0].name)
			Texts[0].text = $"Масса ракеты: {rocketMass} тонн";
		else if (gameObject.name == Texts[1].name)
			Texts[1].text = $"Скорость ракеты: {rocketSpeed} м/с";
		else if (gameObject.name == Texts[2].name)
			Texts[2].text = $"Масса топлива: {fuelMass} тонн";
		else if (gameObject.name == Texts[3].name)
			Texts[3].text = $"Импульс топлива: {fuelImpulse} кг * м/с";
	}

	private void Start()
	{
		stupen3 = GameObject.Find("3stupen").GetComponent<MoveScript>();

		rocketMass = stupen3.rocketMass;
		rocketSpeed = (int)stupen3.rocketSpeed;
		fuelMass = stupen3.fuelMass;
		fuelImpulse = stupen3.fuelImpulse;

		Texts[0] = GameObject.Find("RocketMass_").GetComponent<Text>();
		Texts[1] = GameObject.Find("RocketSpeed_").GetComponent<Text>();
		Texts[2] = GameObject.Find("FuelMass_").GetComponent<Text>();
		Texts[3] = GameObject.Find("FuelImpulse_").GetComponent<Text>();
	}
}