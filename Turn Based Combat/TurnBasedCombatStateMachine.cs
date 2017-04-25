using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	public BattleStateStart battleStateStartScript = new BattleStateStart();
	
	public static BaseAbilities playerAbility;
	private BattleCalculations battleCalcScript = new BattleCalculations();
	
	int damage;
	string damage_text;
	int damage_caused;
	public Texture tex;
	public enum BattleStates {
	
		START,
		PLAYERCHOICE,
		PLAYERANIMATE, // state changes to animation
		ENEMYCHOICE,
		CALCDAMAGE,
		CALCENEMYDAMAGE,
		LOSE,
		WIN
	
	}
	
	public static BattleStates currentState;
	
	// Use this for initialization
	void Start () {
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
	Debug.Log (currentState);
		switch(currentState) {
		
			case(BattleStates.START):
			// SETUP BATTLE FUNCTION
			// battle begins
			// create enemy
			
			battleStateStartScript.PrepareBattle();
				break;
			case(BattleStates.PLAYERCHOICE):
			
				break;
			case(BattleStates.ENEMYCHOICE):
				//coded ai goes here
				break;
			case(BattleStates.CALCDAMAGE):
				damage = battleCalcScript.CalculateUsedPlayerAbilityDamage(playerAbility);
				Debug.Log ("CALCULATING DAMAGE");
				Debug.Log (damage);
				
				damage_caused = battleStateStartScript.EnemyDamage(damage);
				//damage_text = damage.ToString();
				
				
				//GUI.Label(damage_text);
				//GUILayout.Label (damage_text);
				//GUILayout.Text(battleStateStartScript.EnemyDamage(damage));
				//GUILayout.Label (damage);
				//GUILayout.Label (battleStateStartScript.EnemyDamage(damage).ToString);
				
				// TRYING TO PRINT OUT RESULTS OF DAMAGE
			//GUI.Label(new Rect(Screen.width - 250,Screen.height - 50,100,30), damage.ToString);
				
				
				currentState = BattleStates.ENEMYCHOICE;
				
			//coded ai goes here
				break;
			case(BattleStates.CALCENEMYDAMAGE):
			
				currentState = BattleStates.PLAYERCHOICE;
			
				break;
			case(BattleStates.LOSE):
                //Application.Quit();
                break;
			case(BattleStates.WIN):
                //Application.Quit();
                break;
	}
	}
	
	void OnGUI(){
		//GUILayout.Label(battleStateStartScript.EnemyHealth().ToString());
		//GUILayout.Label ("Damage caused by ability: " + damage.ToString ());
		//GUILayout.Label ("Enemy HP left: " + damage_caused.ToString ());
		//battleStateStartScript.EnemyDamage
		
		//GUILayout.Label ("Player Choice");
		//GUILayout.Button ("BEGIN BATTLE", GUILayout.Width(600);
		if(GUILayout.Button ("BEGIN BATTLE", GUILayout.Width(600))){
			if(currentState == BattleStates.START) {
				
				currentState = BattleStates.PLAYERCHOICE;
				
			}else if(currentState == BattleStates.PLAYERCHOICE) {
				
				//GUILayout.Label (damage_text);
				currentState = BattleStates.CALCDAMAGE;
				
				//GUILayout.Label (damage_text);
			}
			else if(currentState == BattleStates.CALCDAMAGE) {
				currentState = BattleStates.ENEMYCHOICE;
			}
			else if(currentState == BattleStates.ENEMYCHOICE) {
				//GUILayout.Label(tex);
				//GUILayout.Label (damage.ToString, 
				//GUI.Label(new Rect(10, 10, 100, 20), damage_text);
				//GUILayout.Label (damage.ToString);
				//GUILayout.Label (battleStateStartScript.EnemyDamage(damage).ToString);
				//GUILayout.Label (damage_text);
				currentState = BattleStates.PLAYERCHOICE;
			}
			else if(currentState == BattleStates.CALCENEMYDAMAGE) {
				currentState = BattleStates.PLAYERCHOICE;
			}
			else if(currentState == BattleStates.LOSE) {
               // Application.Quit();
                currentState = BattleStates.WIN;
			}
			if(currentState == BattleStates.WIN) {
                
                
                currentState = BattleStates.START;
			}
		}
	}
}
