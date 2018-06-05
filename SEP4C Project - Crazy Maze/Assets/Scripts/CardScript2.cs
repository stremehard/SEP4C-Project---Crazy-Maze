using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript2 : MonoBehaviour {


	bool _cardButtonDown2;

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

		if (_cardButtonDown2) 
		{
			gameController.CardSelected2 ();
		}

	}

	public void OnCardButtonDown2 (bool down)
	{
		_cardButtonDown2 = down;
	}

}