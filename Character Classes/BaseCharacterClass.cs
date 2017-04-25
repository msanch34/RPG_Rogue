using UnityEngine;
using System.Collections;

/*
Base stats for classes, makes getters and setters for each value when called

*/

public class BaseCharacterClass {

	private string characterClassName;
	private string characterClassDescription;
	
	// Stats
	private int health;
	private int attack;
	private int defense;
	private int magic;
	
	//private int stamina;
	//private int endurance;
	//private int strength;
	//private int intellect;
	
	public string CharacterClassName {
		get{return characterClassName;}
		set{characterClassName = value;}
		}
	public string CharacterClassDescription {
		get{return characterClassDescription;}
		set{characterClassDescription = value;}
	}
	public int Health {
		get{return health;}
		set{health = value;}
		}
	public int Attack {
		get{return attack;}
		set{attack = value;}
	}
	public int Defense {
		get{return defense;}
		set{defense = value;}
	}
	public int Magic {
		get{return magic;}
		set{magic = value;}
	}
	
}
