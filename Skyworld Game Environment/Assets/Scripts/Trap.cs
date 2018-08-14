using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

	public int Value = 1;
	public GameObject Mesh;

	void OnTriggerEnter ( Collider other )
	{
		// Add Feedback
		// Sound, particle, etc.

		// If what this pickup is touched by is NOT the player, then exit out and do nothing.
		if (other.tag != "Player")
			return;

		HPScript hp = other.GetComponent<HPScript>();

		hp.TakeDamage (Value);

		gameObject.SetActive (false);
		Mesh.SetActive (false);
	}
}
