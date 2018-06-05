using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript11 : MonoBehaviour {


	bool _cardButtonDown11;

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

		if (_cardButtonDown11) 
		{
			gameController.CardSelected11 ();
		}

	}

	public void OnCardButtonDown11 (bool down)
	{
		_cardButtonDown11 = down;
	}

}