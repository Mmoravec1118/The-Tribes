using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayPlayerInfo : MonoBehaviour {

    // text box for displaying player info
    Text playerDisplay;

    //Token display variables
    int desert = 0;
    int forest = 0;
    int mountains = 0;
    int swamp = 0;
    int plains = 0;

    #region Area Locations
    int desertX;
    int desertY;
    int forestX;
    int forestY;
    int plainX;
    int plainY;
    int mountainX;
    int mountainY;
    int swampX;
    int swampY;
    #endregion

    // screen size
    int screenX;
    int screenY;

    // offset sizes
    float xOffset;
    float yOffset;

    //rect sizes
    int xSize = 0;
    int ySize = 0;


    // current player turn
    int currTurn = 0;

    // saved reference to globals script
    GlobalsScript globals;

	// Use this for initialization
	void Start () {

        playerDisplay = GetComponent<Text>();
        globals = FindObjectOfType<GlobalsScript>();

        //get screen size values
        screenX = Camera.main.pixelWidth;
        screenY = Camera.main.pixelWidth;

        // set initial area values
        desertX = screenX * (2 / 3);
        desertY = screenY * (1 / 8);
        forestX = screenX * (1 / 4);
        forestY = screenY * (2 / 3);
        plainX = screenX * (2 / 3);
        plainY = screenY * (2 / 3);
        mountainX = screenX * (1 / 4);
        mountainY = screenY * (1 / 8);
        swampX = screenX * (1 / 4);
        swampY = screenY * (1 / 3);

    }
	
	// Update is called once per frame
	void Update () {

        DisplayText();

    }

    #region Methods

    public void DisplayText()
    {
        PlayerClass currplayer = globals.GetPlayer();
        playerDisplay.text = "Tribe Name: " + currplayer.Name + "\n"
             + "Player Stats:" + "\n"
             + "  Strength:  " + currplayer.Strength + "\n"
             + "  Agility:   " + currplayer.Agility + "\n"
             + "  Trust:     " + currplayer.Trust + "\n"
             + "  Survival:  " + currplayer.Survival + "\n"
             + "  Notoriety: " + currplayer.Notoriety + "\n"
             + "Resources:" + "\n"
             + "  Wood:   " + currplayer.Wood + "\n"
             + "  Stone:  " + currplayer.Stone + "\n"
             + "  Food:   " + currplayer.Food + "\n"
             + "  People: " + currplayer.People + "\n"
             + "Victory Points:" + currplayer.VictoryPoints;
    }

    public void TokenCount()
    {
        foreach (PlayerClass player in globals.Players)
        {
            switch (player.Area)
            {
                case GlobalsScript.Areas.Desert:
                    desert++;
                    break;

                case GlobalsScript.Areas.Forest:
                    forest++;
                    break;

                case GlobalsScript.Areas.Mountain:
                    mountains++;
                    break;

                case GlobalsScript.Areas.Plain:
                    plains++;
                    break;

                case GlobalsScript.Areas.Swamp:
                    swamp++;
                    break;

                default:
                    break;
            }
        }
    }

    void DisplayTokens()
    {
        if (desert > 0)
        {
            for (int i = 0; i < desert; i++)
            {
                Rect spriteRect = new Rect(new Vector2(desertX, desertY), new Vector2(0,0));
                globals.GetPlayer().DisplayToken(i, spriteRect);
            }
        }
    }

    #endregion


    #region Properties

    /// <summary>
    /// returns current player turn or adds value to player turn
    /// </summary>
    public int CurrentTurn
    {
        get
        {
            return currTurn;
        }
        set
        {
            currTurn += value;

            // Loops current turn back to 0 if if exceeds the list capacity
            if (currTurn >= GlobalsScript.NumberofPlayers)
            {
                currTurn = 0;
            }

            // Updates the displayed text to current player info
            //DisplayText(currTurn);
        }
    }

    #endregion


}
