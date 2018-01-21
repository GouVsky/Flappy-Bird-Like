using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collisions : MonoBehaviour
{
	public GameObject __game_over;

	private bool __vivant;


	void Start ()
	{
		__vivant = true;
	}




	void Update ()
	{
		
	}



	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Tuyau" || collision.gameObject.tag == "Sol")
		{
			__vivant = false;

			__game_over.SetActive (true);
		}
	}



	public bool FlappyVivant()
	{
		return __vivant;
	}
}
