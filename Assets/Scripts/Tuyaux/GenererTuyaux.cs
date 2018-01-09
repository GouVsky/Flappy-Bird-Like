using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenererTuyaux : MonoBehaviour
{
	public int __premier_spawn,
			   __temps_spawn;

	public GameObject __tube,
					  __sortie;

	public Vector3 __position;


	// La longueur ne considère pas la sortie du tuyau.

	private int _longueur;

	private Vector3 __position_tube,
					__position_sortie;


	void Start ()
	{
		_longueur = 3;

		InvokeRepeating ("Generer", __premier_spawn, __temps_spawn);
	}
	
	void Update ()
	{
		
	}

	public void Generer()
	{
		__position_tube = __position;

		__position_sortie = __position;


		int taille_tuyau = Random.Range (1, _longueur + 1);


		if (taille_tuyau > 1)
		{
			for (int i = 0; i < taille_tuyau; i++)
			{
				Instantiate (__tube, __position_tube, transform.rotation);

				// Chaque tube se trouve au-dessus du précédent.

				__position_tube.y += __tube.GetComponent <Renderer> ().bounds.size.y;

				// La sortie du tuyau se trouve au-dessus des tubes.

				__position_sortie.y += __tube.GetComponent <Renderer> ().bounds.size.y;
			}
		}

		// Dans tous les cas, la sortie du tuyau est affichée.

		Instantiate (__sortie, __position_sortie, transform.rotation);
	}
}
