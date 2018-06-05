using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when the EXIT button is pressed, the user returns to main menu

public class ExitButton : MonoBehaviour
{
	bool _exitButtonDown;

	// Update is called once per frame
	void Update ()
	{

		if (_exitButtonDown) 
		{
			SceneManager.LoadScene ("MainMenu");
		}
	}

	public void OnExitButtonDown (bool down)
	{
		_exitButtonDown = down;
	}

}
