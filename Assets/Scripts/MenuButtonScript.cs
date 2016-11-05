using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript1 : MonoBehaviour {

    GlobalsScript globals;

	// Use this for initialization
	void Start () {

        // save reference to globals script
        globals = GlobalsScript.Instance;

	}

	//Harvest adds one Wood, Stone, or Food to the players assests
	//Needs choice input for which to add
	void Harvest (GlobalsScript.Resources choice) {
		switch (choice) {
			//Case 1 is Wood
			case GlobalsScript.Resources.Food:
                {
                    //+1 Wood
                    globals.GetPlayer().Food += 1;
                    break;
                }
				
			//Case 2 is Stone
			case GlobalsScript.Resources.Stone:
                {
                    //+1 Stone
                    globals.GetPlayer().Stone += 1;
                    break;
                }
               
			//Case 3 is Food
			case GlobalsScript.Resources.Wood:
                {
                    //+1 Food
                    globals.GetPlayer().Wood += 1;
                    break;
                }
  
			//In case error
			default:
                {
                    //Print "There was an error."
                    Debug.Log("Error");
                    break;
                }
		}
	}

	//-1 Wood & -1 Stone for a tool
	//Needs choice for tool
	//Input for choice for tool?
	void Craft (GlobalsScript.Traits trait) {
		// check if player can create a tool
        if (globals.GetPlayer().Wood > 0 &&
            globals.GetPlayer().Stone > 0 &&
            !globals.GetPlayer().HasTool)
        {
            // subtract resources from player
            globals.GetPlayer().Wood--;
            globals.GetPlayer().Stone--;

            // Add one point to player stat of choice
        }
        else
        {
            Debug.Log("Not enough Resources");
        }

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
	void Upgrade () {
		//Check for people
		if (globals.GetPlayer().People >= 10 &&
            globals.GetPlayer().Stone >= 10 &&
            globals.GetPlayer().Wood >= 10)
        {
            //+1 AP
            globals.GetPlayer().VictoryPoints += 1;
		} 
		else {
            //Cannot fulfill action
            Debug.Log("Too Few resources");

		}

	}

    //Recruit
    public void Recriut()
    {
        // check food storage
        if (globals.GetPlayer().Food >= 2)
        {
            globals.GetPlayer().People += 2;
        }
        else
        {
            Debug.Log("Not enough food");
        }
    }
}
