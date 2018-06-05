using UnityEngine;
using System.Collections;

//when the player enters the finish region, collider is triggered

public class FinishRegion : MonoBehaviour
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
			gameController.FinishRegion ();
			Destroy(gameObject);
		}

	}
}