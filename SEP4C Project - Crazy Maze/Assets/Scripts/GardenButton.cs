using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when button is pressed,  load level 3

public class GardenButton : MonoBehaviour
{
	bool _gardenButtonDown;

	// Update is called once per frame
	void Update ()
	{

		if (_gardenButtonDown) 
		{
			SceneManager.LoadScene ("level3");
		}
	}

	public void OnGardenButtonDown (bool down)
	{
		_gardenButtonDown = down;
	}

}