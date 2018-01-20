using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculScore : MonoBehaviour
{
	public int score;


	void Start ()
	{
		score = 0;
	}




	void Update ()
	{
		
	}




	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Tuyau")
		{
			score++;
		}
	}
}
