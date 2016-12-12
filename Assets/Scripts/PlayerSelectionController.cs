using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Procedurally creates and returns the key strings that are used to look up the values
/// associated with different players that are stored in the PlayerPrefs.
/// </summary>
public class PlayerSelectionController : MonoBehaviour {

    int currentPlayer = 1;

    string currentPlayerTribeKeyString = "";
    string currentPlayerStrengthKeyString = "";
    string currentPlayerAgilityKeyString = "";
    string currentPlayerTrustKeyString = "";
    string currentPlayerSurvivalKeyString = "";
    string currentPlayerNotorietyKeyString = "";
    
    // Use this for initialization
    void Awake()
    {
        if (FindObjectsOfType<PlayerSelectionController>().Length > 1)
        {
            DestroyImmediate(this);
        }
    }

	void Start () 
    {
        // Makes the object persistent between scenes
        DontDestroyOnLoad(this);
        PlayerSwitch(1);
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

        print("Player " + currentPlayer.ToString() + "'s turn");
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

    public int GetCurrentPlayerNumber()
    {
        return currentPlayer;
    }

    //public int GetTempPlayerCount()
    //{
    //    return tempPlayerCount;
    //}

    //public void SetTempPlayerCount(int newTempPlayerCount)
    //{
    //    tempPlayerCount = newTempPlayerCount;
    //}
}
