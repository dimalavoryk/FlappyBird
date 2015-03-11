using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour 
{

	private GameObject m_score;

	void Start()
	{
		m_score = GameObject.Find ("txtScore");
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			m_score.SendMessage("AddScore");
			//gameObject.SetActive(false);
		}

	}

}
