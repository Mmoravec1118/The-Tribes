using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviorScript : MonoBehaviour
{

    // Buttons passed in
    [SerializeField] Button playbutton;
    [SerializeField] Button rulesButton;
    [SerializeField] Button playerSlideButton;
    [SerializeField] Text sliderText;

    [SerializeField] string sceneName;

    // SLiders for stats
    public Slider playerCountSlider;

    int players = 2;

    public void Start()
    {
        GlobalsScript.NumberofPlayers = players;
    }

    public void OnValueChange()
    {
        players = (int)playerCountSlider.value;

        print("PlayerCount: " + players.ToString());

        // This is where the number of players is stored between scenes
        GlobalsScript.NumberofPlayers = players;
    }

    public void ChangeScene()
    {
        // Since these are buttons of the Main Menu, the only scene the scene changes
        // to is PlayerSetup
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
