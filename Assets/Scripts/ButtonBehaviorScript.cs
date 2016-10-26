using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviorScript : MonoBehaviour {

    public string sceneName;

    // Buttons passed in
    public PlayerSelectionController playerSelectionController;

    public Button playbutton;
    public Button rulesButton;
    public Button playerSlideButton;
    public Text sliderText;


    // Tribe type enumeration
    public enum TribeType
    {
        Type0,
        Type1,
        Type2,
        Type3
    }

    public TribeType tribeType;

    // Tribe Type Buttons
    public Button okbutton;
    public Button tribe0Flavor;
    public Button tribe1Flavor;
    public Button tribe2Flavor;
    public Button tribe3Flavor;

    // Tribe Type Text
    public Text tribe0FlavorText;
    public Text tribe1FlavorText;
    public Text tribe2FlavorText;
    public Text tribe3FlavorText;

    public Image finalDecisionPanel;

    // SLiders for stats
    public Slider playerCountSlider;

    public Slider strengthSlider;
    public Slider agilitySlider;
    public Slider trustSlider;
    public Slider survivalSlider;
    public Slider notorietySlider;

    // Stat Values
    public int strengthStat;
    public int agilityStat;
    public int trustStat;
    public int survivalStat;
    public int notorietyStat;

    public void Start()
    {
        playerSelectionController = GameObject.FindObjectOfType<PlayerSelectionController>();

        PlayerPrefs.SetInt("NumberOfPlayers", 1);

        ResetStats();
    }

    public void OnValueChange()
    {
        players = (int)playerCountSlider.value;

        print("PlayerCount: " + players.ToString());

        // This is where the number of players is stored between scenes
        playerSelectionController.SetPlayerCount(players);
        PlayerPrefs.SetInt("NumberOfPlayers", players);
    }

    public void ChangeScene()
    {
        // Loops the player setup scene for the number of players selected
        if (SceneManager.GetActiveScene().name == "PlayerSetup")
        {
            if (playerSelectionController.GetTempPlayerCount() < (players + 1))
            {
                sceneName = "PlayerSetup";
                playerSelectionController.SetTempPlayerCount(playerSelectionController.GetTempPlayerCount() + 1);
                playerSelectionController.PlayerSwitch(playerSelectionController.GetTempPlayerCount() + 1);

                ResetStats();
        
                print(playerSelectionController.GetTempPlayerCount().ToString());
            }
            else
            {
                sceneName = "Gameplay";
            }
        }
        
        SceneManager.LoadScene(sceneName);
    }

    public void Play()
    {
        playbutton.gameObject.SetActive(true);
    }

    public void Rules()
    {
        rulesButton.gameObject.SetActive(true);
    }

    public void OnRuleButton ()
    {
        rulesButton.gameObject.SetActive(false);
    }

    public void Deactivate()
    {
        playerSlideButton.gameObject.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ActivateOK()
    {
        if (okbutton.gameObject.activeInHierarchy == false)
        {
            okbutton.gameObject.SetActive(true);
        }
    }

    public void Tribe0Flavor()
    {
        tribeType = TribeType.Type0;

        // This is where the selected value of the tribe is stored between scenes
        PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(true);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe1Flavor()
    {
        tribeType = TribeType.Type1;

        // This is where the selected value of the tribe is stored between scenes
        PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(true);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe2Flavor()
    {
        tribeType = TribeType.Type2;

        // This is where the selected value of the tribe is stored between scenes
        PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(true);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe3Flavor()
    {
        tribeType = TribeType.Type3;

        // This is where the selected value of the tribe is stored between scenes
        PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());

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
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentStrengthStatKey(), strengthStat);
    }

    public void AgilityUpdate()
    {
        agilityStat = (int)agilitySlider.value;

        // This is where the Agility stat is stored between scenes
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentAgilityStatKey(), agilityStat);
    }

    public void TrustUpdate()
    {
        trustStat = (int)trustSlider.value;

        // This is where the Trust stat is stored between scenes
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentTrustStatKey(), trustStat);
    }

    public void SurvivalUpdate()
    {
        survivalStat = (int)survivalSlider.value;

        // This is where the Survival stat is stored between scenes
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentSurvivalStatKey(), survivalStat);
    }

    public void NotorietyUpdate()
    {
        notorietyStat = (int)notorietySlider.value;

        // This is where the Notoriety stat is stored between scenes
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentNotorietyStatKey(), notorietyStat);
    }

    public void OnOKClick()
    {
        tribe0Flavor.gameObject.SetActive(false);
        tribe1Flavor.gameObject.SetActive(false);
        tribe2Flavor.gameObject.SetActive(false);
        tribe3Flavor.gameObject.SetActive(false);

        strengthSlider.gameObject.SetActive(false);
        agilitySlider.gameObject.SetActive(false);
        trustSlider.gameObject.SetActive(false);
        survivalSlider.gameObject.SetActive(false);
        notorietySlider.gameObject.SetActive(false);

        okbutton.gameObject.SetActive(false);

        finalDecisionPanel.gameObject.SetActive(true);
    }

    public void OnNoClick()
    {
        tribe0Flavor.gameObject.SetActive(true);
        tribe1Flavor.gameObject.SetActive(true);
        tribe2Flavor.gameObject.SetActive(true);
        tribe3Flavor.gameObject.SetActive(true);

        strengthSlider.gameObject.SetActive(true);
        agilitySlider.gameObject.SetActive(true);
        trustSlider.gameObject.SetActive(true);
        survivalSlider.gameObject.SetActive(true);
        notorietySlider.gameObject.SetActive(true);

        okbutton.gameObject.SetActive(true);

        finalDecisionPanel.gameObject.SetActive(false);
    }

    private void ResetStats()
    {
        tribeType = TribeType.Type0;
        strengthStat = 0;
        agilityStat = 0;
        trustStat = 0;
        survivalStat = 0;
        notorietyStat = 0;

        // Initializing all stats and values to their default states
        PlayerPrefs.SetString(playerSelectionController.GetCurrentTribeTypeKey(), tribeType.ToString());
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentStrengthStatKey(), strengthStat);
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentAgilityStatKey(), agilityStat);
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentTrustStatKey(), trustStat);
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentSurvivalStatKey(), survivalStat);
        PlayerPrefs.SetInt(playerSelectionController.GetCurrentNotorietyStatKey(), notorietyStat);
    }
}
