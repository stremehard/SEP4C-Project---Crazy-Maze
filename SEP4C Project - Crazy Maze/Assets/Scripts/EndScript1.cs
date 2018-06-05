﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when number 1 is selected ( same from 1 to 12 )

public class EndScript1 : MonoBehaviour {


	bool _endButtonDown1;

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

		if (_endButtonDown1) 
		{
			gameController.EndSelected1 ();
		}

	}

	public void OnEndButtonDown1 (bool down)
	{
		_endButtonDown1 = down;
	}

}