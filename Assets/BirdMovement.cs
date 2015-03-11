using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

	float screenWidth = Screen.width;
	float screenHeight = Screen.height;
	bool isPause = false;
	float flapSpeed	= 5f;
	bool didFlap = false;
	public static bool dead	 = false;
	float deathColdown;
	// Use this for initialization
	void Start () {
		GameObject.Find ("Death").GetComponent<SpriteRenderer> ().enabled = false;		
	}

	void Update()
	{
		if (dead) 
		{
			GameObject.Find ("Bird").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("Death").GetComponent<SpriteRenderer>().enabled = true;
			PlayerPrefs.SetInt ("highScore", Score.highScore);
			deathColdown -= Time.deltaTime;
			if (deathColdown < 0)
			{
				
			//	if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) 
				if (Input.GetTouch(0).phase == TouchPhase.Began)
				{
					Application.LoadLevel(Application.loadedLevel);
					didFlap = true;		
					dead = false;
					isPause = false;
				}
			}
		} 
		else 
		{
			
			//if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0))
			if (Input.GetTouch(0).phase == TouchPhase.Began)
			{				
				didFlap = true;		
				isPause = false;
			}
		}
	}
	void FixedUpdate () 
	{
		//if (dead)				return;		
		if (Input.GetKeyDown (KeyCode.Escape))				 
		{
			Application.Quit(); 
		}
		if (didFlap)
		{
			rigidbody2D.velocity = new Vector2 (0, flapSpeed);
			didFlap = false;
		}
		if (rigidbody2D.velocity.y > 0) 
		{
			transform.rotation = Quaternion.Euler (0, 0, 30);
		}
		else
		{
			float angle = Mathf.Lerp (30, -60, (-rigidbody2D.velocity.y / 4f));
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
	}


	void OnCollisionEnter2D (Collision2D collision)
	{
		dead = true;
		deathColdown = 1f;
	}


	void OnGUI () {
		//if (GUI.Button (new Rect (Screen.width - 70f, 50f, 50f, 30f), "Pause"))
		if (GUI.Button (new Rect (screenWidth - screenWidth / 5, screenHeight / 20,screenWidth/ 5, screenHeight / 10), "Pause"))
		{
			if (!isPause)
			{
				Time.timeScale = 0;
				rigidbody2D.velocity = new Vector2 (0, 0);
				isPause = true;
			}
			else
			{
				Time.timeScale = 1;
				isPause = false;
			}
		}
	}

}
