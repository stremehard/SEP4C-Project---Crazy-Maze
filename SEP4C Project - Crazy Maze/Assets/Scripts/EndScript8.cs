using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript8 : MonoBehaviour {


	bool _endButtonDown8;

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

		if (_endButtonDown8) 
		{
			gameController.EndSelected8 ();
		}

	}

	public void OnEndButtonDown8 (bool down)
	{
		_endButtonDown8 = down;
	}

}