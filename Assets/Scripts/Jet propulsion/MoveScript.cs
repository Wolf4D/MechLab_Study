using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
	public static Rigidbody _rigidbody;

	public static int m1; // Масса ракеты с топливом
	public int m2; // Масса топлива
	public static int u; // Скорость вырывающихся газов
	public int df; // Расходы массы топлива в единицу времени
	public int F; // Сила, прикладываемая к ракете

	private void FixedUpdate() // 50 раз за секунду
	{
		if (m2 > 0)
		{
			m2 -= df / 50; // 50 * 50 = 2500
			m1 = 5000 + m2; // 5000 - конечная масса ракеты без топлива

			_rigidbody.mass = m1;
		}
		else
		{
			m1 = 5000;
			F = 0;
			UI_1.a = 0;
			_rigidbody.isKinematic = true;
		}

		_rigidbody.AddForce(0, F, 0);
	}

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody>();

		m1 = 300000;
		m2 = 270000;
		u = 2500;
		df = 2500;
		F = 6250000;
	}
}