using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {

	public float vel;
	void FixedUpdate ()
	{
		if (!BirdMovement.dead)
		//float vel = player.velocity.x  * 0.9f;
			transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
	}


}
