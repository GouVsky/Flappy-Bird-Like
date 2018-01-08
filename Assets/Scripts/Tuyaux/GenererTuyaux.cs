using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenererTuyaux : MonoBehaviour
{
	public int __spawn;

	public GameObject __tube_tuyau,
					  __sortie_tuyau;

	public Vector3 __position_tuyau;

	private Vector3 __position_sortie_tuyau;


	void Start ()
	{
		InvokeRepeating ("Generer", __spawn, __spawn);
	}
	
	void Update ()
	{
		
	}

	public void Generer()
	{
		__position_sortie_tuyau = __position_tuyau;


		int taille_tuyau = Random.Range (1, 3);


		if (taille_tuyau > 1)
		{
			Instantiate (__tube_tuyau, __position_tuyau, transform.rotation);

			// La sortie du tuyau se trouve au-dessus du tube.

			__position_sortie_tuyau.y += __tube_tuyau.GetComponent <Renderer> ().bounds.size.y;
		}

		// Dans tous les cas, la sortie du tuyau est affichée.

		Instantiate (__sortie_tuyau, __position_sortie_tuyau, transform.rotation);
	}
}
