using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
    public enum CardType { Event, GlobalEvent, Scar }
    public enum Traits { Strength, Agility, Trust, Survival, Notoriety }
    public enum Resources { Wood, Stone, People, Food }

    string title { get; set; }
    string description { get; set; }
    CardChoice[] choices = new CardChoice[3];

    public Card(string title, string description, CardChoice[] choices)
    {
        this.title = title;
        this.description = description;
        this.choices = choices;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
