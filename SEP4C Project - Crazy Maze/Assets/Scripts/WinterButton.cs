using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when button is pressed,  load level 2

public class WinterButton : MonoBehaviour
{
	bool _winterButtonDown;

	// Update is called once per frame
	void Update ()
	{

		if (_winterButtonDown) 
		{
			SceneManager.LoadScene ("level2");
		}
	}

	public void OnWinterButtonDown (bool down)
	{
		_winterButtonDown = down;
	}

}