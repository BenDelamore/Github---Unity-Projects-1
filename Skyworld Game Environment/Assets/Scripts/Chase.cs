using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

	public Rigidbody rigidbody;
	public Transform PlayerRef;
	public float ChaseRange = 10f;
	public float ChaseSpeed = 2f;

	// Use this for initialization
	void Start () {
		//rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		// If I'm in range of the player; 
		// Chase!
		Vector3 difference = PlayerRef.position - this.transform.position;
		float distance = difference.magnitude;

		if (distance < ChaseRange)
			Follow ();

		// Else, do nothing.
	}

	void Follow (){

		Vector3 direction = PlayerRef.position - this.transform.position;

		direction = direction.normalized;

		rigidbody.MovePosition ( this.transform.position + direction * ChaseSpeed * Time.deltaTime );

	}
}
