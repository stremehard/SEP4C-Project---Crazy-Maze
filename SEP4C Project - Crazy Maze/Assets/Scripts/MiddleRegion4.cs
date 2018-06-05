using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiddleRegion4 : MonoBehaviour
{

	public Text tutorial;

	void Start ()
	{

	}



	void OnTriggerEnter(Collider other) 
	{

		if (other.tag == "Player")
		{
			tutorial.text = "Remember the item you picked and its number! Return to the starting zone by spotting the banana you placed and the tree that pointed towards this direction!";
			Destroy(gameObject);
		}

	}
}
