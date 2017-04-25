using UnityEngine;
using System.Collections;

public class BattleCalculations {

private int abilityPower;
private int totalAbilityPowerDamage;
private int totalUsedAbilityDamage;

	public int CalculateUsedPlayerAbilityDamage(BaseAbilities usedAbility) {
		Debug.Log ("Used ability: " + usedAbility.AbilityName);
		// TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
		totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
		
		
		
		return totalUsedAbilityDamage;
	//	Debug.Log (totalUsedAbilityDamage);
		
		// move damage + critical strike
			
	}
	
	private int CalculateAbilityDamage(BaseAbilities usedAbility) {
		abilityPower = usedAbility.AbilityPower; // retrieves number of ability power
		totalAbilityPowerDamage = abilityPower - 50;
		return totalAbilityPowerDamage;
	
	}
}