using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyScript : MonoBehaviour {

	public int MyNumber = 5;
	public int AnotherNumber;
	private int myPrivateNumber = 10;

	public float MyFloaty;
	public float MySecondFloaty = 3.141592654f;

	public string MyStringyObject;
	public string MySecondString = "Adam";

	public bool TrueOrFalse;
	public bool ThisIsTrueByDefault = true;
	public bool ThisIsFalseByDefault = false;


	private int AddFive ( int value )
	{
		return value + 5;
	}

	private void MyPrivateFunction ()
	{
		Debug.Log ("Special guests only!");

		int num = AddFive ( myPrivateNumber );

		string randomName = "Jennifer";

		MyStringyObject = "Jennifer";

		MyStringyObject = randomName;


	}

	public void MyPublicFunction ()
	{
		Debug.Log ("Everybody is invited!");
	}

	void QuickMath ()
	{
		MyNumber = 10;

		MyNumber = MyNumber + 1;
		MyNumber += 1;
		MyNumber++;

		MyNumber = MyNumber + 5;
		MyNumber += 5;

		MyFloaty = 10f / 2.5f;


		MyStringyObject = MyStringyObject + " Thompson";
		MyStringyObject += " Thompson";
		MyStringyObject = MyStringyObject.Replace ("Thompson", "Fredrikson");
	}


	// Use this for initialization
	void Start () {
		QuickMath ();
		MyPrivateFunction ();
	}
	

}
