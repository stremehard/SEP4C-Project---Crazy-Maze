using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//when the player enters the region, collider is triggered ( same for all 1 - 5 middle regions )

public class MiddleRegion : MonoBehaviour
{

	public Text tutorial;

	void Start ()
	{

	}



	void OnTriggerEnter(Collider other) 
	{

		if (other.tag == "Player")
		{
			tutorial.text = "Notice how the tree on the left points towards the right path, helping us take a good choice. Let's go there!";
			Destroy(gameObject);
		}

	}
}
