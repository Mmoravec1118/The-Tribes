using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    // deck reference
    public Deck deck;

    // title text
    public string title { get; set; }

    // descrtiption text
    public string description { get; set; }

    // card choice infromation
    public CardChoice[] choices { get; set; }

    public Text titleMesh;
    public Text descriptionMesh;
    public Text option1;
	public Text option2;
	public Text option3;
    public Card(string title, string description, CardChoice[] choices)
    {
        this.title = title;
        this.description = description;
        this.choices = choices;
    }

	// Use this for initialization
	void Start () {
        Card card = GlobalsScript.Instance.PlayDeck.Dequeue();
        titleMesh.text = card.title;
        descriptionMesh.text = card.description;
        option1.text = card.choices[0].Description;
        option2.text = card.choices[1].Description;
        option3.text = card.choices[2].Description;
    }

    // Update is called once per frame

}
