using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BattleGUI : MonoBehaviour {

/*
	BattleGUI, sets up most of the game, hardcodes Players stats and enemy's health
	
	NOT USING BATTLE CALCULATIONS OR BATTLE STATE START AT THIS MOMENT, ALL THE CODE REQUIRED IS HERE.

*/

	PlayerCharacterClass mc = new PlayerCharacterClass();
	//string playerName = mc.CharacterClassName;
	 int playerLevel = 10;
	 int playerHealth = 100;
	 int playerEnergy = 50;
	 
	 int enemyHealth = 100;
	
	BaseAbilities skill = new BaseAbilities();
	
	Attack skill1 = new Attack();
	Magic skill2 = new Magic();
	int enemyDamage = 10;
	int leftOverHP;
	
//	PlayerCharacterClass mc = new PlayerCharacterClass();
	//enemyDamage = 10;
	
	//playerName = mc.CharacterClassName;
	//playerLevel = 10;
	//playerHealth = 100;
	//playerEnergy = 50;
	
	// Use this for initialization
	void Start () {
	
		// calls on adolfo
		//playerName = mc.CharacterClassName;
		//playerLevel = 10;
		//playerHealth = 100;
		//playerEnergy = 50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		// buttons, need buttons for player moves
		// need to show enemy health and enemy info
		// we need to show player info
		
		//GUILayout.Label( "Damage caused by enemy " + enemyDamage.ToString(), GUILayout.Width(600));
		GUILayout.Label( "HP remaining: " + playerHealth.ToString(), GUILayout.Width(600));
		GUILayout.Label( "ENEMY HP remaining: " + enemyHealth.ToString(), GUILayout.Width(700));
		
		// if player's health is 0 or drops before 0 calls instant game over, switches the state to LOSE
		if(playerHealth <= 0) {
		
		DisplayGameOver ();
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.LOSE;
		
		}
		
		// once enemy's health drops to 0 then enemy loses and state changes to WIN
		if(enemyHealth <= 0) {
		
		DisplayVictory();
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.WIN;
		
		}
		
		// if currenState is in playerchoice then show Attack or Magic abilities to player, once they have chosen 
		// a button it'll subtract it from enemy's health. State then changes to EnemyChoice who will attack
		if(TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE) {
			DisplayPlayerChoice();
			//GUILayout.Label( "Name: " + playerName.ToString(), GUILayout.Width(600));
			//GUILayout.Label( "Player Level: " + playerLevel.ToString (), GUILayout.Width(700));
			//GUILayout.Label( "Player Health: " + playerHealth.ToString(), GUILayout.Width(400));
			//GUILayout.Label( "Player Magic: " + playerEnergy.ToString(), GUILayout.Width(500));
			
		}
		
		// enemy will attack in this phase
		if(TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE) {
			//GUILayout.Label( "Damage caused by enemy " + enemyDamage.ToString(), GUILayout.Width(600));
			//GUILayout.Label( "HP remaining: " + leftOverHP.ToString(), GUILayout.Width(600));
			
			Debug.Log (playerHealth.ToString());
			DisplayEnemyChoice();
			//GUILayout.Label( "Name: " + playerName.ToString(), GUILayout.Width(600));
			//GUILayout.Label( "Player Level: " + playerLevel.ToString (), GUILayout.Width(700));
			//GUILayout.Label( "Player Health: " + playerHealth.ToString(), GUILayout.Width(400));
			//GUILayout.Label( "Player Magic: " + playerEnergy.ToString(), GUILayout.Width(500));
			
		}

        if(TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.WIN)
        {
            Time.timeScale = 0;
            if (GUI.Button(new Rect(0, 0, Screen.width * .6f, Screen.height * .12f), "End Battle"))
            {
                SceneManager.UnloadScene("TurnBasedBattle");
            }
        }
		//GUI.Button (new Rect(Screen.width - 200,Screen.height - 50,100,30), "Attack");
		//GUI.Button (new Rect(Screen.width - 100,Screen.height - 50,100,30), "Magic");
		
		
		
	}
	
	private void DisplayGameOver() {
		GUILayout.Label( "GAME OVER", GUILayout.Width(1000));
	}
	
	private void DisplayVictory() {
		GUILayout.Label( "VICTORY. GODS BE BLESSED.", GUILayout.Width(1000));
	}
	
	
	private void DisplayPlayerChoice() {
		
		if(GUI.Button (new Rect(Screen.width - 250,Screen.height - 50,100,30), "Attack")) {
			TurnBasedCombatStateMachine.playerAbility = skill1;
			enemyHealth = enemyHealth - skill1.AbilityPower;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCDAMAGE;
		}
		
		if(GUI.Button (new Rect(Screen.width - 150,Screen.height - 50,100,30), "Magic")) {
			TurnBasedCombatStateMachine.playerAbility = skill2;
			enemyHealth = enemyHealth - skill2.AbilityPower;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCDAMAGE;
		}
}
		
	private void DisplayEnemyChoice() {
	
		//enemyDamage = skill1.AbilityPower;
	
		
		//GUILayout.Label( "Damage caused by enemy " + enemyDamage.ToString(), GUILayout.Width(600));
		//GUILayout.Label( "HP remaining: " + leftOverHP.ToString(), GUILayout.Width(600));
		if(GUI.Button (new Rect(Screen.width - 150,Screen.height - 50,100,30), "End Turn")) {
			playerHealth =  playerHealth - enemyDamage;
			Debug.Log(leftOverHP.ToString());
			GUILayout.Label( "Damage caused by enemy " + enemyDamage.ToString(), GUILayout.Width(600));
			GUILayout.Label( "HP remaining: " + playerHealth.ToString(), GUILayout.Width(600));
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCENEMYDAMAGE;
		
		}
		}

}
