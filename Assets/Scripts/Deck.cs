using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    static Deck instance;
    Object currCard;
    bool delete = false;
    int deleteTimer;

	//fields for a new deck
	public Queue<Card> deck;
    public GameObject cardPrefab; 

    public Deck()
        {
        Start();
        DontDestroyOnLoad(this);
        }

    #region Create Deck

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
				new CardChoice[] {new CardChoice ("STRENGTH - You try to run the orcs off with your military might(6).",
					"You successfully chase off the orcs",
					"You fail to chase off the orcs",
				//win effect,
					GlobalsScript.Traits.Strength,
					6,
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
					new CardChoice ("AGILITY - Using stealth, you take down the orc leader(9)",
						"The Orc Leader dies",
						"The Orc Leader Thwards your assassination attempt",
						GlobalsScript.Traits.Agility,
						9,
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
				new CardChoice[] {new CardChoice ("STRENGTH - You try to crush the spiders (8).",
					"The Spiders were crushed and the village is safe, but you gain nothing",
					"The spiders take some of your villagers for food",
					//win effect,
					GlobalsScript.Traits.Strength,
					8,
					new Effect[]{
						new Effect(0, GlobalsScript.Resources.People),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You try to communicate with the spiders(10)",
						"The spiders are actually highly intelligent and you form an alliance!",
						"You fail to communicate with the spiders.",
						GlobalsScript.Traits.Trust,
						10,
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
					new CardChoice ("SURVIVAL - You attempt to avoid conflict by leaving your settlement (5)",
						"You avoid the spiders and find more resources!",
						"You avoid the spiders but some of your people die in the wilderness.",
						GlobalsScript.Traits.Survival,
						5,
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
					new CardChoice ("SURVIVAL - You attempt to mask your settlement with bull scent.(9)",
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
					new CardChoice ("NOTORIETY - You attempt to use your reputation to scare the Minotaurs off(11)",
						"The Minotaurs offer the peace offering",
						"The Minotaurs see your notoriety as a threat and instead launch an attack on your settlement.",
						GlobalsScript.Traits.Notoriety,
						11,
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
				new CardChoice[] {new CardChoice ("STRENGTH - You attempt to murder the pixies(10).",
					"You destroy the pixies and take their resources for yourself.",
					"The pixies enrage and kill some of your villagers in their sleep.",
					//win effect,
					GlobalsScript.Traits.Strength,
					10,
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
					new CardChoice ("TRUST - You Attempt to persuade the pixies of the fun in protecting your settlement with their magic(5)",
						"They find the thought amusing and make a magical barrier for your settlement.",
						"The pixies find it more amusing to makea barrier that instead weakens your settlement to future threats...",
						GlobalsScript.Traits.Trust,
						5,
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
					new CardChoice ("NOTORIETY - You attempt to enslave the pixies.(8)",
						"You somehow manage to enslave the entire pixie colony and they become slaves for your settlement.",
						"The pixies enslave part of your settlement and drag them into the woods never to be seen again.",
						GlobalsScript.Traits.Notoriety,
						8,
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
				new CardChoice[] {new CardChoice ("TRUST - You offer the Wizard better living conditions by renovating his tower(6).",
					"He appreciates the offer and at the expense of a few resources, he makes peace.",
					"The wizard claims your efforts are too late, and takes resources by force",
					//win effect,
					GlobalsScript.Traits.Trust,
					6,
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
					new CardChoice ("AGILITY - You attempt to stop the wizard before he can do any damage(8)",
						"You sneak past the wizard and knock him out",
						"The wizard blows up your village",
						GlobalsScript.Traits.Agility,
						8,
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
					new CardChoice ("NOTORIETY - You attempt to intimidate the Wizard into rescinding his attack.(12)",
						"The Wizard is no match for you, as you outlevel him significantly.  He begs for forgiveness.",
						"You get ganked by the Wizard and look foolish.",
						GlobalsScript.Traits.Notoriety,
						12,
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
				new CardChoice[] {new CardChoice ("NOTORIETY - You attempt to use your reputation to scare off the predatory hunter(12).",
					"The hunter decides the thrill of the sport is not worth his own life.",
					"The hunter loves it when his prey puts up a fight and insteads turns up the pressure.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
					12,
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
					new CardChoice ("Trust - You attempt to convince the hunter that you are not a worthwhile target and instead can supply him.(7)",
						"The hunter agrees, trading some resources for the ones he requires.",
						"The hunter isn't phased by politics, and instead takes resources by force, killing some of your people in the process.",
						GlobalsScript.Traits.Trust,
						7,
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
					new CardChoice ("STRENGTH - You attempt to hunt the hunter, engaging in a deadly bloodsport.(9)",
						"The hunter becomes the prey and your settlement eliminates him and takes his resources.",
						"You fight a hard battle, but lose settlers in the process.",
						GlobalsScript.Traits.Strength,
						9,
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
				new CardChoice[] {new CardChoice ("AGILITY - You attempt to abandon your current settlement with your villagers taking anything you can carry.(6)",
					"You manage to escape, losing no resources but gaining some survival rank.",
					"You fail to evacuate in time, and while no one is injured, your resources are burnt in the blaze.",
					//win effect,
					GlobalsScript.Traits.Agility,
					6,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Survival),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Resources.Wood),
						new Effect(-2, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to dig fire trenches between the fire and your village to contain the fire.(8)",
						"The trench works and your settlement is spared and the new ditch serves as a new infrastructure to irrigate future crops.",
						"The trench was not complete in time and your village is partially scorched.",
						GlobalsScript.Traits.Survival,
						8,
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
					new CardChoice ("STRENGTH - You take some villagers to attempt to extinguish the fire before it reaches the village.(11)",
						"Your efforts save the village and you gain some food and wood in the scramble.",
						"You lose not only a hefty portion of your village, but a large number of villagers",
						GlobalsScript.Traits.Strength,
						11,
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
					new CardChoice ("AGILITY - You attempt to flee the village with anyone not sick(7)",
                        "The evacuation was successfull, you and your people wait until those infected die off before moving back in.",
                        "In the chaos of running away, your people lose valuable resources.",
                        GlobalsScript.Traits.Agility,
                        7,
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
					new CardChoice ("NOTORIETY - You decide to kill the infected and burn their bodies.(5)",
                        "The people might not be happy about killing their own, but at least they are alive and fear you.",
                        "The people ignore you and try to help the infected causing the plague to spread, they realize you were right, you find stash of resources",
                        GlobalsScript.Traits.Notoriety,
                        5,
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
                new CardChoice[] {new CardChoice ("NOTORIETY - You decide to intimadate the bandits using your fearful presence.(11)",
                    "The bandits are completely frightened by your presence, they decide to join you",
                    "The bandits laugh at your pitiful display, they take what they want.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
                    11,
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
					new CardChoice ("TRUST - You attempt to negioate with the bandits.(8)",
                        "The negioations were successful, they leave with a few resources and your people admire you.",
                        "The negioations failed completely, they enslave a portion of your people.",
                        GlobalsScript.Traits.Trust,
                        8,
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
					new CardChoice ("STRENGTH - You take your strongest villagers and attempt to fight them off.(8)",
                        "Your warriors drive the enemy off your lands, you locate their base free the slaves and gain resources.",
                        "You underestimated the bandits and now they have taken the town, your people curse your name.",
                        GlobalsScript.Traits.Strength,
                        8,
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
                new CardChoice[] {new CardChoice ("TRUST - You attempt to convince your village to help the refugees.(9)",
                    "The people decide to let the refugees in, while food might be stretched, they bring some resources.",
                    "The people ignore you and turn away the refugees, the refugees believe it is because of you.",
					//win effect,
					GlobalsScript.Traits.Trust,
                    9,
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
					new CardChoice ("AGILITY - You decide to flee with your people from whatever the refugees are fleeing from.(6)",
                        "Your village leaves the area without losing anything, they pick up some refugees and your survival increases.",
                        "The people panic when the refugees near and scatter across the land.",
                        GlobalsScript.Traits.Agility,
                        6,
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
                new CardChoice[] {new CardChoice ("NOTORIETY - Deciding not to anger the god, you sacrifice one of your people.(7)",
                    "The blood god is pleased with the sacrifice, Resources are bountiful in the area and you feel a change inside you.",
                    "The sacrifical pawn flees, the god is angered about you incompetence and curses you.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
                    7,
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
                        "The people are so moved by your sacrifice that they plead with the gods to bring you back, now you are stronger.",
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
					new CardChoice ("SURVIVAL - In a surge of desperation, you appeal to the other gods for help.(9)",
                        "The Goddess of Wisdom hears your pleas and forces the blood god to leave, you feel more knowledgable on the world.",
                        "The gods laugh at you groveling skills, you are forced to preform a larger sacrifice",
                        GlobalsScript.Traits.Survival,
                        9,
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
                new CardChoice[] {new CardChoice ("AGILITY - You hold a race to win over the womens affections.(10)",
                    "The women are impressed with the agile prowess of the men, everyone has a great time.",
                    "Many of the men break their legs while racing, the women laugh and some leave the tribe.",
					//win effect,
					GlobalsScript.Traits.Agility,
                    10,
                    new Effect[]{
                        new Effect(3, GlobalsScript.Resources.People)
                    },
					//lose effects
					new Effect[]{
                        new Effect(-1, GlobalsScript.Resources.People)
                    }
                ),

					//choice 2
					new CardChoice ("STRENGTH - You decide to have the men do a log lifting tournament.(10)",
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
					new CardChoice ("SURVIVAL - Its decided to hold a hunt for the Silver Stag.(10)",
                        "The silver stag got away, but the hunters brought in a lot of food.",
                        "The hunt turns into the great farce, some people are killed and others wander away.",
                        GlobalsScript.Traits.Survival,
                        10,
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
	

		//add eighth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 8----------------------------------------------------------------------------------------------------------------------------------------
		//Traders arrive------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Traders",
				"A caravan arrives, offering goods to your village.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You negotiate with the traders for a good deal(7)",
					"Your bargaining pays off, giving some food for supplies",
					"You didn't convince them, but still get something for your food",
					//win effect,
					GlobalsScript.Traits.Trust,
					7,
					new Effect[]{
						new Effect(2, GlobalsScript.Resources.Wood),
						new Effect (1, GlobalsScript.Resources.Stone),
						new Effect (-3, GlobalsScript.Resources.Food),
					},
					//lose effects
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("STRENGTH - You show power and try to convince the caravan they need you(10)",
						"In a marvellous display, you convince them",
						"Failing to lift anything, they laugh at you",
						GlobalsScript.Traits.Strength,
						10,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength)}

					),

					//choice 3
					new CardChoice ("AGILITY - You attempt to steal from the traders(12)",
						"You succeed, grabbing supplies",
						"They spot you, making sure others know you are not to be trusted",
						GlobalsScript.Traits.Agility,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Resources.People),
							new Effect(1, GlobalsScript.Resources.Stone)
						},
						//lose effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Notoriety)
						})


				}
			)
			//end of enqueue card 8
		);

		//add ninth card------------------------------------------------------------------------------------------------------------------------
		//CARD 9--------------------------------------------------------------------------------------------------------------------------------
		//Poachers------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Poachers",
				"Poachers begin hunting prey on your land",

				//choice 1
				new CardChoice[] {new CardChoice ("NOTORIETY - You attempt to scare them away(8)",
					"The hunters run in fears",
					"You aren't more scary than they are hungry",
					//win effect,
					GlobalsScript.Traits.Notoriety,
					8,
					new Effect[]{
						new Effect (1, GlobalsScript.Resources.Food),
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("TRUST - You attempt to set up a deal(8)",
						"The poachers agree to your terms",
						"You attempt reason, but the poachers are too savage and attack",
						GlobalsScript.Traits.Trust,
						8,
						//win effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Resources.Food),
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Traits.Trust),
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Resources.People)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You attack to remove them all(8)",
						"With the hunters dead, you take their resources",
						"You aren't as skilled as you think, and they kill your party",
						GlobalsScript.Traits.Survival,
						8,
						//win effects
						new Effect[]{
							new Effect (2, GlobalsScript.Resources.Food),
							new Effect (1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
						})


				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 10--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					10,
					new Effect[]{
						new Effect(0, GlobalsScript.Resources.People)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 10
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 11--------------------------------------------------------------------------------------------------------------------------------------
		//Severe Thunderstorm------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Severe Thunderstorm",
				"A raging thunderstorm sweeps through your settlement, panicking your settlers",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - Calm your villagers by convincing them the thunder can't harm them(6)",
					"Everyone listens and waits out the storm",
					"Your villagers panick and run, getting struck by lightning",
					//win effect,
					GlobalsScript.Traits.Trust,
					6,
					new Effect[]{
						new Effect (1, GlobalsScript.Traits.Trust)
					},
					//lose effects
					new Effect[]{
						new Effect (-1, GlobalsScript.Resources.People),
						new Effect (-1, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - Construct a stone shelter to protect them(11)",
						"The shelter is completed and the villagers thank you for the safety",
						"The incomplete shelter provides no protection and collapses",
						GlobalsScript.Traits.Survival,
						11,
						//win effect
						new Effect[]{ 
							new Effect (1, GlobalsScript.Traits.Trust),
							new Effect (1, GlobalsScript.Traits.Survival)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Stone),
							new Effect (-1, GlobalsScript.Traits.Trust)}

					),

					//choice 3
					new CardChoice ("NOTORIETY - Intimidate your villagers into being orderly(9)",
						"Your villagers wait out the storm and see you as a more fearsome leader",
						"Your villagers become more frenzied and panic, taking resources",
						GlobalsScript.Traits.Notoriety,
						9,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect (-1, GlobalsScript.Resources.Wood),
							new Effect (-1, GlobalsScript.Resources.Stone),
							new Effect (-2, GlobalsScript.Resources.Food)
						})
				}
			)
			//end of enqueue card 11
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 12--------------------------------------------------------------------------------------------------------------------------------------
		//Tornado------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Tornado",
				"A tornado sweeps through your settlement",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(7)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and get hit",
					//win effect,
					GlobalsScript.Traits.Agility,
					7,
					new Effect[]{
						new Effect(0, GlobalsScript.Resources.People)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect (-1, GlobalsScript.Resources.Stone),
						new Effect (-1, GlobalsScript.Resources.Wood)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Yell at it till it goes away(12)",
						"The tornado diverts its path",
						"Tornados don't listen to mortals. It hits you",
						GlobalsScript.Traits.Notoriety,
						12,
						//win effect
						new Effect[]{ 
							new Effect(3, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, GlobalsScript.Resources.Food),
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Stone),
							new Effect(-1, GlobalsScript.Traits.Notoriety)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - Dig bunkers for everyone(7)",
						"Everyone is safe in their own bunkers, reassuring their trust in you",
						"Not everyone makes bunkers in time, and some are blown away",
						GlobalsScript.Traits.Survival,
						7,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Traits.Trust)
						})
				}
			)
			//end of enqueue card 12
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 13--------------------------------------------------------------------------------------------------------------------------------------
		//Severe Flooding------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Flood",
				"Heavy rainstorms have caused the river to overflow",

				//choice 1
				new CardChoice[] {new CardChoice ("SURVIVAL - Build a stone dam(10)",
					"The floods are successfully diverted",
					"The wall breaks when water meet brick, washing away your resources",
					//win effect,
					GlobalsScript.Traits.Survival,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Resources.Stone)}
				),

					//choice 2
					new CardChoice ("STRENGTH - Build rafts of wood to ride it out(8)",
						"The rafts carry everyone safely",
						"Some of the rafts leak and break, losing resources",
						GlobalsScript.Traits.Strength,
						8,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.Wood),
							new Effect (-2, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("TRUST - Convince the nearby fairies to make a magic barrier(10)",
						"The fairies consent and divert the water, trading stone for guidance",
						"The fairies reject your request, and your village floods",
						GlobalsScript.Traits.Trust,
						10,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Traits.Trust),
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(-1, GlobalsScript.Resources.Stone)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.Food),
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Stone)
						})
				}
			)
			//end of enqueue card 13
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 14--------------------------------------------------------------------------------------------------------------------------------------
		//Poor Soil------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Poor Soil",
				"The soil has dried up and isn't sustainable",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - Dig irrigation trenches between the river and crops(10)",
					"The crops benefit from the irrigation",
					"The ditches aren't effective and the crops suffer",
					//win effect,
					GlobalsScript.Traits.Strength,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - Transplant the soil and fertilize it(9)",
						"The transplanted soil proves better than the original crop",
						"The transplanted soil doesn't take, reudcing the crops and your speed",
						GlobalsScript.Traits.Survival,
						9,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.Food)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Traits.Agility),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("TRUST - Convince the settlers to move the farms(8)",
						"The villagers agree and move. The new area yields better crops",
						"The villagers refuse and the crops decay further",
						GlobalsScript.Traits.Trust,
						8,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Survival),
							new Effect(1, GlobalsScript.Traits.Trust),
							new Effect(1, GlobalsScript.Resources.Food)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-3, GlobalsScript.Resources.Food)
						})
				}
			)
			//end of enqueue card 14
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 15--------------------------------------------------------------------------------------------------------------------------------------
		//What You Buyin'------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("What You Buyin'",
				"A man in a tattered black robe approaches, revealing cursed magical items",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You grab the axe, which jolts you with energy(8)",
					"You conquer the axe, gifted with a surge of strength",
					"The energy is too much, damaging your arms",
					//win effect,
					GlobalsScript.Traits.Strength,
					8,
					new Effect[]{
						new Effect(2, GlobalsScript.Traits.Strength)
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Traits.Strength)}
				),

					//choice 2
					new CardChoice ("AGILITY - You grab the boots, which flutter on your feet(8)",
						"The fluttering quickens, as you take toward the sky",
						"The fluttering is replaced with an explosion, damaging your feet",
						GlobalsScript.Traits.Agility,
						8,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Agility)
						},
						//lose effect
						new Effect[]{
							new Effect (-2, GlobalsScript.Traits.Agility)}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You snag the man's cloak, which swirls with darkness(8)",
						"The darkness creates a shroud of fear around you",
						"The darkness begins to dance and scare you",
						GlobalsScript.Traits.Notoriety,
						8,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Traits.Notoriety)
						})
				}
			)
			//end of enqueue card 15
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 16--------------------------------------------------------------------------------------------------------------------------------------
		//King of Plebeians------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("King of Plebeians",
				"A representative of the people lets you know that your villagers are unhappy with you",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You run away from the representative",
					"You escape the man, but word travels faster than you do",
					"Surprisingly, he is much faster and trips you mid-stride",
					//win effect,
					GlobalsScript.Traits.Agility,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Agility),
						new Effect(-2, GlobalsScript.Resources.People)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Traits.Agility)}
				),

					//choice 2
					new CardChoice ("TRUST - Reassure him and the people of your ability to lead with a speech",
						"Your speech moves them. The village works twice as hard to help the people",
						"Your voice falters, convincing the people you cannot protect your resources",
						GlobalsScript.Traits.Trust,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Resources.Stone),
							new Effect(2, GlobalsScript.Resources.Wood),
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.Food),
							new Effect (-1, GlobalsScript.Resources.Stone),
							new Effect (-1, GlobalsScript.Resources.Wood)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You intimidate the man to scare them back into their place",
						"Your voice shakens him, and the people avoid your gaze in the streets",
						"Your threats only madden the man as he swings at you",
						GlobalsScript.Traits.Notoriety,
						14,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Resources.Stone),
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(2, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Strength)
						})
				}
			)
			//end of enqueue card 16
		);

		//add twenty-fourth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 24--------------------------------------------------------------------------------------------------------------------------------------
		//Hercules------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Hercules",
				"A mythic hero visits your village and challenges you to a friendly competition",

				//choice 1
				new CardChoice[] {new CardChoice ("SURVIVAL - A battle of wits, as you play a game against him",
					"You win and Hercules gives you insight and rewards",
					"You lose, learning a lesson but giving Hercules his reward",
					//win effect,
					GlobalsScript.Traits.Survival,
					8,
					new Effect[]{
						new Effect(2, GlobalsScript.Traits.Survival),
						new Effect(1, GlobalsScript.Resources.Food),
						new Effect(1, GlobalsScript.Resources.Stone),
						new Effect(1, GlobalsScript.Resources.Wood)
					},
					//lose effects
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Survival),
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Wood)
						}
				),

					//choice 2
					new CardChoice ("AGILITY - A race across the to the fields and back",
						"Your speed was obvious from the beginning, and Hecules recognizes this with food",
						"His speed surprises you, and you also trample some of the crops as well",
						GlobalsScript.Traits.Agility,
						9,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Agility),
							new Effect(3, GlobalsScript.Resources.Food),
						},
						//lose effect
						new Effect[]{
							new Effect (-5, GlobalsScript.Resources.Food),
						}

					),

					//choice 3
					new CardChoice ("STRENGTH - You plan to beat the hero at his greatest with wrestling",
						"In a surprise to all, you beat Hercules, attracting people to your village",
						"Hercules easily throws you to the ground, breaking your arm and your ego",
						GlobalsScript.Traits.Strength,
						11,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Traits.Strength),
							new Effect(3, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Trust)
						})
				}
			)
			//end of enqueue card 24
		);

		//add twenty-fifth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 25--------------------------------------------------------------------------------------------------------------------------------------
		//Ominous Vision------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Ominous Vision",
				"A horrible dream predicts the dangers to come. You must ready your village",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - Talk to the villages about growing resources",
					"Your plan works, bolstering your resources",
					"Unfortunately, the land becomes barren at your attempts",
					//win effect,
					GlobalsScript.Traits.Trust,
					6,
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Food),
						new Effect(1, GlobalsScript.Resources.Stone),
						new Effect(1, GlobalsScript.Resources.Wood)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Wood)
					}
				),

					//choice 2
					new CardChoice ("TRUST - You train the younglings in your village",
						"They begin to become as beneficial as the adults, gaining more people and resources",
						"Unfortunately the younglings are stubborn, and only prank you",
						GlobalsScript.Traits.Trust,
						8,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People),
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Resources.Stone),
							new Effect(1, GlobalsScript.Resources.Wood)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Trust)
						}

					),

					//choice 3
					new CardChoice ("TRUST - You rally your people to reinforce the village and themselves",
						"Your people rally, inspired by your charisma and leadership",
						"Your people think you are paranoid, and ignore you",
						GlobalsScript.Traits.Trust,
						10,
						//win effects
						new Effect[]{
							new Effect(3, GlobalsScript.Resources.People),
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Resources.Stone),
							new Effect(2, GlobalsScript.Resources.Wood)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Traits.Trust)
						})
				}
			)
			//end of enqueue card 25
		);

		//-------------------------------------------------------------------------------------------------------------------------------
		//--------------------------------------------------------------------------------------------------------------------------------------
		//BOULDER------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Boulder",
				"On a walk around the hills, a boulder comes tumbling down towards you",

				//choice 1
				new CardChoice[] {new CardChoice ("SURVIVAL - You see a dip in the earth and dodge into it",
					"You make it, avoiding the boulder as it crashes and creates smaller rock",
					"You barely make it as the boulder hits your leg",
					//win effect,
					GlobalsScript.Traits.Survival,
					7,
					new Effect[]{
						new Effect(3, GlobalsScript.Resources.Stone)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Traits.Survival),
						new Effect(-1, GlobalsScript.Traits.Agility)
					}
				),

					//choice 2
					new CardChoice ("AGILITY - You attempt to outrun the boulder (why not?)",
						"Surprisingly, you make it. And feel faster than before",
						"You could have moved left or right. In that, your left and right legs are crushed",
						GlobalsScript.Traits.Agility,
						10,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Agility)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, GlobalsScript.Traits.Agility)
						}

					),

					//choice 3
					new CardChoice ("STRENGTH - There's no time; You'll have to push the boulder away",
						"Your strength pulls through and becomes legend to your village",
						"Boulder wins. You are crushed, hurting your strength and speed",
						GlobalsScript.Traits.Strength,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(2, GlobalsScript.Traits.Trust),
							new Effect(3, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Traits.Strength),
							new Effect(-2, GlobalsScript.Traits.Agility)
						})
				}
			)
			//end of enqueue card
		);

		//-------------------------------------------------------------------------------------------------------------------------------
		//--------------------------------------------------------------------------------------------------------------------------------------
		//STAMPEDE------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Stampede",
				"The livestock of your farms get loose, threatening your village",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You move quickly to recapture and subdue all animals",
					"Your speed is faster than any animal, and capture more animals than you remember",
					"Unfortunately you aren't as fast as you think, and they trample the crops",
					//win effect,
					GlobalsScript.Traits.Agility,
					8,
					new Effect[]{
						new Effect(5, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-3, GlobalsScript.Resources.Food)
					}
				),

					//choice 2
					new CardChoice ("TRUST - You know these animals, and attempt to calm them",
						"You calm them, and your animal magnetism attracts animals and villagers",
						"You cannot calm them, and they trample you",
						GlobalsScript.Traits.Trust,
						10,
						//win effect
						new Effect[]{ 
							new Effect(3, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Trust),
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Traits.Agility)
						}

					),

					//choice 3
					new CardChoice ("SURVIVAL - Through traps and wit, you try to capture them all",
						"Your traps not only capture the animals, but increase your protection",
						"Your traps aren't placed well, and end up hurting your villagers",
						GlobalsScript.Traits.Survival,
						11,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Traits.Notoriety),
							new Effect(1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-2, GlobalsScript.Traits.Trust)
						})
				}
			)
			//end of enqueue card
		);

	}

    #endregion

    //void Update()
    //{
    //    if (delete)
    //    {
    //        deleteTimer++;
    //    }
    //    if (deleteTimer >= 3000)
    //    {
    //        delete = false;
    //        deleteTimer = 0;
    //        Object.Destroy(currCard);
    //    }
    //}

    //removed card from the deck
    public Card Dequeue()
	{
		//dequeue the card from the top of the deck
		return deck.Dequeue ();
	}

    /// <summary>
    /// Shuffles the deck so that cards are randomly organized
    /// </summary>
    public void Shuffle()
    {
        // Creates a temporary list from which cards will be randomly pulled
        List<Card> tempDeck = new List<Card>();

        // Establishes size of deck before cards are dequeued from it
        int tempCount = deck.Count;

        // Transfers every card from the deck to the temporary list
        for (int i = 0; i < tempCount; i++)
        {
            tempDeck.Add(deck.Dequeue());
        }

        // Randomly chooses cards from the temporary list and adds them back to the deck.
        // By doing so in a random order, this simulates shuffling.
        for (int j = 0; j < tempCount; j++)
        {
            deck.Enqueue(tempDeck[Random.Range(0, tempDeck.Count)]);
        }
    }

    public void DrawCard()
    {
        currCard = MonoBehaviour.Instantiate(cardPrefab, MonoBehaviour.FindObjectOfType<Canvas>().transform);
    }

    public void RemoveCard()
    {
        //delete = true;
        Object.Destroy(currCard);
    }

}