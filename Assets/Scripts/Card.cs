using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    string title { get; set; }
    string description { get; set; }
    CardChoice[] choices { get; set; }

    public TextMesh titleMesh;
    public TextMesh descriptionMesh;
    public ButtonBehaviorScript option1;
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
       // option1.guiText = card.choices[0].
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
