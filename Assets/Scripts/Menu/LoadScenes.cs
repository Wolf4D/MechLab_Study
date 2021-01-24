using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
	public void Jetpropulsion()
	{
		SceneManager.LoadScene(1);
	}

	public void Lightreflection()
	{
		SceneManager.LoadScene(2);
	}

	public void Springs()
	{
		SceneManager.LoadScene(3);
	}

	public void Energy()
	{
		SceneManager.LoadScene(4);
	}

	public void ArchimedF()
	{
		SceneManager.LoadScene(5);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
