using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript1 : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}

	//Harvest adds one Wood, Stone, or Food to the players assests
	//Needs choice input for which to add
	void Harvest (GlobalsScript.Resources choice) {
		switch (choice) {
			//Case 1 is Wood
			case GlobalsScript.Resources.Food: 
				//+1 Wood

				break;
			//Case 2 is Stone
			case GlobalsScript.Resources.Stone:
				//+1 Stone

				break;
			//Case 3 is Food
			case GlobalsScript.Resources.Wood:
				//+1 Food

				break;
			//In case error
			default:
				//Print "There was an error."

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
}
