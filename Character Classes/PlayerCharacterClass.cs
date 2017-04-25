using UnityEngine;
using System.Collections;

public class PlayerCharacterClass : BaseCharacterClass {

	public PlayerCharacterClass() {
	
		CharacterClassName = "Rin";
		CharacterClassDescription = "The main character.";
		
		// set fixed attr9ibutes
		Health = 50;
		Attack = 12;
		Defense = 14;
		Magic = 13;
		
	}
}
