using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public Slider mainSlider;
    public Text sliderButtonText;

    public int players = 1;

    void Start()
    {
        sliderButtonText.text = "Player Count: ";
    }

    void Update()
    {
        if (mainSlider.value != players)
        {
            players = (int)mainSlider.value;
            sliderButtonText.text = "Player Count:  " + players;
        }
        
    }
}
