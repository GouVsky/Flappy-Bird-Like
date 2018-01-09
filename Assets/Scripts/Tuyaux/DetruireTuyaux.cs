using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireTuyaux : MonoBehaviour
{
	void Start ()
	{
		
	}




	void Update ()
	{
		
	}




	// Détruit le tuyau lorsqu'il n'est plus dans le champ de la caméra.

	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
