using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript12 : MonoBehaviour {


	bool _endButtonDown12;

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

		if (_endButtonDown12) 
		{
			gameController.EndSelected12 ();
		}

	}

	public void OnEndButtonDown12 (bool down)
	{
		_endButtonDown12 = down;
	}

}