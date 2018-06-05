using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript7 : MonoBehaviour {


	bool _endButtonDown7;

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

		if (_endButtonDown7) 
		{
			gameController.EndSelected7 ();
		}

	}

	public void OnEndButtonDown7 (bool down)
	{
		_endButtonDown7 = down;
	}

}