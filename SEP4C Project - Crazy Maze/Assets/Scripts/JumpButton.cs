using UnityEngine;
using UnityEngine.EventSystems;

//JUMP button that makes the player object rise in the air for a very short period

public class JumpButton : MonoBehaviour {

	private bool shouldJump = false;
	Vector3 startPos;


	// Update is called once per frame
	void Update () {
		//Find the player
		var player = GameObject.FindGameObjectWithTag("Player");
		//No player? exit out.
		if (player == null)
			return;
;
		//Is the jump button currently being pressed?
		if (shouldJump)
		{
	
			//player.GetComponent<Rigidbody>().useGravity = false;
			player.transform.rotation = Quaternion.identity;
			//Translate it upwards with time.
			player.transform.Translate(new Vector3(0, Time.deltaTime * 5, 0));
			//Make sure the Rigidbody is kinematic, or gravity will pull us down again
			//if (player.GetComponent<Rigidbody>().isKinematic == false)
				//player.GetComponent<Rigidbody>().isKinematic = true;

		}
		//Not jumping anymore? reset the Rigidbody.
		//else
			
	}

	//When the button is being pressed down, this function is called.
	public void ButtonPressedDown(BaseEventData e)
	{
		//var player = GameObject.FindGameObjectWithTag("Player");
		//startPos = player.transform.position;
		shouldJump = true;
	}

	//When the button is released again, this function is called.
	public void ButtonPressedUp(BaseEventData e)
	{
		var player = GameObject.FindGameObjectWithTag("Player");
		//player.transform.position = startPos;
		//player.GetComponent<Rigidbody>().useGravity = true;
		player.transform.rotation = Quaternion.identity;
		shouldJump = false;

	    
	}
}
