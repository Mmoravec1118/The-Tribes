using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DieScript : MonoBehaviour {

    int dieResult;

    public Text dieDisplay;

    bool dieRolling;
    float rollingTimer = 0;

    public void Update()
    {
        if (dieRolling)
        {
            rollingTimer += (Time.deltaTime);
            InvokeRepeating("UpdateDisplay", 0, 0.9f);
        }
        if (rollingTimer >= 2)
        {
            rollingTimer = 0;
            dieRolling = false;
            CancelInvoke("UpdateDisplay");
            dieResult = (int)Random.Range(1, 7);
            dieDisplay.text = "" + dieResult;
        }
        
    }

    public void RollDie ()
    {

        dieRolling = true;
        
    }

    public void UpdateDisplay ()
    {
        dieDisplay.text = "" + (int)Random.Range(1, 7);
    }

    public int DieResult
    {
        get
        {
            return dieResult;
        }
    }

}
