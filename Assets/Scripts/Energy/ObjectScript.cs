using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
	private GameObject Ground;
	private BoxCollider Ground_Box_Collider;
	private GameObject Object_For_Distance;
	private Rigidbody _rigidbody;
	private bool paused = false;

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
		if (Input.GetKeyDown(KeyCode.S))
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

		h = transform.position.y;
		if (h < 0.151f)
			h = 0;
		v = _rigidbody.velocity.magnitude;
		_rigidbody.mass = mass;
		Ground_Box_Collider.material.dynamicFriction = M;
		Ground_Box_Collider.material.staticFriction = M;
		S = Vector3.Distance(Object_For_Distance.transform.position, transform.position);
		N = mass * g * (float)System.Math.Cos(90 - Ground.transform.eulerAngles.z);

		Ftr = M * -N;
		A = Ftr * S;
		Q = A;
		t = Q / c / mass + t0;
		Ek = mass * v * v / 2;
		Ep = mass * g * h;
	}

	private void Start()
	{
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