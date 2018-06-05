using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when the button is pressed, the custom maze level is loaded

public class CustomButton : MonoBehaviour
{
	bool _customButtonDown;

	// Update is called once per frame
	void Update ()
	{

		if (_customButtonDown) 
		{
			SceneManager.LoadScene ("CustomMaze");
		}
	}

	public void OnCustomButtonDown (bool down)
	{
		_customButtonDown = down;
	}

}