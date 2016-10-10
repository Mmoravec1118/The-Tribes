using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviorScript : MonoBehaviour {

    public string sceneName;

    public Button playbutton;
    public Button rulesButton;
    public int players = 1;

    public enum TribeType
    {
        Type0,
        Type1,
        Type2,
        Type3
    }

    public TribeType tribeType;

    public Button okbutton;
    public Button tribe0Flavor;
    public Button tribe1Flavor;
    public Button tribe2Flavor;
    public Button tribe3Flavor;

    public Text tribe0FlavorText;
    public Text tribe1FlavorText;
    public Text tribe2FlavorText;
    public Text tribe3FlavorText;

    public Image finalDecisionPanel;

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

        tribe0FlavorText.gameObject.SetActive(true);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe1Flavor()
    {
        tribeType = TribeType.Type1;

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(true);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe2Flavor()
    {
        tribeType = TribeType.Type2;

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(true);
        tribe3FlavorText.gameObject.SetActive(false);

        ActivateOK();
    }

    public void Tribe3Flavor()
    {
        tribeType = TribeType.Type3;

        tribe0FlavorText.gameObject.SetActive(false);
        tribe1FlavorText.gameObject.SetActive(false);
        tribe2FlavorText.gameObject.SetActive(false);
        tribe3FlavorText.gameObject.SetActive(true);

        ActivateOK();
    }

    public void StrengthUpdate()
    {
        strengthStat = (int)strengthSlider.value;
    }

    public void AgilityUpdate()
    {
        agilityStat = (int)agilitySlider.value;
    }

    public void TrustUpdate()
    {
        trustStat = (int)trustSlider.value;
    }

    public void SurvivalUpdate()
    {
        survivalStat = (int)survivalSlider.value;
    }

    public void NotorietyUpdate()
    {
        notorietyStat = (int)notorietySlider.value;
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
}
