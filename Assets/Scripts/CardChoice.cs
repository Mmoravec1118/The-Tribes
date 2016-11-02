using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardChoice : MonoBehaviour {

    Effect[] winEffects;
    Effect[] lossEffects;
    string description;
    string Description
	string winText;
	string lossText;
    {
        get
        {
            return description;
        }
    }
	public CardChoice(string description, string winText, string lossText, Card.Traits trait, int toBeat, Effect[] winEffects, Effect[] lossEffects)
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
    Card.Traits toChangeTrait;
	Card.Resources toChangeResource;

    public Effect(int change, Card.Traits toChangeTrait)
    {
        this.change = change;
        this.toChangeTrait = toChangeTrait;
    }

	public Effect(int change, Card.Resources toChangeResource)
	{
		this.change = change;
		this.toChangeResource = toChangeResource;
	}

    //public void MakeChange(Player player)
    //{

    //}
}
