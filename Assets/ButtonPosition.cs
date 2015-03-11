using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonPosition : MonoBehaviour {

	public Camera mainCam;
	public Button button;
	// Use this for initialization
	void Start () {
		button.transform.position = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3(Screen.width, 0f, 0f)).x + Screen.width -40, Screen.height - 20f);
			
	}
	
	// Update is called once per frame

}
