using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Temporary solution to having the values of player choices be shown at the end of the
/// player setup scene.
/// </summary>
public class PlayerSetupCanvasTextHandler : MonoBehaviour {

    public Text statDisplay;
    public PlayerSelectionController playerSelectionController;
    ButtonBehaviorScript buttonsScript;

    // Use this for initialization
    void Start()
    {
        playerSelectionController = FindObjectOfType<PlayerSelectionController>();
        buttonsScript = FindObjectOfType<ButtonBehaviorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        statDisplay.text = "";

        //statDisplay.text += "Tribe: " + buttonsScript.currPlayer.name;
        //statDisplay.text += "Strength: " + buttonsScript.currPlayer.Strength;

        if (PlayerPrefs.HasKey(playerSelectionController.GetCurrentTribeTypeKey()))
        {
            statDisplay.text += "Tribe: " + PlayerPrefs.GetString(playerSelectionController.GetCurrentTribeTypeKey()) + ";";
        }
        if (PlayerPrefs.HasKey(playerSelectionController.GetCurrentStrengthStatKey()))
        {
            statDisplay.text += "Strength: " + PlayerPrefs.GetInt(playerSelectionController.GetCurrentStrengthStatKey()).ToString() + ";";
        }
        if (PlayerPrefs.HasKey(playerSelectionController.GetCurrentAgilityStatKey()))
        {
            statDisplay.text += "Agility: " + PlayerPrefs.GetInt(playerSelectionController.GetCurrentAgilityStatKey()).ToString() + ";";
        }
        if (PlayerPrefs.HasKey(playerSelectionController.GetCurrentTrustStatKey()))
        {
            statDisplay.text += "Trust: " + PlayerPrefs.GetInt(playerSelectionController.GetCurrentTrustStatKey()).ToString() + ";";
        }
        if (PlayerPrefs.HasKey(playerSelectionController.GetCurrentSurvivalStatKey()))
        {
            statDisplay.text += "Survival: " + PlayerPrefs.GetInt(playerSelectionController.GetCurrentSurvivalStatKey()).ToString() + ";";
        }
        if (PlayerPrefs.HasKey(playerSelectionController.GetCurrentNotorietyStatKey()))
        {
            statDisplay.text += "Notoriety: " + PlayerPrefs.GetInt(playerSelectionController.GetCurrentNotorietyStatKey()).ToString() + ";";
        }
	}
}
