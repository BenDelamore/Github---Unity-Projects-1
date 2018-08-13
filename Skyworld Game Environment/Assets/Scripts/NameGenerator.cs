using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGenerator : MonoBehaviour {

	public string[] Title = new string[]{ "Dame","Lord","President","Doctor","Captain"};
	public string[] FirstName = new string[]{ "Ulric","Ariana","Clarice","Benjamin","Brom"};
	public string[] LastNameA = new string[]{ "Frothy","Weedy","Puny","Dung","Bladder"};
	public string[] LastNameB = new string[]{ "bag","rat","penny","heap","foot"};

	// Use this for initialization
	void Start () {
		
	}

	string MakeName(){
		string s1, s2, s3, s4;
		s1 = Title [Random.Range (0, Title.Length)];
		s2 = FirstName [Random.Range (0, FirstName.Length)];
		s3 = LastNameA [Random.Range (0, LastNameA.Length)];
		s4 = LastNameB [Random.Range (0, LastNameB.Length)];

		s1 = s1.Replace (" ", "");
		s1 = s1.Trim (); // Trim simply clears all whitespace.
		s2 = s2.Trim ();
		s3 = s3.Trim ();
		s4 = s4.Trim ();

		return s1 + " " + s2 + " " + s3 + s4;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.N)){
			
			string myName = MakeName ();
			print ("My name is " + myName);
			//print ("Key None of your business was pressed");
		}
		
	}
}
