using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	int score = 0;
	public static int highScore = 0;
	public Text txt;
	public Camera mainCam;

	public void AddScore ()
	{
		++score;
		if (score > highScore)
		{
			highScore = score;
		}
		txt.text = "Score:" + score + "\nHigh Score: " + highScore;
	//	txt.transform.position = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3(Screen.width, 0f, 0f)).x + Screen.width *8 / 16, Screen.height - 50f);
	}

	void Start ()
	{
		highScore = PlayerPrefs.GetInt ("highScore", 0);
		txt.transform.position = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3(Screen.width, 0f, 0f)).x + Screen.width / 2, Screen.height - 50f);
	}	


/*	void OnDestroy ()
	{
		PlayerPrefs.SetInt ("highScore", highScore);
	}
*/
}
