using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
	private GameObject Ground;
	private BoxCollider Ground_Box_Collider;
	private GameObject Object_For_Distance;
	private Rigidbody _rigidbody;
	private GameObject[] arrows = new GameObject[3];
	private GameObject[] signs = new GameObject[3];
	private bool paused = true;

	public float h; // Высота;								Не изменяется человеком
	public float v; // Скорость;							Не изменяется человеком
	public float t; // Температура;							Не изменяется человеком
	private float N; // Сила реакции опоры;					Не изменяется человеком
	public float Ftr; // Сила трения						Не изменяется человеком
	private float S; // Пройденное расстояние				Не изменяется человеком
	private float A; // Работа силы трения					Не изменяется человеком

	public float mass; // Масса;							Может изменяться человеком
	public float M; // Коэффициент трения;					Может изменяться человеком
	public float t0; // Начальная температура;				Может изменяться человеком

	public float Ek; // Кинетическая энергия;				Не изменяется человеком
	public float Ep; // Потенциальная энергия;				Не изменяется человеком
	public float Q; // Количество произведённой теплоты;	Не изменяется человеком

	private const float g = 9.81f; // Гравитационная постоянная
	private const int c = 1700; // Удельная теплоёмкость древесины

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
				Time.timeScale = 1;
				paused = false;
			}

		h = transform.position.y - 0.15f;
		if (h < 0.5f)
		{
			arrows[0].SetActive(false);
			arrows[1].SetActive(false);
			arrows[2].SetActive(false);
			signs[0].SetActive(false);
			signs[1].SetActive(false);
			signs[2].SetActive(false);
		}

		if (_rigidbody.velocity.x > 0)
			v = (float)Math.Sqrt((_rigidbody.velocity.x * _rigidbody.velocity.x) + (_rigidbody.velocity.y * _rigidbody.velocity.y));
		else
		{
			v = 0;
		}

		_rigidbody.mass = mass;
		Ground_Box_Collider.material.dynamicFriction = M;
		Ground_Box_Collider.material.staticFriction = M;
		S = Vector3.Distance(Object_For_Distance.transform.position, transform.position);
		N = mass * g * (float)Math.Cos(90 - Ground.transform.eulerAngles.z);

		Ftr = M * N;
		A = Ftr * S;
		Q = A;
		t = Q / c / mass + t0;
		Ek = mass * v * v / 2;
		Ep = mass * g * h;
	}

	private void Start()
	{
		Time.timeScale = 0;
		v = 0;
		Ftr = 0;

		arrows[0] = GameObject.Find("Ftr_Arrow");
		arrows[1] = GameObject.Find("mg_Arrow");
		arrows[2] = GameObject.Find("N_Arrow");
		signs[0] = GameObject.Find("Ftr_Sign");
		signs[1] = GameObject.Find("mg_Sign");
		signs[2] = GameObject.Find("N_Sign");

		Ground = GameObject.Find("Ground");
		Object_For_Distance = GameObject.Find("Object_For_Distance");

		Object_For_Distance.transform.parent = null;
		transform.parent = null;
		_rigidbody = GetComponent<Rigidbody>();
		Ground_Box_Collider = Ground.GetComponent<BoxCollider>();

		if (mass == 0)
			mass = 1;
	}
}
