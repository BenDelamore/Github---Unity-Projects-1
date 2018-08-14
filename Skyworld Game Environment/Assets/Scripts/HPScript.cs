using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPScript : MonoBehaviour {

	//public GameObject Particle;

	public int HPValue = 10;
	public int MaxHPValue = 10;

	public void Apply ( int value )
	{
		HPValue += value;

		if (HPValue <= 0)
			Die ();
		else if (HPValue > MaxHPValue)
			HPValue = MaxHPValue;

	}

	public void TakeDamage ( int dmg )
	{
		if (dmg < 0)
			dmg = dmg * -1;

		HPValue = HPValue - dmg;

		//Particle Effect -- instantiate a particle and orient it with this object
		//Instantiate (Particle, this.transform.position, this.transform.rotation);

		if (HPValue <= 0)
			Die ();
	}

	public void Heal (int value)
	{
		if (value < 0)
			value = value * -1;
		
		HPValue += value;

		if (HPValue > MaxHPValue)
			HPValue = MaxHPValue;



	}

	void Die ()
	{
		Destroy (this.gameObject);
	}
}
