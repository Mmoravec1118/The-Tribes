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
    public Slider playerCountSlider;

    int players = 2;

    public void Start()
    {
        PlayerPrefs.SetInt("NumberOfPlayers", players);
    }

    public void OnValueChange()
    {
        players = (int)playerCountSlider.value;

        print("PlayerCount: " + players.ToString());

        // This is where the number of players is stored between scenes
        PlayerPrefs.SetInt("NumberOfPlayers", players);
    }

    public void ChangeScene()
    {
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
