using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed = 1000f;
	private Rigidbody rigidbody;
	public float destroyTime;
	public float Lifetime = 10f;
	public float Damage = 1f;
	public GameObject particle;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce (transform.forward * speed);

		// Delete object after X seconds.
		Invoke("Explode", Lifetime);
	}

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("Bullet has touched a " + collision.gameObject.name);

		// Explode after X seconds.
		Invoke("Explode", destroyTime);
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Grenage has touuched a " + other.gameObject.name);

		// Get the object that we touched and get its HPScript component.
		var hp = other.gameObject.GetComponent<HPScript> ();

		// If it successfully got an HPScript component...
		if (hp != null) {

			// Then apply damage.
			hp.Apply (-1);

			// and 'explode' the bullet
			Explode();
		}
	}

	void Explode ()
	{
		// Instantiate a particle.
		Instantiate(particle, this.transform.position, Quaternion.identity);

		// Destroy the object.
		Destroy(this.gameObject);
	}
}
