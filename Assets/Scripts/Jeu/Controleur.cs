using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controleur : MonoBehaviour
{
	public GameObject __flappy,
					  __tuyau;

	public GenererTuyaux __generation;


	void Start ()
	{
		__generation.InvokeRepeating ("Generer", __generation.__premier_spawn, __generation.__temps_spawn);
	}
	



	void Update () 
	{
		// A la mort du joueur, on arrête la génération des tuyaux et on arrête le défilement de ceux déjà créés.

		if (!__flappy.GetComponent <Collisions> ().FlappyVivant ())
		{
			__generation.CancelInvoke ();
		}
	}
}
