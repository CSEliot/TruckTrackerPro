using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.VisualBasic.FileIO;

public class ParseManager : MonoBehaviour {

    TextFieldParser parser;

	// Use this for initialization
	void Start () {
        parser = new TextFieldParser(@"c:\temp\test.csv");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
