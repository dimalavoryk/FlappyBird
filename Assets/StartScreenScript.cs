using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {


	bool sowOnce = false;

	// Use this for initialization
	void Start () 
	{
		if (!sowOnce) 
		{
			GetComponent<SpriteRenderer>().enabled = true;
			Time.timeScale = 0;
		}
			sowOnce = true;

	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (Time.timeScale == 0 && (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0))) 
		if (Time.timeScale == 0 && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Time.timeScale = 1;
			GetComponent<SpriteRenderer>().enabled = false;
			sowOnce = true;
		}
	}
}
