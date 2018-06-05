using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript3 : MonoBehaviour {


	bool _endButtonDown3;

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

		if (_endButtonDown3) 
		{
			gameController.EndSelected3 ();
		}

	}

	public void OnEndButtonDown3 (bool down)
	{
		_endButtonDown3 = down;
	}

}