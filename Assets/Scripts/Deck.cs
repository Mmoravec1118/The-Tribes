using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    private static Deck instance;
    public static Deck Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Deck();
            }
            return instance;
        }
    }
	//fields for a new deck
	public Queue<Card> deck;
    public GameObject cardPrefab; 

    public Deck()
        {
        Start();
        }
	// Use this for initialization
	void Start () {
		
	//instantiate new deck on start
		deck = new Queue<Card>();
        cardPrefab = Resources.Load("CARD_PREFAB") as GameObject;
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
					GlobalsScript.Traits.Strength,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Wood),
						new Effect(1, GlobalsScript.Resources.Stone),
						new Effect(1, GlobalsScript.Resources.Food)
					},
					//lose effects
						new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("AGILITY - Using stealth, you take down the orc leader(10)",
						"The Orc Leader dies",
						"The Orc Leader Thwards your assassination attempt",
						GlobalsScript.Traits.Agility,
						10,
						//win effect
						new Effect[]{ 
						new Effect(2, GlobalsScript.Resources.People),
						new Effect(1, GlobalsScript.Traits.Strength)
					},
						//lose effect
					new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength)}
					
					),

					//choice 3
					new CardChoice ("NOTORIETY - Maybe the Orcs are too afraid of you to attack and will offer a peace offering.(12)",
						"They cower in fear at you!  They offer the peace offering",
						"They laugh at you, taking your resources",
						GlobalsScript.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
						new Effect(1, GlobalsScript.Resources.Wood),
						new Effect(1, GlobalsScript.Resources.Stone),
						new Effect(1, GlobalsScript.Resources.Food)	
					},
						//lose effect
						new Effect[]{ 
						new Effect(-1, GlobalsScript.Traits.Notoriety),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Food)
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
					GlobalsScript.Traits.Strength,
					12,
					new Effect[]{
						new Effect(0, GlobalsScript.Resources.People),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You try to communicate with the spiders(14)",
						"The spiders are actually highly intelligent and you form an alliance!",
						"You fail to communicate with the spiders.",
						GlobalsScript.Traits.Trust,
						14,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Trust),
							new Effect(-2, GlobalsScript.Resources.People)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You attempt to avoid conflict by leaving your settlement (10)",
						"You avoid the spiders and find more resources!",
						"You avoid the spiders but some of your people die in the wilderness.",
						GlobalsScript.Traits.Survival,
						10,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Resources.Food)
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
					GlobalsScript.Traits.Trust,
					7,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Trust),
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Traits.Trust)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to mask your settlement with bull scent.",
						"Your settlement survives and you find extra resources outside afterward.",
						"You used the wrong scent and instead attracted Minotaurs.  Oops.",
						GlobalsScript.Traits.Survival,
						9,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Traits.Survival)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Stone)}
					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to use your reputation to scare the Minotaurs off(14)",
						"The Minotaurs offer the peace offering",
						"The Minotaurs see your notoriety as a threat and instead launch an attack on your settlement.",
						GlobalsScript.Traits.Notoriety,
						14,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Stone),
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-2, GlobalsScript.Resources.Stone),
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Food)
						})
				}
			)
			//end of enqueue card 2
		);


		//CARD 4
		//PIXIES AT PLAY
		deck.Enqueue (
			//new card one
			new Card ("Pixies at play",
				"Mischevious Pixies have left their forest to 'investigate' your settlement.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You attempt to murder the pixies(12).",
					"You destroy the pixies and take their resources for yourself.",
					"The pixies enrage and kill some of your villagers in their sleep.",
					//win effect,
					GlobalsScript.Traits.Strength,
					12,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Notoriety),
						new Effect(1, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Traits.Strength),
						new Effect(-1, GlobalsScript.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You Attempt to persuade the pixies of the fun in protecting your settlement with their magic(7)",
						"They find the thought amusing and make a magical barrier for your settlement.",
						"The pixies find it more amusing to makea barrier that instead weakens your settlement to future threats...",
						GlobalsScript.Traits.Trust,
						7,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Agility),
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Traits.Agility),
							new Effect(-1, GlobalsScript.Traits.Trust)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to enslave the pixies.(12)",
						"You somehow manage to enslave the entire pixie colony and they become slaves for your settlement.",
						"The pixies enslave part of your settlement and drag them into the woods never to be seen again.",
						GlobalsScript.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Resources.People),
							new Effect(1, GlobalsScript.Traits.Notoriety),
							new Effect(1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Strength)
						})
				}
			)
			//end of enqueue card 4
		);


		//add items to the queue.
		//CARD 5
		//WIZARD PROTEST
		deck.Enqueue (
			//new card one
			new Card ("Wizard Protest",
				"The Local Wizard is fed up with his living conditions and decides to threaten your settlement until it improves.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You offer the Wizard better living conditions by renovating his tower(10).",
					"He appreciates the offer and at the expense of a few resources, he makes peace.",
					"The wizard claims your efforts are too late, and takes resources by force",
					//win effect,
					GlobalsScript.Traits.Trust,
					10,
					new Effect[]{
						new Effect(2, GlobalsScript.Traits.Trust),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Traits.Strength),
						new Effect(-1, GlobalsScript.Traits.Agility),
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Stone)
					}
				),

					//choice 2
					new CardChoice ("AGILITY - You attempt to stop the wizard before he can do any damage(12)",
						"You sneak past the wizard and knock him out",
						"The wizard blows up your village",
						GlobalsScript.Traits.Agility,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Agility),
							new Effect(-1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Traits.Agility)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to intimidate the Wizard into rescinding his attack.(15)",
						"The Wizard is no match for you, as you outlevel him significantly.  He begs for forgiveness.",
						"You get ganked by the Wizard and look foolish.",
						GlobalsScript.Traits.Notoriety,
						15,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Notoriety)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 5
		);

		//add items to the queue.
		//CARD 6
		//THRILL OF THE HUNT
		deck.Enqueue (
			//new card one
			new Card ("Thrill of the Hunt",
				"A vicious hunter begins to stalk and hunt your settlement for sport!",

				//choice 1
				new CardChoice[] {new CardChoice ("NOTORIETY - You attempt to use your reputation to scare off the predatory hunter(14).",
					"The hunter decides the thrill of the sport is not worth his own life.",
					"The hunter loves it when his prey puts up a fight and insteads turns up the pressure.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
					14,
					new Effect[]{
						new Effect(3, GlobalsScript.Traits.Notoriety),
						new Effect(1, GlobalsScript.Traits.Strength),
						new Effect(1, GlobalsScript.Traits.Agility)
					},
					//lose effects
					new Effect[]{
						new Effect(-3, GlobalsScript.Resources.People),
						new Effect(-1, GlobalsScript.Traits.Strength),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("Trust - You attempt to convince the hunter that you are not a worthwhile target and instead can supply him.(10)",
						"The hunter agrees, trading some resources for the ones he requires.",
						"The hunter isn't phased by politics, and instead takes resources by force, killing some of your people in the process.",
						GlobalsScript.Traits.Trust,
						10,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Stone),
							new Effect(-1, GlobalsScript.Resources.Food)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, GlobalsScript.Resources.Food),
							new Effect(-2, GlobalsScript.Resources.People)
						}

					),

					//choice 3
					new CardChoice ("STRENGTH - You attempt to hunt the hunter, engaging in a deadly bloodsport.(12)",
						"The hunter becomes the prey and your settlement eliminates him and takes his resources.",
						"You fight a hard battle, but lose settlers in the process.",
						GlobalsScript.Traits.Strength,
						12,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Traits.Notoriety)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Resources.Wood),
							new Effect(-1, GlobalsScript.Resources.Stone)
						})
				}
			)
			//end of enqueue card 6
		);


		//add items to the queue.
		//CARD 7
		//WILDFIRE
		deck.Enqueue (
			//new card one
			new Card ("Wildfire",
				"Your Settlement finds itself in the path of a raging wildfire!",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You attempt to abandon your current settlement with your villagers taking anything you can carry.",
					"You manage to escape, losing no resources but gaining some survival rank.",
					"You fail to evacuate in time, and while no one is injured, your resources are burnt in the blaze.",
					//win effect,
					GlobalsScript.Traits.Agility,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Survival),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Resources.Wood),
						new Effect(-2, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to dig fire trenches between the fire and your village to contain the fire.(12)",
						"The trench works and your settlement is spared and the new ditch serves as a new infrastructure to irrigate future crops.",
						"The trench was not complete in time and your village is partially scorched.",
						GlobalsScript.Traits.Survival,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Resources.Wood),
							new Effect(-1, GlobalsScript.Resources.Food)
						}
					),

					//choice 3
					new CardChoice ("STRENGTH - You take some villagers to attempt to extinguish the fire before it reaches the village.(13)",
						"Your efforts save the village and you gain some food and wood in the scramble.",
						"You lose not only a hefty portion of your village, but a large number of villagers",
						GlobalsScript.Traits.Strength,
						13,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Food),
							new Effect(-1, GlobalsScript.Traits.Survival)
						})
				}
			)
			//end of enqueue card 7
		);

        //add items to the queue.
        //CARD 8
        //THE PLAGUE
        deck.Enqueue(
            //new card one
            new Card("The Plague",
                "Rats have brought the plague to your village!",

                //choice 1
                new CardChoice[] {new CardChoice ("SURVIVAL - You attempt to find a cure for the plague.(11)",
                    "You manage to find the cure, however you lose some food but gain some survival rank.",
                    "You fail to find a cure in time, many people are dead.",
					//win effect,
					GlobalsScript.Traits.Survival,
                    11,
                    new Effect[]{
                        new Effect(1, GlobalsScript.Traits.Survival),
                        new Effect(-1, GlobalsScript.Resources.Food)
                    },
					//lose effects
					new Effect[]{
                        new Effect(-2, GlobalsScript.Resources.People)}
                ),

					//choice 2
					new CardChoice ("AGILITY - You attempt to flee the village with anyone not sick(12)",
                        "The evacuation was successfull, you and your people wait until those infected die off before moving back in.",
                        "In the chaos of running away, your people lose valuable resources.",
                        GlobalsScript.Traits.Agility,
                        12,
						//win effect
						new Effect[]{
                            new Effect(-1, GlobalsScript.Resources.People),
                            new Effect(2, GlobalsScript.Traits.Notoriety)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-1, GlobalsScript.Resources.Wood),
                            new Effect(-1, GlobalsScript.Resources.Food),
                            new Effect(-1, GlobalsScript.Resources.Stone)
                        }
                    ),

					//choice 3
					new CardChoice ("NOTORIETY - You decide to kill the infected and burn their bodies.(14)",
                        "The people might not be happy about killing their own, but at least they are alive and fear you.",
                        "The people ignore you and try to help the infected causing the plague to spread, they realize you were right, you find stash of resources",
                        GlobalsScript.Traits.Notoriety,
                        14,
						//win effects
						new Effect[]{
                            new Effect(2, GlobalsScript.Traits.Notoriety),
                            new Effect(-1, GlobalsScript.Resources.People)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-2, GlobalsScript.Resources.People),
                            new Effect(1, GlobalsScript.Resources.Wood),
                            new Effect(1, GlobalsScript.Resources.Food),
                            new Effect(1, GlobalsScript.Traits.Trust)
                        })
                }
            )
        //end of enqueue card 8
        );

        //add items to the queue.
        //CARD 9
        //BANDITS
        deck.Enqueue(
            //new card one
            new Card("BANDITS",
                "Your Settlement has been targeted by a group of Bandits!",

                //choice 1
                new CardChoice[] {new CardChoice ("NOTORIETY - You decide to intimadate the bandits using your fearful presence.",
                    "The bandits are completely frightened by your presence, they decide to join you",
                    "The bandits laugh at your pitiful display, they take what they want.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
                    14,
                    new Effect[]{
                        new Effect(2, GlobalsScript.Traits.Notoriety),
                        new Effect(1, GlobalsScript.Traits.Strength),
                        new Effect(3, GlobalsScript.Resources.People),
                        new Effect(2, GlobalsScript.Resources.Food),
                        new Effect(2, GlobalsScript.Resources.Stone),
                        new Effect(2, GlobalsScript.Resources.Wood)
                    },
					//lose effects
					new Effect[]{
                        new Effect(-2, GlobalsScript.Resources.Wood),
                        new Effect(-2, GlobalsScript.Resources.Food),
                        new Effect(-1, GlobalsScript.Resources.People),
                        new Effect(-2, GlobalsScript.Traits.Notoriety)}
                ),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to negioate with the bandits.(10)",
                        "The negioations were successful, they leave with a few resources and your people admire you.",
                        "The negioations failed completely, they enslave a portion of your people.",
                        GlobalsScript.Traits.Survival,
                        10,
						//win effect
						new Effect[]{
                            new Effect(-1, GlobalsScript.Resources.Food),
                            new Effect(-1, GlobalsScript.Resources.Wood),
                            new Effect(2, GlobalsScript.Traits.Trust)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-2, GlobalsScript.Resources.People),
                            new Effect(-1, GlobalsScript.Traits.Survival)
                        }
                    ),

					//choice 3
					new CardChoice ("STRENGTH - You take your strongest villagers and attempt to fight them off.(12)",
                        "Your warriors drive the enemy off your lands, you locate their base free the slaves and gain resources.",
                        "You underestimated the bandits and now they have taken the town, your people curse your name.",
                        GlobalsScript.Traits.Strength,
                        12,
						//win effects
						new Effect[]{
                            new Effect(2, GlobalsScript.Resources.Wood),
                            new Effect(2, GlobalsScript.Resources.Food),
                            new Effect(2, GlobalsScript.Resources.Stone),
                            new Effect(2, GlobalsScript.Resources.People),
                            new Effect(2, GlobalsScript.Traits.Strength),
                            new Effect(1, GlobalsScript.Traits.Notoriety)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-2, GlobalsScript.Resources.People),
                            new Effect(-1, GlobalsScript.Resources.Wood),
                            new Effect(-2, GlobalsScript.Resources.Food),
                            new Effect(-1, GlobalsScript.Resources.Stone),
                            new Effect(-1, GlobalsScript.Traits.Strength),
                            new Effect(-2, GlobalsScript.Traits.Trust)
                        })
                }
            )
        //end of enqueue card 9
        );

        //add items to the queue.
        //CARD 10
        //FLEEING REFUGEES
        deck.Enqueue(
            //new card one
            new Card("FLEEING REFUGEES",
                "A large group of refugees approach your village!",

                //choice 1
                new CardChoice[] {new CardChoice ("TRUST - You attempt to convince your village to help the refugees.(11)",
                    "The people decide to let the refugees in, while food might be stretched, they bring some resources.",
                    "The people ignore you and turn away the refugees, the refugees believe it is because of you.",
					//win effect,
					GlobalsScript.Traits.Trust,
                    11,
                    new Effect[]{
                        new Effect(3, GlobalsScript.Traits.Trust),
                        new Effect(-1, GlobalsScript.Resources.Food),
                        new Effect(1, GlobalsScript.Resources.Wood),
                        new Effect(1, GlobalsScript.Resources.Stone)
                    },
					//lose effects
					new Effect[]{
                        new Effect(2, GlobalsScript.Traits.Notoriety),
                        new Effect(-2, GlobalsScript.Traits.Trust)}
                ),

					//choice 2
					new CardChoice ("AGILITY - You decide to flee with your people from whatever the refugees are fleeing from.(14)",
                        "Your village leaves the area without losing anything, they pick up some refugees and your survival increases.",
                        "The people panic when the refugees near and scatter across the land.",
                        GlobalsScript.Traits.Agility,
                        14,
						//win effect
						new Effect[]{
                            new Effect(1, GlobalsScript.Resources.People),
                            new Effect(2, GlobalsScript.Traits.Survival),
                            new Effect(1, GlobalsScript.Traits.Agility)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-1, GlobalsScript.Resources.Wood),
                            new Effect(-1, GlobalsScript.Resources.Food),
                            new Effect(-1, GlobalsScript.Resources.Stone),
                            new Effect(-1, GlobalsScript.Resources.People),
                        }
                    ),

					//choice 3
					new CardChoice ("STRENGTH - You decide to build a new village for the Refugees.(12)",
                        "While it did cost resources, the village is thriving and you have new allies.",
                        "Instead of a village you create a shantytown, the refugees leave, cursing your name and stealing some food.",
                        GlobalsScript.Traits.Strength,
                        12,
						//win effects
						new Effect[]{
                            new Effect(-1, GlobalsScript.Resources.Wood),
                            new Effect(-1, GlobalsScript.Resources.Food),
                            new Effect(-1, GlobalsScript.Resources.Stone),
                            new Effect(2, GlobalsScript.Traits.Trust),
                            new Effect(1, GlobalsScript.Traits.Strength)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-1, GlobalsScript.Resources.Food),
                            new Effect(-2, GlobalsScript.Traits.Trust),
                            new Effect(2, GlobalsScript.Traits.Notoriety)
                        })
                }
            )
        //end of enqueue card 10
        );

        //add items to the queue.
        //CARD 11
        //BLOOD FOR THE BLOOD GOD
        deck.Enqueue(
            //new card one
            new Card("BLOOD FOR THE BLOOD GOD",
                "The god of blood and death demands a sacrifice.",

                //choice 1
                new CardChoice[] {new CardChoice ("NOTORIETY - Deciding not to anger the god, you sacrifice one of your people.(14)",
                    "The blood god is pleased with the sacrifice, Resources are bountiful in the area and you feel a change inside you.",
                    "The sacrifical pawn flees, the god is angered about you incompetence and curses you.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
                    14,
                    new Effect[]{
                        new Effect(3, GlobalsScript.Traits.Notoriety),
                        new Effect(-1, GlobalsScript.Traits.Trust),
                        new Effect(2, GlobalsScript.Traits.Strength),
                        new Effect(1, GlobalsScript.Traits.Agility),
                        new Effect(1, GlobalsScript.Traits.Survival),
                        new Effect(-1, GlobalsScript.Resources.People),
                        new Effect(3, GlobalsScript.Resources.Food),
                        new Effect(3, GlobalsScript.Resources.Stone),
                        new Effect(3, GlobalsScript.Resources.Wood)
                    },
					//lose effects
					new Effect[]{
                        new Effect(-1, GlobalsScript.Traits.Agility),
                        new Effect(-1, GlobalsScript.Traits.Notoriety),
                        new Effect(-1, GlobalsScript.Traits.Strength),
                        new Effect(-1, GlobalsScript.Traits.Survival)
                    }
                ),

					//choice 2
					new CardChoice ("TRUST - You decide to sacrifice yourself for the good of the village.(10)",
                        "The people are so moved by your sacrifice that they plead with the gods to bring you back, now your are stronger.",
                        "Your pitiful blood does not appease the god, lighting destroys the grain silo.",
                        GlobalsScript.Traits.Trust,
                        10,
						//win effect
						new Effect[]{
                            new Effect(2, GlobalsScript.Traits.Strength),
                            new Effect(1, GlobalsScript.Traits.Agility)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-2, GlobalsScript.Resources.Food)
                        }
                    ),

					//choice 3
					new CardChoice ("SURVIVAL - In a surge of desperation, you appeal to the other gods for help.(13)",
                        "The Goddess of Wisdom hears your pleas and forces the blood god to leave, you feel more knowledgable on the world.",
                        "The gods laugh at you groveling skills, you are forced to preform a larger sacrifice",
                        GlobalsScript.Traits.Survival,
                        13,
						//win effects
						new Effect[]{
                            new Effect(2, GlobalsScript.Traits.Survival)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-2, GlobalsScript.Resources.People),
                            new Effect(-2, GlobalsScript.Resources.Food)
                        })
                }
            )
        //end of enqueue card 11
        );

        //add items to the queue.
        //CARD 12
        //FESTIVAL OF LOVE
        deck.Enqueue(
            //new card one
            new Card("FESTIVAL OF LOVE",
                "It is time to increase the population!",

                //choice 1
                new CardChoice[] {new CardChoice ("AGILITY - You hold a race to win over the womens affections.(12)",
                    "The women are impressed with the agile prowess of the men, everyone has a great time.",
                    "Many of the men break their legs while racing, the women laugh and some leave the tribe.",
					//win effect,
					GlobalsScript.Traits.Agility,
                    12,
                    new Effect[]{
                        new Effect(3, GlobalsScript.Resources.People)
                    },
					//lose effects
					new Effect[]{
                        new Effect(-1, GlobalsScript.Resources.People)
                    }
                ),

					//choice 2
					new CardChoice ("STRENGTH - You decide to have the men do a log lifthing tournament.(10)",
                        "The tribes women are impressed by the strength of their men, celebrations begin.",
                        "Your weak men run for their lives, hating you for this horrible idea.",
                        GlobalsScript.Traits.Strength,
                        10,
						//win effect
						new Effect[]{
                            new Effect(1, GlobalsScript.Traits.Strength),
                            new Effect(2, GlobalsScript.Resources.Wood),
                            new Effect(2, GlobalsScript.Resources.People)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-1, GlobalsScript.Traits.Trust),
                            new Effect(-1, GlobalsScript.Resources.People)
                        }
                    ),

					//choice 3
					new CardChoice ("SURVIVAL - Its decided to hold a hunt for the Silver Stag.(11)",
                        "The silver stag got away, but the hunters brought in a lot of food.",
                        "The hunt turns into the great farce, some people are killed and others wander away.",
                        GlobalsScript.Traits.Survival,
                        13,
						//win effects
						new Effect[]{
                            new Effect(1, GlobalsScript.Traits.Survival),
                            new Effect(2, GlobalsScript.Resources.Food),
                            new Effect(1, GlobalsScript.Resources.People)
                        },
						//lose effect
						new Effect[]{
                            new Effect(-2, GlobalsScript.Resources.People),
                            new Effect(1, GlobalsScript.Traits.Notoriety)
                        })
                }
            )
        //end of enqueue card 12
        );
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	//removed card from the deck
	public Card Dequeue()
	{
		//dequeue the card from the top of the deck
		return deck.Dequeue ();
	}

    public void DrawCard()
    {
        Instantiate(cardPrefab, FindObjectOfType<Canvas>().transform);
        
    }

}
