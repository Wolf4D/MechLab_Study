using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
	private GameObject[] Objects = new GameObject[5];
	private Transform Water;
	public static char whichObj;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			foreach (GameObject obj in Objects)
			{
				obj.GetComponent<Rigidbody>().isKinematic = true;
				obj.transform.position = new Vector3(500, 6, 0);
			}

			Objects[0].GetComponent<AF_Ice>().forceArchimed = 0;
			Objects[1].GetComponent<AF_Log>().forceArchimed = 0;
			Objects[2].GetComponent<AF_Bottle>().forceArchimed = 0;
			Objects[3].GetComponent<AF_Gold>().forceArchimed = 0;
			Objects[4].GetComponent<AF_Glass>().forceArchimed = 0;

			Objects[0].GetComponent<AF_Ice>().PartUnderWater = 0;
			Objects[1].GetComponent<AF_Log>().PartUnderWater = 0;
			Objects[2].GetComponent<AF_Bottle>().PartUnderWater = 0;
			Objects[3].GetComponent<AF_Gold>().PartUnderWater = 0;
			Objects[4].GetComponent<AF_Glass>().PartUnderWater = 0;

			Objects[0].GetComponent<AF_Ice>().dampingForce = 0;
			Objects[1].GetComponent<AF_Log>().dampingForce = 0;
			Objects[2].GetComponent<AF_Bottle>().dampingForce = 0;
			Objects[3].GetComponent<AF_Gold>().dampingForce = 0;
			Objects[4].GetComponent<AF_Glass>().dampingForce = 0;

			Objects[0].GetComponent<AF_Ice>().h = 0;
			Objects[1].GetComponent<AF_Log>().h = 0;
			Objects[3].GetComponent<AF_Gold>().h = 0;
			Objects[4].GetComponent<AF_Glass>().h = 0;

			Water.position = new Vector3(500, 3, 500);

			Objects[0].transform.position = new Vector3(500, 6, 500);
			Objects[0].GetComponent<Rigidbody>().isKinematic = false;

			whichObj = '1';
		}

		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			foreach (GameObject obj in Objects)
			{
				obj.GetComponent<Rigidbody>().isKinematic = true;
				obj.transform.position = new Vector3(500, 6, 0);
			}

			Objects[0].GetComponent<AF_Ice>().forceArchimed = 0;
			Objects[1].GetComponent<AF_Log>().forceArchimed = 0;
			Objects[2].GetComponent<AF_Bottle>().forceArchimed = 0;
			Objects[3].GetComponent<AF_Gold>().forceArchimed = 0;
			Objects[4].GetComponent<AF_Glass>().forceArchimed = 0;

			Objects[0].GetComponent<AF_Ice>().PartUnderWater = 0;
			Objects[1].GetComponent<AF_Log>().PartUnderWater = 0;
			Objects[2].GetComponent<AF_Bottle>().PartUnderWater = 0;
			Objects[3].GetComponent<AF_Gold>().PartUnderWater = 0;
			Objects[4].GetComponent<AF_Glass>().PartUnderWater = 0;

			Objects[0].GetComponent<AF_Ice>().dampingForce = 0;
			Objects[1].GetComponent<AF_Log>().dampingForce = 0;
			Objects[2].GetComponent<AF_Bottle>().dampingForce = 0;
			Objects[3].GetComponent<AF_Gold>().dampingForce = 0;
			Objects[4].GetComponent<AF_Glass>().dampingForce = 0;

			Objects[0].GetComponent<AF_Ice>().h = 0;
			Objects[1].GetComponent<AF_Log>().h = 0;
			Objects[3].GetComponent<AF_Gold>().h = 0;
			Objects[4].GetComponent<AF_Glass>().h = 0;

			Water.position = new Vector3(500, 3, 500);

			Objects[1].transform.position = new Vector3(500, 6, 500);
			Objects[1].GetComponent<Rigidbody>().isKinematic = false;

			whichObj = '2';
		}

		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			foreach (GameObject obj in Objects)
			{
				obj.GetComponent<Rigidbody>().isKinematic = true;
				obj.transform.position = new Vector3(500, 6, 0);
			}

			Objects[0].GetComponent<AF_Ice>().forceArchimed = 0;
			Objects[1].GetComponent<AF_Log>().forceArchimed = 0;
			Objects[2].GetComponent<AF_Bottle>().forceArchimed = 0;
			Objects[3].GetComponent<AF_Gold>().forceArchimed = 0;
			Objects[4].GetComponent<AF_Glass>().forceArchimed = 0;

			Objects[0].GetComponent<AF_Ice>().PartUnderWater = 0;
			Objects[1].GetComponent<AF_Log>().PartUnderWater = 0;
			Objects[2].GetComponent<AF_Bottle>().PartUnderWater = 0;
			Objects[3].GetComponent<AF_Gold>().PartUnderWater = 0;
			Objects[4].GetComponent<AF_Glass>().PartUnderWater = 0;

			Objects[0].GetComponent<AF_Ice>().dampingForce = 0;
			Objects[1].GetComponent<AF_Log>().dampingForce = 0;
			Objects[2].GetComponent<AF_Bottle>().dampingForce = 0;
			Objects[3].GetComponent<AF_Gold>().dampingForce = 0;
			Objects[4].GetComponent<AF_Glass>().dampingForce = 0;

			Objects[0].GetComponent<AF_Ice>().h = 0;
			Objects[1].GetComponent<AF_Log>().h = 0;
			Objects[3].GetComponent<AF_Gold>().h = 0;
			Objects[4].GetComponent<AF_Glass>().h = 0;

			Water.position = new Vector3(500, 3, 500);

			Objects[2].transform.position = new Vector3(500, 6, 499.3f);
			Objects[2].GetComponent<Rigidbody>().isKinematic = false;

			whichObj = '3';
		}

		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			foreach (GameObject obj in Objects)
			{
				obj.GetComponent<Rigidbody>().isKinematic = true;
				obj.transform.position = new Vector3(500, 6, 0);
			}

			Objects[0].GetComponent<AF_Ice>().forceArchimed = 0;
			Objects[1].GetComponent<AF_Log>().forceArchimed = 0;
			Objects[2].GetComponent<AF_Bottle>().forceArchimed = 0;
			Objects[3].GetComponent<AF_Gold>().forceArchimed = 0;
			Objects[4].GetComponent<AF_Glass>().forceArchimed = 0;

			Objects[0].GetComponent<AF_Ice>().PartUnderWater = 0;
			Objects[1].GetComponent<AF_Log>().PartUnderWater = 0;
			Objects[2].GetComponent<AF_Bottle>().PartUnderWater = 0;
			Objects[3].GetComponent<AF_Gold>().PartUnderWater = 0;
			Objects[4].GetComponent<AF_Glass>().PartUnderWater = 0;

			Objects[0].GetComponent<AF_Ice>().dampingForce = 0;
			Objects[1].GetComponent<AF_Log>().dampingForce = 0;
			Objects[2].GetComponent<AF_Bottle>().dampingForce = 0;
			Objects[3].GetComponent<AF_Gold>().dampingForce = 0;
			Objects[4].GetComponent<AF_Glass>().dampingForce = 0;

			Objects[0].GetComponent<AF_Ice>().h = 0;
			Objects[1].GetComponent<AF_Log>().h = 0;
			Objects[3].GetComponent<AF_Gold>().h = 0;
			Objects[4].GetComponent<AF_Glass>().h = 0;

			Water.position = new Vector3(500, 3, 500);

			Objects[3].transform.position = new Vector3(500, 6, 500);
			Objects[3].GetComponent<Rigidbody>().isKinematic = false;

			whichObj = '4';
		}

		else if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			foreach (GameObject obj in Objects)
			{
				obj.GetComponent<Rigidbody>().isKinematic = true;
				obj.transform.position = new Vector3(500, 6, 0);
			}

			Objects[0].GetComponent<AF_Ice>().forceArchimed = 0;
			Objects[1].GetComponent<AF_Log>().forceArchimed = 0;
			Objects[2].GetComponent<AF_Bottle>().forceArchimed = 0;
			Objects[3].GetComponent<AF_Gold>().forceArchimed = 0;
			Objects[4].GetComponent<AF_Glass>().forceArchimed = 0;

			Objects[0].GetComponent<AF_Ice>().PartUnderWater = 0;
			Objects[1].GetComponent<AF_Log>().PartUnderWater = 0;
			Objects[2].GetComponent<AF_Bottle>().PartUnderWater = 0;
			Objects[3].GetComponent<AF_Gold>().PartUnderWater = 0;
			Objects[4].GetComponent<AF_Glass>().PartUnderWater = 0;

			Objects[0].GetComponent<AF_Ice>().dampingForce = 0;
			Objects[1].GetComponent<AF_Log>().dampingForce = 0;
			Objects[2].GetComponent<AF_Bottle>().dampingForce = 0;
			Objects[3].GetComponent<AF_Gold>().dampingForce = 0;
			Objects[4].GetComponent<AF_Glass>().dampingForce = 0;

			Objects[0].GetComponent<AF_Ice>().h = 0;
			Objects[1].GetComponent<AF_Log>().h = 0;
			Objects[3].GetComponent<AF_Gold>().h = 0;
			Objects[4].GetComponent<AF_Glass>().h = 0;

			Water.position = new Vector3(500, 3, 500);

			Objects[4].transform.position = new Vector3(500, 6, 500);
			Objects[4].GetComponent<Rigidbody>().isKinematic = false;

			whichObj = '5';
		}
	}

	private void Start()
	{
		Objects[0] = GameObject.Find("Ice");
		Objects[1] = GameObject.Find("Log");
		Objects[2] = GameObject.Find("Bottle");
		Objects[3] = GameObject.Find("Gold");
		Objects[4] = GameObject.Find("Glass");

		Water = GameObject.Find("Water").transform;

		foreach (GameObject obj in Objects)
		{
			obj.GetComponent<Rigidbody>().isKinematic = true;
			obj.transform.position = new Vector3(500, 6, 0);
		}
	}
}