using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	const int START_MAX = 1000;
	const int START_MIN = 1;
	const int START_GUESS = 500;

	void Start () {
		StartGame();
	}

	void StartGame() {
		max = START_MAX;
		min = START_MIN;
		guess = START_GUESS;
		print ("====================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess +"?");
		print ("Up arrow for higher, down for lower, return for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if(Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
			print ("Higher or lower than " + guess + "?");
		} else if(Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}

	void NextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");
	}

}
