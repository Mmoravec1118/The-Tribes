using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatSliderScript : MonoBehaviour {

    public Slider mainSlider;
    public Text sliderButtonText;

    public int stat = 0;

    void Start()
    {
        sliderButtonText.text = "0";
    }

    void Update()
    {
        if (mainSlider.value != stat)
        {
            stat = (int)mainSlider.value;
            sliderButtonText.text = stat.ToString();
        }

    }
}
