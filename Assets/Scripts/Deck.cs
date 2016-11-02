using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {


	//fields for a new deck
	Queue<Card> deck;



	// Use this for initialization
	void Start () {
	//instantiate new deck on start
		deck = new Queue<Card>();

		//add items to the queue.
		deck.Enqueue (
			//new card one
			new Card ("Orc Invasion",
				"Your settlement has been invaded by orcs, they look like they want what you have.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You try to run the orcs off with your military might(10).",
					"You successfully chase off the orcs",
					"You fail to chase off the orcs",
				//win effect,
					Card.Traits.Strength,
					1,
					new Effect[]{
						new Effect(1, Card.Resources.Wood),
						new Effect(1, Card.Resources.Stone),
						new Effect(1, Card.Resources.Food)
					},
					//lose effects
						new Effect[]{
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Resources.Stone),
						new Effect(-1, Card.Resources.Food)}
				),

					//choice 2
					new CardChoice ("AGILITY - Using stealth, you take down the orc leader(10)",
						"The Orc Leader dies",
						"The Orc Leader Thwards your assassination attempt",
						Card.Traits.Agility,
						10,
						//win effect
						new Effect[]{ 
						new Effect(2, Card.Resources.People),
						new Effect(1, Card.Traits.Strength)
					},
						//lose effect
					new Effect{-1, Card.Traits.Strength}
					
					),

					//choice 3
					new CardChoice ("NOTORIETY - Maybe the Orcs are too afraid of you to attack and will offer a peace offering.(12)",
						"They cower in fear at you!  They offer the peace offering",
						"They laugh at you, taking your resources",
						Card.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
						new Effect(1, Card.Resources.Wood),
						new Effect(1, Card.Resources.Stone),
						new Effect(1, Card.Resources.Food)	
					},
						//lose effect
						new Effect[]{ 
						new Effect(-1, Card.Traits.Notoriety),
						new Effect(-1, Card.Resources.Stone),
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Resources.Food)
					})
				
			
				}
			)
		);

		//add second card

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//removed card from the deck
	void Dequeue (Card card)
	{
		
	}


}
