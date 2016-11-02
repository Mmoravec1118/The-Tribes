using UnityEngine;
using System.Collections;

public class PreperationScript : MonoBehaviour {

	public enum GameState {PreperationState, CardState, EndState};


	GameState gameState = GameState.CardState ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CardMethod ()
	{

		if (gameState == GameState.CardState) {
			Debug.Log("Pressed");
		}


	}
		
}
