using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGenerator : MonoBehaviour {

	public string[] Title = new string[]{ "Sir", "Lord", "Lady", "Mr", "Captain"};
	public string[] FirstName = new string[]{ "Zephyr", "Zareth", "Zack", "Zeno", "Bob"};
	public string[] LastNameA = new string[]{ "el", "von", "mc", "da", "del"};
	public string[] LastNameB = new string[]{ "Nilheim ", "Jagger", "Thundra", "Kiendo", "Xanda"};



	// Use this for initialization
	void Start () {
		
	}

	string MakeName(){
		string s1, s2, s3, s4;
		s1 = Title [Random.Range (0, 5)];
		s2 = FirstName [Random.Range (0, FirstName.Length)];
		s3 = LastNameA [Random.Range (0, LastNameA.Length)];
		s4 = LastNameB [Random.Range (0, LastNameB.Length)];

		s1 = s1.Replace (" ", "");
		s2 = s2.Trim (); // Trim simply clears all whitespace.

		return s1 + " " + s2 + " " + s3 + s4;
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.N)) {
			string myName = MakeName ();
			print( "Your name is "+ myName);
			//print ( "Key N was pressed" );
		}

	}
}
