using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviorScript : MonoBehaviour
{

    // Buttons passed in
    public Button playbutton;
    public Button rulesButton;
    public Button playerSlideButton;
    public Text sliderText;

    // SLiders for stats
    public Slider playerCountSlider;

    int players = 2;

    public void Start()
    {
        GlobalsScript.PlayerCount = players;
    }

    public void OnValueChange()
    {
        players = (int)playerCountSlider.value;

        print("PlayerCount: " + players.ToString());

        // This is where the number of players is stored between scenes
        GlobalsScript.PlayerCount = players;
    }

    public void ChangeScene()
    {
        // Since these are buttons of the Main Menu, the only scene the scene changes
        // to is PlayerSetup
        SceneManager.LoadScene("PlayerSetup");
    }
        
    public void Play()
    {
        playbutton.gameObject.SetActive(true);
    }

    public void Rules()
    {
        rulesButton.gameObject.SetActive(true);
    }

    public void OnRuleButton()
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
}
