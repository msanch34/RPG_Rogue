using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int health;
	
	private int stamina;
	private int endurance;
	private int strength;
	private int intellect;
	
	public string PlayerName {
		get{return playerName;}
		set{playerName = value;}
	}
	public int Health {
		get{return health;}
		set{health = value;}
	}
	public int PlayerLevel {
		get{return playerLevel;}
		set{playerLevel = value;}
	}
	public int Stamina {
		get{return stamina;}
		set{stamina = value;}
	}
	public int Endurance {
		get{return endurance;}
		set{endurance = value;}
	}
	public int Strength {
		get{return strength;}
		set{strength = value;}
	}
	public int Intellect {
		get{return intellect;}
		set{intellect = value;}
	}
	
	
}
