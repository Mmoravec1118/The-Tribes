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
		//CARD 1
		//ORC INVASION
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
					10,
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
					new Effect[]{
							new Effect(-1, Card.Traits.Strength)}
					
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
			//end of enqueue card 1
		);

		//add second card
		//CARD 2
		//SPIDER INFESTATION
		deck.Enqueue (
			//new card one
			new Card ("Spider Infestation",
				"Your settlement is about to be overrun by giant spiders.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You try to crush the spiders (12).",
					"The Spiders were crushed and the village is safe, but you gain nothing",
					"The spiders take some of your villagers for food",
					//win effect,
					Card.Traits.Strength,
					12,
					new Effect[]{
						new Effect(0, Card.Resources.People),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, Card.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You try to communicate with the spiders(14)",
						"The spiders are actually highly intelligent and you form an alliance!",
						"You fail to communicate with the spiders.",
						Card.Traits.Trust,
						14,
						//win effect
						new Effect[]{ 
							new Effect(2, Card.Traits.Strength),
							new Effect(1, Card.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, Card.Traits.Trust),
							new Effect(-2, Card.Resources.People)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You attempt to avoid conflict by leaving your settlement (10)",
						"You avoid the spiders and find more resources!",
						"You avoid the spiders but some of your people die in the wilderness.",
						Card.Traits.Survival,
						10,
						//win effects
						new Effect[]{
							new Effect(1, Card.Resources.Wood),
							new Effect(1, Card.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, Card.Resources.People),
							new Effect(-1, Card.Resources.Food)
						})


				}
			)
			//end of enqueue card 2
		);

		//add card 3
		//CARD 3
		//MINOTAUR RUTTING SEASON
		deck.Enqueue (
			//new card one
			new Card ("Minotaur Rutting Season",
				"The local minotaur population is currently a riled up and could cause severe damage to your settlement.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You try to Come to an agreement with the Minotaur population to avoid your settlement(7).",
					"They Agree to avoid your settlement.",
					"Minotaurs shag during the meeting and break things...",
					//win effect,
					Card.Traits.Trust,
					7,
					new Effect[]{
						new Effect(1, Card.Traits.Trust),
					},
					//lose effects
					new Effect[]{
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Traits.Trust)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to mask your settlement with bull scent.",
						"Your settlement survives and you find extra resources outside afterward.",
						"You used the wrong scent and instead attracted Minotaurs.  Oops.",
						Card.Traits.Survival,
						9,
						//win effect
						new Effect[]{ 
							new Effect(2, Card.Resources.Food),
							new Effect(2, Card.Resources.Wood),
							new Effect(1, Card.Traits.Survival)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, Card.Resources.Wood),
							new Effect(-2, Card.Resources.Stone)}
					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to use your reputation to scare the Minotaurs off(14)",
						"The Minotaurs offer the peace offering",
						"The Minotaurs see your notoriety as a threat and instead launch an attack on your settlement.",
						Card.Traits.Notoriety,
						14,
						//win effects
						new Effect[]{
							new Effect(1, Card.Resources.Wood),
							new Effect(1, Card.Resources.Stone),
							new Effect(1, Card.Resources.Food),
							new Effect(1, Card.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, Card.Traits.Notoriety),
							new Effect(-2, Card.Resources.Stone),
							new Effect(-2, Card.Resources.Wood),
							new Effect(-2, Card.Resources.Food)
						})


				}
			)
			//end of enqueue card 2
		);


		//CARD 4
		//PIXIES AT PLAY
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
					10,
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
						new Effect[]{
							new Effect(-1, Card.Traits.Strength)}

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
			//end of enqueue card 1
		);


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//removed card from the deck
	void Dequeue (Card card)
	{
		
	}


}
