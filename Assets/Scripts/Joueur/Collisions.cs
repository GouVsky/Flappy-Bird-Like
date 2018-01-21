using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collisions : MonoBehaviour
{
	public GameObject __game_over;


	void Start ()
	{
		
	}




	void Update ()
	{
		
	}



	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Tuyau")
		{
			__game_over.SetActive (true);
		}
	}
}
