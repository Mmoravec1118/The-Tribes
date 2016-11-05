using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Temporary solution to having the values of player choices be shown at the end of the
/// player setup scene.
/// </summary>
public class PlayerSetupCanvasTextHandler : MonoBehaviour {

    public Text statDisplay;
    ButtonBehaviorScript buttonsScript;
    public PlayerSetupButtonScript playerSetupButtonScript;

    // The current player stats to show
    PlayerClass currPlayer;

    // Use this for initialization
    void Start()
    {
        buttonsScript = FindObjectOfType<ButtonBehaviorScript>();
        playerSetupButtonScript = FindObjectOfType<PlayerSetupButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        statDisplay.text = "";

        if (playerSetupButtonScript.GetCurrentPlayerClass() != null)
        {
            currPlayer = playerSetupButtonScript.GetCurrentPlayerClass();

            statDisplay.text += "Strength: " + currPlayer.Strength.ToString() + ";";
            statDisplay.text += "Agility: " + currPlayer.Agility.ToString() + ";";
            statDisplay.text += "Trust: " + currPlayer.Trust.ToString() + ";";
            statDisplay.text += "Survival : " + currPlayer.Survival.ToString() + ";";
            statDisplay.text += "Notoriety : " + currPlayer.Notoriety.ToString() + ";";
        }
	}
}
