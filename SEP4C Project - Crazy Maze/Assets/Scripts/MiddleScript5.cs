using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiddleScript5 : MonoBehaviour
{

	public Text tutorial;

	void Start ()
	{

	}



	void OnTriggerEnter(Collider other) 
	{

		if (other.tag == "Player")
		{
			tutorial.text = "";
			Destroy(gameObject);
		}

	}
}
