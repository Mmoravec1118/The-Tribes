using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSetupButtonScript : MonoBehaviour {

    public string sceneName;

    // The number of players in the game
    int players;

    // The input field for the player's tribe name
    public InputField tribeNameInputField;

    // The text field that shows which player's turn it is
    public Text playerNumberText;

    // The text field that tells player if certain criteria are unmet
    public Text warningText;

    // The player's decided tribe type
    public GlobalsScript.TribeType tribeType;

    // currplayer for changing tribe stats before adding to globalsScript
    PlayerClass currPlayer;

    // Tribe Type Buttons
    public Button okbutton;
    public Button tribe0Button;
    public Button tribe1Button;
    public Button tribe2Button;
    public Button tribe3Button;

    // Tribe Type Text
    public Text tribe0FlavorText;
    public Text tribe1FlavorText;
    public Text tribe2FlavorText;
    public Text tribe3FlavorText;

    public Image finalDecisionPanel;

    // Sliders for stats
    public Slider strengthSlider;
    public Slider agilitySlider;
    public Slider trustSlider;
    public Slider survivalSlider;
    public Slider notorietySlider;

    // Stat Values
    public string tribeName;
    public int strengthStat;
    public int agilityStat;
    public int trustStat;
    public int survivalStat;
    public int notorietyStat;

    public void Start()
    {
        players = GlobalsScript.NumberofPlayers;

        print("Number of Players: " + players.ToString());

        playerNumberText.text = "Player " + (FindObjectOfType<GlobalsScript>().CurrentPlayerCount + 1).ToString() + "'s turn";

        currPlayer = new PlayerClass();

        ResetStats();
    }

    public void ChangeScene()
    {
        // Adds player class to GlobalsScript
        FindObjectOfType<GlobalsScript>().AddPlayer(currPlayer);
        
        // Loops the player setup scene for the number of players selected
        if (SceneManager.GetActiveScene().name == "PlayerSetup")
        {
            if (FindObjectOfType<GlobalsScript>().CurrentPlayerCount < players)
            {
                sceneName = "PlayerSetup";

                ResetStats();
            }
            else
            {
                sceneName = "Gameplay";
            }
        }

        SceneManager.LoadScene(sceneName);
    }

    public void ActivateOK()
    {
        if (okbutton.gameObject.activeInHierarchy == false || okbutton.gameObject.activeInHierarchy == true)
        {
            if (tribeType != null 
                && (strengthStat + agilityStat + trustStat + survivalStat + notorietyStat) <= GlobalsScript.statMax)
            {
                warningText.gameObject.SetActive(false);
                okbutton.gameObject.SetActive(true);
            }
            else if (tribeType == null)
            {
                okbutton.gameObject.SetActive(false);
                warningText.text = "Please select a tribe";
                warningText.gameObject.SetActive(true);
            }
            else
            {
                okbutton.gameObject.SetActive(false);
                warningText.text = "Your stat total may not exceed " + GlobalsScript.statMax.ToString();
                warningText.gameObject.SetActive(true);
            }
        }
    }

    public void Tribe0Flavor()
    {
        tribeType = GlobalsScript.TribeType.Barbarian;
        currPlayer.TribeType = tribeType;

        // This is where the selected value of the tribe is stored between scenes
        //PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(true);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe1Flavor()
    {
        tribeType = GlobalsScript.TribeType.PeaceMaker;
        currPlayer.TribeType = tribeType;

        // This is where the selected value of the tribe is stored between scenes
        //PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(true);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe2Flavor()
    {
        tribeType = GlobalsScript.TribeType.Nomad;
        currPlayer.TribeType = tribeType;

        // This is where the selected value of the tribe is stored between scenes
        //PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(true);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe3Flavor()
    {
        tribeType = GlobalsScript.TribeType.Farmer;
        currPlayer.TribeType = tribeType;

        // This is where the selected value of the tribe is stored between scenes
        //PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(true);

        ActivateOK();
    }

    public void StrengthUpdate()
    {
        strengthStat = (int)strengthSlider.value;

        // This is where the Strength stat is stored between scenes
        currPlayer.Strength = strengthStat;

        ActivateOK();
    }

    public void AgilityUpdate()
    {
        agilityStat = (int)agilitySlider.value;

        // This is where the Agility stat is stored between scenes
        currPlayer.Agility = agilityStat;

        ActivateOK();
    }

    public void TrustUpdate()
    {
        trustStat = (int)trustSlider.value;

        // This is where the Trust stat is stored between scenes
        currPlayer.Trust = trustStat;

        ActivateOK();
    }

    public void SurvivalUpdate()
    {
        survivalStat = (int)survivalSlider.value;

        // This is where the Survival stat is stored between scenes
        currPlayer.Survival = survivalStat;

        ActivateOK();
    }

    public void NotorietyUpdate()
    {
        notorietyStat = (int)notorietySlider.value;

        // This is where the Notoriety stat is stored between scenes
        currPlayer.Notoriety = notorietyStat;

        ActivateOK();
    }
    public void NameUpdate()
    {
        if (tribeNameInputField.text == "")
        {
            tribeName = "Player " + (FindObjectOfType<GlobalsScript>().CurrentPlayerCount + 1).ToString();
        }
        else
        {
            tribeName = tribeNameInputField.text;
        }
        currPlayer.Name = tribeName;
    }

    public void OnOKClick()
    {
        tribe0Button.gameObject.SetActive(false);
        tribe1Button.gameObject.SetActive(false);
        tribe2Button.gameObject.SetActive(false);
        tribe3Button.gameObject.SetActive(false);

        strengthSlider.gameObject.SetActive(false);
        agilitySlider.gameObject.SetActive(false);
        trustSlider.gameObject.SetActive(false);
        survivalSlider.gameObject.SetActive(false);
        notorietySlider.gameObject.SetActive(false);

        tribeNameInputField.gameObject.SetActive(false);

        okbutton.gameObject.SetActive(false);

        finalDecisionPanel.gameObject.SetActive(true);
    }

    public void OnNoClick()
    {
        tribe0Button.gameObject.SetActive(true);
        tribe1Button.gameObject.SetActive(true);
        tribe2Button.gameObject.SetActive(true);
        tribe3Button.gameObject.SetActive(true);

        strengthSlider.gameObject.SetActive(true);
        agilitySlider.gameObject.SetActive(true);
        trustSlider.gameObject.SetActive(true);
        survivalSlider.gameObject.SetActive(true);
        notorietySlider.gameObject.SetActive(true);

        tribeNameInputField.gameObject.SetActive(true);

        okbutton.gameObject.SetActive(true);

        finalDecisionPanel.gameObject.SetActive(false);
    }

    public void UpdatePlayerNumber(int newPlayerNumber)
    {
        playerNumberText.text = "Player " + newPlayerNumber.ToString() + "s turn";
        print("Current player number: " + newPlayerNumber.ToString());
    }

    public PlayerClass GetCurrentPlayerClass()
    {
        return currPlayer;
    }

    private void ResetStats()
    {
        tribeName = "Player " + (FindObjectOfType<GlobalsScript>().CurrentPlayerCount + 1).ToString();
        tribeType = GlobalsScript.TribeType.Barbarian;
        strengthStat = 0;
        agilityStat = 0;
        trustStat = 0;
        survivalStat = 0;
        notorietyStat = 0;

        // Resets the current player class to its default state
        currPlayer.ResetPlayerValues();

        // Defaults current player's name to Player (number)
        currPlayer.Name = tribeName;
    }
    public void CreateTribe()
    {
        currPlayer = new PlayerClass();
    }

    public void AddTribe()
    {
        FindObjectOfType<GlobalsScript>().AddPlayer(currPlayer);
    }
}
