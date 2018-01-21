using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenererTuyaux : MonoBehaviour
{
	public float __premier_spawn,
			     __temps_spawn;

	public GameObject __tube,
					  __sortie;

	public Vector3 __position_sol,
				   __position_air;


	private int _nombre_tubes;

	private Vector3 __position_tube,
					__position_sortie;


	void Start ()
	{
		_nombre_tubes = 3;

		InvokeRepeating ("Generation", __premier_spawn, __temps_spawn);
	}




	void Update ()
	{
		
	}




	public void Generation()
	{
		int nombre_tubes = Random.Range (0, _nombre_tubes + 1);


		// Génération des tuyaux à l'endroit.

		Generer (__position_sol, nombre_tubes);

		// Génération des tuyaux à l'envers.

		Generer (__position_air, _nombre_tubes - nombre_tubes + 1, -1, 180);
	}




	private void Generer(Vector3 position, int nombre_tubes, int facteur_position = 1, int rotation = 0)
	{
		__position_tube = position;

		__position_sortie = position;


		if (nombre_tubes > 0)
		{
			for (int i = 0; i < nombre_tubes; i++)
			{
				Instantiate (__tube, __position_tube, transform.rotation);

				// Chaque tube se trouve à la suite du précédent.

				__position_tube.y += __tube.GetComponent <Renderer> ().bounds.size.y * (facteur_position);

				// La sortie du tuyau se trouve à la suite des tubes.

				__position_sortie.y += __tube.GetComponent <Renderer> ().bounds.size.y * (facteur_position);
			}
		}

		// Dans tous les cas, la sortie du tuyau est affichée.
		// On inverse son sens dans le cas d'un tuyau aérien.

		Quaternion rotation_sortie = transform.rotation;

		rotation_sortie.x += rotation;

		Instantiate (__sortie, __position_sortie, rotation_sortie);
	}
}
