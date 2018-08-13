using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {


	public Transform barrel;
	public LayerMask rayLayers;
	public float maxRayDistance = 30f;

	public int DamageValue = 1;
	public float ForceValue = 1000f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Define our hit object. This contains data on what our raycast touches.
		RaycastHit hit;
		// Define the ray, or the direction we will shoot in.
		var ray = new Ray (barrel.transform.position, barrel.transform.forward);

		// Draw our ray.
		if (Physics.Raycast (ray, out hit, maxRayDistance, rayLayers)) {
			// We've hit something!
			// Do something.

			var d = hit.distance; // How far our ray is.
			var go = hit.transform.gameObject; // The object we are touching.
			var p = hit.point; // The point in global space.
			var n = hit.normal; // The direction of the normal (the surface facing outwards).

			Debug.Log ("I am looking at: " + go.name);

		} else {
			// We have not hit anything :(

			//Debug.Log ("I am looking at nothing :(");
		}


		// SHOOT.
		// By clicking the mouse button.
		if (Input.GetMouseButtonDown (0)) {

			// What do we do?

			ShootEffect (hit);

			ApplyDamage (hit, DamageValue);
		}


	}




	void ShootEffect (RaycastHit hit)
	{
		
	}



	void ApplyDamage (RaycastHit hit, int dmg)
	{
		if (hit.collider == null)
			return;

		// Do damage to this object.
		// ...

		// For now, let's just make it disappear.
		var go = hit.transform.gameObject; // The object we are touching.

		var dmgObj = go.GetComponent<HPScript> ();

		// See if the object we're shooting has an HPScript on it.
		if (dmgObj != null) {
			// Take dmg!
			dmgObj.TakeDamage(dmg);
		}

		if (hit.rigidbody != null)
			hit.rigidbody.AddForce (barrel.transform.forward * ForceValue);


		// Play a hit effect.
		HitEffect(hit.point, hit.normal);
	}  


	void HitEffect (Vector3 pos, Vector3 normal)
	{
		// Particle
		// Sound
		// Etc.
	}



}
