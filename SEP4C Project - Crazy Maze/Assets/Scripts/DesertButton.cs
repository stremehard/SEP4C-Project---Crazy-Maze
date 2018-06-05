using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//when button is pressed,  load level 1

public class DesertButton : MonoBehaviour
{
	bool _desertButtonDown;

	// Update is called once per frame
	void Update ()
	{

		if (_desertButtonDown) 
		{
			SceneManager.LoadScene ("level1");
		}
	}

	public void OnDesertButtonDown (bool down)
	{
		_desertButtonDown = down;
	}

}