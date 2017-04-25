using UnityEngine;
using System.Collections;

public class Attack : BaseAbilities {

	public Attack() {
	
		AbilityName = "Normal Attack";
		AbilityDescription = "A normal attack";
		AbilityID = 1;
		AbilityPower = 10;
		AbilityCost = 5;
	}
}
