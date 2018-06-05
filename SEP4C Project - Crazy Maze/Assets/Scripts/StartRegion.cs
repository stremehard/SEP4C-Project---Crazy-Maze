using UnityEngine;
using System.Collections;

//When the players enters the start region, collider triggers

public class StartRegion : MonoBehaviour
{

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



	void OnTriggerEnter(Collider other) 
	{

		if (other.tag == "Player")
		{
			gameController.StartRegion ();
			Destroy(gameObject);
		}

	}
}
