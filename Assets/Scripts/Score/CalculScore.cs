using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculScore : MonoBehaviour
{
	public double __score;

	public Text __texte;


	void Start ()
	{
		__score = 0;
	}




	void Update ()
	{
		
	}




	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Tuyau")
		{
			// L'incrémentation du score est divisé par deux puisqu'il y a deux tuyaux.

			__score += 0.5;
		}

		__texte.text = __score.ToString ();
	}
}
