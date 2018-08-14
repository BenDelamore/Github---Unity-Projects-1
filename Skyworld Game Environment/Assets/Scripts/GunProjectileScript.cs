using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunProjectileScript : MonoBehaviour {

	public Transform barrel;
	public Rigidbody bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Check if left mouse button is clicked
		if (Input.GetMouseButtonDown (0)) {

			var newBullet = Instantiate (bullet, barrel.position, barrel.rotation);

		}
	}
}
