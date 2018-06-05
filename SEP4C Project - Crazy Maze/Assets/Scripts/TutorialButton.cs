using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when the tutorial button is pressed, the Tutorial level is loaded

public class TutorialButton : MonoBehaviour
{
	bool _tutorialButtonDown;

	// Update is called once per frame
	void Update ()
	{

		if (_tutorialButtonDown) 
		{
			SceneManager.LoadScene ("Tutorial");
		}
	}

	public void OnTutorialButtonDown (bool down)
	{
		_tutorialButtonDown = down;
	}

}
