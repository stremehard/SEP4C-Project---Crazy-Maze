using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript4 : MonoBehaviour {


	bool _endButtonDown4;

	private GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		if (gameControllerObject != null)

		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}

		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void Update ()
	{

		if (_endButtonDown4) 
		{
			gameController.EndSelected4 ();
		}

	}

	public void OnEndButtonDown4 (bool down)
	{
		_endButtonDown4 = down;
	}

}