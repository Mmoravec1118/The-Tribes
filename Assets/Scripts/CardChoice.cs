using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardChoice : MonoBehaviour {

    Effect[] winEffects;
    Effect[] lossEffects;
    string description;
    string winText;
    string lossText;
    string Description
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
    }
}

public class Effect
{
    int change;
    GlobalsScript.Traits toChangeTrait;
	GlobalsScript.Resources toChangeResource;

    public Effect(int change, GlobalsScript.Traits toChangeTrait)
    {
        this.change = change;
        this.toChangeTrait = toChangeTrait;
    }

	public Effect(int change, GlobalsScript.Resources toChangeResource)
	{
		this.change = change;
		this.toChangeResource = toChangeResource;
	}

    //public void MakeChange(Player player)
    //{

    //}
}
