using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonAngles : MonoBehaviour
{
	private float angle_x;
	private System.Random rnd = new System.Random();

	private PhotonDoing Script_PhotonDoing;
	private GameObject exampleSphere;
	private List<GameObject> photonOtherArray = new List<GameObject>();
	private GameObject otherPhoton;

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Box01")
			transform.eulerAngles = new Vector3(180 - angle_x, 0, 0);
		else if (other.gameObject.name == "Plane")
			transform.eulerAngles = new Vector3(180 - rnd.Next(-90, 90), 0, 180 - rnd.Next(-90, 90));
		else if (other.gameObject.name == "WaterBox")
		{
			transform.eulerAngles = new Vector3(180 - angle_x, 0, 0);

			otherPhoton = Instantiate(exampleSphere, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity); // Создание объекта
			otherPhoton.AddComponent<OtherPhoton>(); // Добавление скрипта
			otherPhoton.transform.eulerAngles = new Vector3(GameObject.Find("Lightbulb").GetComponent<PhotonDoing>().angle_x + 20, 0, 0); // Изменение угла
			otherPhoton.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
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
	}
}