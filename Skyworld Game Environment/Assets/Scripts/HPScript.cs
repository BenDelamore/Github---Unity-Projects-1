using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPScript : MonoBehaviour {

	public int HPValue = 10;
	public int HPMaxValue = 10;

	public void Apply ( int value )
	{
		// Hi :)
		//		if (dmg < 0)
		//			dmg = dmg * -1;

		HPValue += value;

		if (HPValue <= 0)
			Die ();
		else if (HPValue > HPMaxValue)
			HPValue = HPMaxValue;
	}

	public void TakeDamage ( int dmg )
	{
		// Hi :)
//		if (dmg < 0)
//			dmg = dmg * -1;

		HPValue = HPValue - dmg;

		if (HPValue <= 0)
			Die ();
	}

	public void Heal (int value)
	{
		
		if (value < 0)
			value = value * -1;
		
		HPValue = HPValue + value;

		if (HPValue > HPMaxValue)
			HPValue = HPMaxValue;
	}

	private void Die ()
	{
		Destroy (this.gameObject);
	}
}
