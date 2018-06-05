using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when the button is pressed, the player is sent back to the original Main Menu screen

public class BackButton : MonoBehaviour
{
	bool _backButtonDown;

	public GameObject play;
	public GameObject custom;
	public GameObject tutorial;
	public GameObject help;
	public GameObject back;
	public GameObject text;
	public GameObject desert;
	public GameObject winter;
	public GameObject garden;

	// Update is called once per frame
	public void Cur ()
	{

		if (_backButtonDown) 
		{
			play.gameObject.SetActive (true);
			custom.gameObject.SetActive (true);
			tutorial.gameObject.SetActive (true);
			help.gameObject.SetActive (true);

			desert.gameObject.SetActive (false);
			winter.gameObject.SetActive (false);
			garden.gameObject.SetActive (false);
			text.gameObject.SetActive (false);
			back.gameObject.SetActive (false);
		}
	}

	public void OnBackButtonDown (bool down)
	{
		_backButtonDown = down;
		Cur ();
	}

}