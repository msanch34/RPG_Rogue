using UnityEngine;
using System.Collections;

public class BattleStateStart  {

	private BasePlayer newEnemy = new BasePlayer();
	
	public void PrepareBattle() {
	
	
}

	private void CreateNewEnemy() {
		newEnemy.PlayerName = "Bad dude.";
		newEnemy.PlayerLevel = 4;
		
		newEnemy.Health = 50;
		newEnemy.Stamina = 10;
		newEnemy.Endurance = 10;
		newEnemy.Intellect = 10;
		newEnemy.Strength = 10;

	}	
	
	public int EnemyDamage(int damage) {
		
		newEnemy.Health = newEnemy.Health - damage;
		
		return newEnemy.Health;
	}
	
	public int EnemyHealth() {
		return newEnemy.Health;
	
	}
}
