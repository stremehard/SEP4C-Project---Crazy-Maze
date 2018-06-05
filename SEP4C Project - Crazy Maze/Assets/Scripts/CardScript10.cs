using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript10 : MonoBehaviour {


	bool _cardButtonDown10;

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

		if (_cardButtonDown10) 
		{
			gameController.CardSelected10 ();
		}

	}

	public void OnCardButtonDown10 (bool down)
	{
		_cardButtonDown10 = down;
	}

}