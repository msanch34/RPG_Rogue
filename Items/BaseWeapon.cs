using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem { // baseweapon inherts from basestatitem to base item

	public enum WeaponTypes {
	
		FISTS,
		KATANA,
		BOMB,
		GUN
	
	}
	
	private WeaponTypes weaponType;
	//private int Explosion;
	
	public WeaponTypes WeaponType {
		get{return weaponType;}
		set{weaponType = value;}
		}
		

}
