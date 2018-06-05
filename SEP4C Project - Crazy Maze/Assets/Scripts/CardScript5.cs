using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript5 : MonoBehaviour {


	bool _cardButtonDown5;

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

		if (_cardButtonDown5) 
		{
			gameController.CardSelected5 ();
		}

	}

	public void OnCardButtonDown5 (bool down)
	{
		_cardButtonDown5 = down;
	}

}