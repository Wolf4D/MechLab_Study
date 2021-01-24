using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonDoing : MonoBehaviour
{
	private List<GameObject> photonArray = new List<GameObject>();
	private GameObject photonClone;
	private GameObject exampleSphere;
	private GameObject emptyPosition;
	public float angle_x;

	private IEnumerator Doing ()
	{
		yield return new WaitForSeconds(0.5f);

		for (int i = 0; i < 12; ++i)
		{
			photonClone = Instantiate(exampleSphere, emptyPosition.transform.position, Quaternion.identity);
			photonArray.Add(photonClone);
			photonArray[i].gameObject.name = "Photon_Clone " + (i+1);
			photonArray[i].layer = 8;
			photonArray[i].AddComponent<PhotonAngles>();
			photonArray[i].GetComponent<SphereCollider>().isTrigger = true;
			photonArray[i].AddComponent<Rigidbody>();
			photonArray[i].GetComponent<Rigidbody>().isKinematic = true;
			photonArray[i].GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;

			yield return new WaitForSeconds(0.3f);
		};	

		while (true)
		{
			for (int i = 0; i < 12; ++i)
			{
				photonArray[i].transform.position = emptyPosition.transform.position; 
				photonArray[i].transform.eulerAngles = new Vector3(angle_x, 0, 0);

				yield return new WaitForSeconds(0.3f);
			}
		}
	}

	private void Update()
	{
		foreach (GameObject photon in photonArray)
			photon.transform.Translate(Vector3.back * 5 * Time.deltaTime);
	}

	private void Start()
	{
		exampleSphere = GameObject.Find("Example_Sphere");
		emptyPosition = GameObject.Find("Empty_Position");
		StartCoroutine(Doing());
	}
}