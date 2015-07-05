using UnityEngine;
using System.Collections;

public class SceneManagerScript : MonoBehaviour {
	// Update is called once per frame
	public void LoadMainScene()
	{
		Application.LoadLevel("Scene");
	}

	public void LoadMainMenu()
	{
		Application.LoadLevel("MainMenu");
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
