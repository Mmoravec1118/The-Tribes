using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    string title { get; set; }
    string description { get; set; }
    CardChoice[] choices = new CardChoice[3];

    public TextMesh titleMesh;
    public TextMesh descriptionMesh;
    public Card(string title, string description, CardChoice[] choices)
    {
        this.title = title;
        this.description = description;
        this.choices = choices;
    }

	// Use this for initialization
	void Start () {
        Card card = Deck.Instance.Dequeue();
        titleMesh.text = card.title;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
