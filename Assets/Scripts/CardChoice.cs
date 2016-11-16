using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardChoice : MonoBehaviour {
    
    //Fields
    Effect[] winEffects;
    Effect[] lossEffects;
    string description;
    string winText;
    string lossText;
    int cost;
    GlobalsScript.Traits currTrait;

    public string Description
    {
        get
        {
            return description;
        }
    }
	public CardChoice(string description, string winText, string lossText, GlobalsScript.Traits trait, int toBeat, Effect[] winEffects, Effect[] lossEffects)
    {
        this.description = description;
        this.winEffects = winEffects;
        this.lossEffects = lossEffects;
		this.winText = winText;
		this.lossText = lossText;
        cost = toBeat;
        currTrait = trait;
    }

    #region Methods

    public Effect GetWinEffect(int effectNum)
    {
        return winEffects[effectNum];
    }

    public Effect GetLossEffect(int effectNum)
    {
        return lossEffects[effectNum];
    }

    #endregion

    #region Properties

    public int GetEffectCost
    {
        get
        {
            return cost;
        }
    }

    public GlobalsScript.Traits GetTrait
    {
        get
        {
            return currTrait;
        }
    }

    public string GetWinText
    {
        get
        {
            return winText;
        }
    }

    public string GetLoseText
    {
        get
        {
            return lossText;
        }
    }

    #endregion

}

public class Effect
{
    int change;
    GlobalsScript.Traits toChangeTrait;
	GlobalsScript.Resources toChangeResource;

    bool ChangeStuff = false;
    bool traitChange;

    public Effect(int change, GlobalsScript.Traits toChangeTrait)
    {
        this.change = change;
        this.toChangeTrait = toChangeTrait;
        traitChange = true;
    }

	public Effect(int change, GlobalsScript.Resources toChangeResource)
	{
		this.change = change;
		this.toChangeResource = toChangeResource;
        traitChange = false;
	}

    void Update()
    {
        if (ChangeStuff &&
            traitChange)
        {
            switch (toChangeTrait)
            {

                case GlobalsScript.Traits.Agility:
                    {
                        GlobalsScript.Instance.GetPlayer().Agility += change;
                        ChangeStuff = false;
                        break;
                    }
            }
        }
        else if (ChangeStuff &&
            !traitChange)
        {

        }
    }


    #region Properties

    public int GetChange
    {
        get
        {
            return change;
        }
    }

    public GlobalsScript.Resources GetResource
    {
        get
        {
            return toChangeResource;
        }
    }

    public GlobalsScript.Traits GetTrait
    {
        get
        {
            return toChangeTrait;
        }
    }

    public bool SetChange
    {
        set
        {
            ChangeStuff = value;
        }
    }

    #endregion
}
