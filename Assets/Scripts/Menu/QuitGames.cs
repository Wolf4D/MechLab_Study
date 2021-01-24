using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGames : MonoBehaviour
{
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
				SceneManager.LoadScene(0);
	}
}
