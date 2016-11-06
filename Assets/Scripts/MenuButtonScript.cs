using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuButtonScript : MonoBehaviour {

    GlobalsScript globals;
    public GameObject HarvestPanel;
    public GameObject CraftPanel;
    public GameObject RecruitPanel;
    public GameObject UpgradePanel;
    public GameObject RelocatePanel;
    public GameObject TradePanel;

    public GameObject HarvestButton;
    public GameObject CraftButton;
    public GameObject RecruitButton;
    public GameObject UpgradeButton;
    public GameObject RelocateButton;
    public GameObject TradeButton;

    public Deck deck;
    // Use this for initialization
    void Start () {
        // save reference to globals script
        globals = GlobalsScript.Instance;

	}
    public void activateHarvestPanel(bool TF)
    {
        HarvestPanel.SetActive( TF );
    }

    public void activateCraftPanel(bool TF)
    {
        CraftPanel.SetActive(TF);
    }

    public void activateRecruitPanel(bool TF)
    {
        RecruitPanel.SetActive(TF);
    }

    public void activatUpgradePanel(bool TF)
    {
        UpgradePanel.SetActive(TF);
    }

    public void activateRelocatePanel(bool TF)
    {
        RelocatePanel.SetActive(TF);
    }

    public void activateTradePanel(bool TF)
    {
        TradePanel.SetActive(TF);
    }
    //Harvest adds one Wood, Stone, or Food to the players assests
    //Needs choice input for which to add
    public void Harvest (GlobalsScript.Resources choice) {
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

    public void HarvestFood()
    {
        globals.GetPlayer().Food += 1;
    }

    public void HarvestStone()
    {
        globals.GetPlayer().Stone += 1;
    }

    public void HarvestWood()
    {
        globals.GetPlayer().Wood += 1;
    }

	//-1 Wood & -1 Stone for a tool
	//Needs choice for tool
	//Input for choice for tool?
	public void Craft (GlobalsScript.Traits trait) {
		// check if player can create a tool
        if (globals.GetPlayer().Wood > 0 &&
            globals.GetPlayer().Stone > 0 )
        {
            // subtract resources from player
            globals.GetPlayer().Wood -= 1;
            globals.GetPlayer().Stone -= 1;

            // Add one point to player stat of choice
        }
        else
        {
            Debug.Log("Not enough Resources");
        }

	}

    public void craftStr()
    {
        globals.GetPlayer().Wood -= 1;
        globals.GetPlayer().Stone -= 1;
        globals.GetPlayer().Strength += 1;
    }

    public void craftAgi()
    {
        globals.GetPlayer().Wood -= 1;
        globals.GetPlayer().Stone -= 1;
        globals.GetPlayer().Agility += 1;
    }

    public void craftNot()
    {
        globals.GetPlayer().Wood -= 1;
        globals.GetPlayer().Stone -= 1;
        globals.GetPlayer().Notoriety += 1;
    }

    public void craftSR()
    {
        globals.GetPlayer().Wood -= 1;
        globals.GetPlayer().Stone -= 1;
        globals.GetPlayer().Survival += 1;
    }

    public void craftTrst()
    {
        globals.GetPlayer().Wood -= 1;
        globals.GetPlayer().Stone -= 1;
        globals.GetPlayer().Trust += 1;
    }
    //Relocate
    //Takes in choice of location and then moves there
    //Locations are given by cards? Or by class?
    public void Relocate () {
        //Move player to location
        int r = Random.Range(0, 4);

        switch (r)
        {
            case 0:
                globals.GetPlayer().Area = GlobalsScript.Areas.Desert;
                break;

            case 1:
                globals.GetPlayer().Area = GlobalsScript.Areas.Mountain;
                break;

            case 2:
                globals.GetPlayer().Area = GlobalsScript.Areas.Plain;
                break;

            case 3:
                globals.GetPlayer().Area = GlobalsScript.Areas.Swamp;
                break;
            default:
                break;
        }
    }

	//Upgrade village
	//Removes 10 stone, 10 wood, and requires 10 people for +1 AP
	//Resources doubled? Set a status to doubled?
	public void Upgrade () {
		//Check for people
		if (globals.GetPlayer().People >= 10 &&
            globals.GetPlayer().Stone >= 10 &&
            globals.GetPlayer().Wood >= 10)
        {

            globals.GetPlayer().People -= 10;
            globals.GetPlayer().Stone -= 10;
            globals.GetPlayer().Wood -= 10;

            //+1 AP
            globals.GetPlayer().VictoryPoints += 1;
		} 
		else {
            //Cannot fulfill action
            Debug.Log("Too Few resources");

		}

	}

    //Recruit
    public void Recruit()
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
    public void enterDrawCardPhase()
    {
        CraftButton.SetActive(false);
        HarvestButton.SetActive(false);
        RecruitButton.SetActive(false);
        TradeButton.SetActive(false);
        RelocateButton.SetActive(false);
        UpgradeButton.SetActive(false);

        CraftPanel.SetActive(false);
        HarvestPanel.SetActive(false);
        RecruitPanel.SetActive(false);
        TradePanel.SetActive(false);
        RelocatePanel.SetActive(false);
        UpgradePanel.SetActive(false);

        deck.DrawCard();
    }
    void NextTurn()
    {
        globals.PlayerTurn += 1;
    }
}
