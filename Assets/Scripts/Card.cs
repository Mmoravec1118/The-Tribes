using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    string title { get; set; }
    string description { get; set; }
    CardChoice[] choices { get; set; }

    public TextMesh titleMesh;
    public TextMesh descriptionMesh;
    public ButtonBehaviorScript option1;
	public ButtonBehaviorScript option2;
	public ButtonBehaviorScript option3;
    public Card(string title, string description, CardChoice[] choices)
    {
        this.title = title;
        this.description = description;
        this.choices = choices;
		//this.option1 = choices [0];
    }

	// Use this for initialization
	void Start () {
        Card card = GlobalsScript.Instance.PlayDeck.Dequeue();
        titleMesh.text = card.title;
        descriptionMesh.text = card.description;
		option1.guiText = card.choices [0];
		option2.guiText = card.choices [1];
		option3.guiText = card.choices [2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
