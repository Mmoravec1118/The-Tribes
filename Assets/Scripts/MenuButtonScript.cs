﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	//Harvest adds one Wood, Stone, or Food to the players assests
	//Needs choice input for which to add
	void Harvest (int choice) {
		switch (choice) {
			//Case 1 is Wood
			case 1: 
				//+1 Wood

				break;
			//Case 2 is Stone
			case 2:
				//+1 Stone

				break;
			//Case 3 is Food
			case 3:
				//+1 Food

				break;
			//In case error
			default:
				//Print "There was an error."
//<<<<<<< HEAD
//				
//=======
//>>>>>>> origin/master
				break;
		}
	}

	//-1 Wood & -1 Stone for a tool
	//Needs choice for tool
	//Input for choice for tool?
	void Craft () {
		//-1 Wood

		//-1 Stone

		//Gives tool (of choice)

	}

	//Relocate
	//Takes in choice of location and then moves there
	//Locations are given by cards? Or by class?
	void Relocate (int location) {
		//Move player to location

	}

	//Upgrade village
	//Removes 10 stone, 10 wood, and requires 10 people for +1 AP
	//Resources doubled? Set a status to doubled?
	void Upgrade (int people) {
		//Check for people
		if (people >= 10) {
			//-10 stone

			//-10 wood

			//+1 AP

			//Double resources

		} 
		else {
			//Cannot fulfill action

		}

	}

	//Recruit
	
	// Update is called once per frame
	void Update () {
	
	}
}