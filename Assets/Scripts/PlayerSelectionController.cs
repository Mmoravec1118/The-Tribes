using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Procedurally creates and returns the key strings that are used to look up the values
/// associated with different players that are stored in the PlayerPrefs.
/// </summary>
public class PlayerSelectionController : MonoBehaviour {

    int playersCount = 1;
    int currentPlayer = 1;

    string playerCountKeyString = "";
    string currentPlayerTribeKeyString = "";
    string currentPlayerStrengthKeyString = "";
    string currentPlayerAgilityKeyString = "";
    string currentPlayerTrustKeyString = "";
    string currentPlayerSurvivalKeyString = "";
    string currentPlayerNotorietyKeyString = "";
    
    // Use this for initialization
	void Start () 
    {
        // Makes the object persistent between scenes
        DontDestroyOnLoad(this);
        PlayerSwitch(1);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void PlayerSwitch(int currentPlayerNumber)
    {
        currentPlayer = currentPlayerNumber;

        currentPlayerTribeKeyString = "TribeType" + currentPlayer.ToString();
        currentPlayerStrengthKeyString = "StrengthStat" + currentPlayer.ToString();
        currentPlayerAgilityKeyString = "AgilityStat" + currentPlayer.ToString();
        currentPlayerTrustKeyString = "TrustStat" + currentPlayer.ToString();
        currentPlayerSurvivalKeyString = "SurvivalStat" + currentPlayer.ToString();
        currentPlayerNotorietyKeyString = "NotorietyStat" + currentPlayer.ToString();

        print("player switch initiated");
    }

    public string GetCurrentTribeTypeKey()
    {
        return currentPlayerTribeKeyString;
    }

    public string GetCurrentStrengthStatKey()
    {
        return currentPlayerStrengthKeyString;
    }

    public string GetCurrentAgilityStatKey()
    {
        return currentPlayerAgilityKeyString;
    }

    public string GetCurrentTrustStatKey()
    {
        return currentPlayerTrustKeyString;
    }

    public string GetCurrentSurvivalStatKey()
    {
        return currentPlayerSurvivalKeyString;
    }

    public string GetCurrentNotorietyStatKey()
    {
        return currentPlayerNotorietyKeyString;
    }

    public void SetPlayerCount(int numberOfPlayers)
    {
        playersCount = numberOfPlayers;
    }
}
