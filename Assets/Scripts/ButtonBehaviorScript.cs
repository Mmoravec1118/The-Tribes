using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviorScript : MonoBehaviour {

    public string sceneName;

    public Button playbutton;
    public Button rulesButton;
    public int players = 1;

    public void OnValueChange()
    {
        players = (int)GetComponent<Slider>().value;
    }

    public void ChangeScene()
    {
        
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

    public void Exit()
    {
        Application.Quit();
    }
}
