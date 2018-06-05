using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript9 : MonoBehaviour {


	bool _cardButtonDown9;

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

		if (_cardButtonDown9) 
		{
			gameController.CardSelected9 ();
		}

	}

	public void OnCardButtonDown9 (bool down)
	{
		_cardButtonDown9 = down;
	}

}