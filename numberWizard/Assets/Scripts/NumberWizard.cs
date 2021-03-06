﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;

	void Start () {
		Startgame ();
	}
	// Use this for initialization
	void Startgame () {
		max = 1000;
		min = 1;
		guess = 500;

		print ("==============================================================");
		print ("=============================================================");
		print ("============================================================");
		print ("===========================================================");
        print ("Welcome to Number Wizard");


        print ("Pick a Number in your head but don't tell me!");

        

        print ("The highest number you can pick is " + max);
        print ("The lowest number you can pick is " + min);

        print ("Is the number higher or lower than " + guess + " ?");
        print ("Up arrow = higher, down = lower, return = equal");

	}

	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + " ?");
		print ("Up arrow = higher, down = lower, return = equal");
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			min = guess;

			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down arrow pressed");
			max = guess;

			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			Start ();
		}
	}
}