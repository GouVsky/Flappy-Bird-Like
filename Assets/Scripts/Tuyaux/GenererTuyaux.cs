using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenererTuyaux : MonoBehaviour
{
	public float __premier_spawn,
			     __temps_spawn;

	public GameObject __tube;

	public Vector3 __position_sol,
				   __position_air;

	private Vector3 __position;


	void Start ()
	{
		__position = Vector3.zero;
	}




	void Update ()
	{
		
	}




	public void Generer()
	{
		int position = Random.Range (0, 5) * 2;


		// Génération des tuyaux à l'endroit.

		__position = __position_sol;

		__position.y -= position;


		Instantiate (__tube, __position, transform.rotation);


		// Génération des tuyaux à l'envers.

		__position = __position_air;

		__position.y -= position;


		Quaternion rotation_tube = transform.rotation;

		rotation_tube.x += 180;

		Instantiate (__tube, __position, rotation_tube);
	}
}
