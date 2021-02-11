using System;
using static System.Math;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class radToDeg
{
	public static float normal(float angle)
		{
			angle = angle / 180 * (float)PI;

			return angle;
		}

	public static float arc(float angle)
		{
			angle = angle * 180 / (float)PI;

			return angle;
		}
}

public class PhotonAngles : MonoBehaviour
{
	private System.Random rnd = new System.Random();
	private PhotonDoing Script_PhotonDoing;

	private GameObject exampleSphere;
	private List<GameObject> photonOtherArray = new List<GameObject>();
	private GameObject otherPhoton;

	private Text angleSqrt;
	private Text Kef;
	private float angle_x;
	private float angleSqrtDegWater;
	private float angleSqrtDegGlass;

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Box01")
		{
			transform.eulerAngles = new Vector3(180 - angle_x, 0, 0);
			angleSqrt.text = "От зеркала фотоны отражаются под тем же углом, под которым вылетели из лампочки";
			Kef.text = "Коэф. преломления: 0";
		}
		else if (other.gameObject.name == "Plane")
		{
			transform.eulerAngles = new Vector3(180 - rnd.Next(-90, 90), 0, 180 - rnd.Next(-90, 90));
			angleSqrt.text = "Так как поверхность бумаги шершавая, фотоны отражаются под хаотичным углом";
			Kef.text = "Коэф. преломления: 0";
		}
		else if (other.gameObject.name == "Glass")
		{
			angleSqrtDegGlass = (int)radToDeg.arc((float)Asin(Sin(radToDeg.normal(angle_x)) / 1.51f));
			angleSqrt.text = $"Угол преломления: {angleSqrtDegGlass}°";
			Kef.text = "Коэф. преломления: 1,51";
			transform.eulerAngles = new Vector3(180 - angle_x, 0, 0);

			otherPhoton = Instantiate(exampleSphere, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			otherPhoton.AddComponent<OtherPhoton>();
			if (angle_x < 56)
				otherPhoton.transform.eulerAngles = new Vector3(angle_x + angleSqrtDegGlass, 0, 0);
			else
				otherPhoton.transform.eulerAngles = new Vector3(86, 0, 0);
			otherPhoton.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
			otherPhoton.AddComponent<TrailRenderer>();
			otherPhoton.GetComponent<TrailRenderer>().startWidth = 0.04f;
			otherPhoton.GetComponent<TrailRenderer>().time = 0.35f;
			otherPhoton.GetComponent<TrailRenderer>().material = (Material)Resources.Load("ReflectedMat");
			otherPhoton.AddComponent<Color_Phot>();
		}
		else if (other.gameObject.name == "WaterBox")
		{
			angleSqrtDegWater = (int)radToDeg.arc((float)Asin(Sin(radToDeg.normal(angle_x)) / 1.33f));
			angleSqrt.text = $"Угол преломления: {angleSqrtDegWater}°";
			Kef.text = "Коэф. преломления: 1,33";
			transform.eulerAngles = new Vector3(180 - angle_x, 0, 0);

			otherPhoton = Instantiate(exampleSphere, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			otherPhoton.AddComponent<OtherPhoton>();
			if (angle_x < 51)
				otherPhoton.transform.eulerAngles = new Vector3(angle_x + angleSqrtDegWater, 0, 0);
			else
				otherPhoton.transform.eulerAngles = new Vector3(86, 0, 0);
			otherPhoton.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
			otherPhoton.AddComponent<TrailRenderer>();
			otherPhoton.GetComponent<TrailRenderer>().startWidth = 0.04f;
			otherPhoton.GetComponent<TrailRenderer>().time = 0.35f;
			otherPhoton.GetComponent<TrailRenderer>().material = (Material)Resources.Load("ReflectedMat");
		}
	}

	private void Update()
	{
		angle_x = Script_PhotonDoing.angle_x;
	}

	private void Start()
	{
		Script_PhotonDoing = GameObject.Find("Lightbulb").GetComponent<PhotonDoing>();

		exampleSphere = GameObject.Find("Example_Sphere");

		angleSqrt = GameObject.Find("AngleSqrt").GetComponent<Text>();
		Kef = GameObject.Find("Kef").GetComponent<Text>();
	}
}