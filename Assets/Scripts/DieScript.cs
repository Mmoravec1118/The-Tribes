using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DieScript : MonoBehaviour {

   // Fields
    [SerializeField] Text dieDisplay;  //shows up in editor

    // value after die was rolled
    int dieResult = 1;

    // if die is rolling and timer it has been rolling
    bool dieRolling;
    float rollingTimer = 0;

    bool needsToRoll = false;

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
            needsToRoll = false;
            CancelInvoke("UpdateDisplay");
            dieResult = (int)Random.Range(1, 7);
            dieDisplay.text = "" + dieResult;
        }
        
    }

    // set die to random number until die roll is done
    public void RollDie ()
    {
        if (needsToRoll)
        {
            dieRolling = true;
        }
    }

    // Display end die result
    public void UpdateDisplay ()
    {
        dieDisplay.text = "" + (int)Random.Range(1, 7);
    }

    //Property for getting die result
    public int DieResult
    {
        get
        {
            return dieResult;
        }
    }

    // get ad set if die needs to roll
    public bool NeedsRoll
    {
        get
        {
            return needsToRoll;
        }
        set
        {
            needsToRoll = value;
        }
    }


}
