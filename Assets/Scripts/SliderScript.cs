﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public Button playerSlideButton;
    public Slider mainSlider;
    public Text sliderButtonText;

    public int players = 1;

    void Start()
    {
        sliderButtonText.text = "Player Count: (2 -4 ) ";
        Debug.Log("textDisplayed");
    }

    void Update()
    {
        if (mainSlider.value != players)
        {
            players = (int)mainSlider.value;
            sliderButtonText.text = "Player Count : (2 -4)  " + players;
            Debug.Log("Slider Updated");
        }
        
    }
}