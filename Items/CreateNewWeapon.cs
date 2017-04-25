using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;
	
	// method for printing to console
	
	void Start() {
		CreateWeapon();
		Debug.Log ("WEAPON NAME: " + newWeapon.ItemName);
		Debug.Log ("DETAILS: " + newWeapon.ItemDescription);
		Debug.Log ("ITEM ID: " + newWeapon.ItemID.ToString ());
	    Debug.Log ("STR value: " + newWeapon.Strength);
	//	Debug.Log (newWeapon.ItemName);
	
	}
	
	public void CreateWeapon() {
	
		// FISTS,
		// KATANA,
		// BOMB,
		// GUN
		
		// crate a new weapon object
		// assign it to katana and fill in the details of the weapon
	
		newWeapon = new BaseWeapon();
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.KATANA;
		newWeapon.ItemName = "Katana.";
		newWeapon.ItemDescription = "A sword used by Samurai.";
		newWeapon.ItemID = 1;
		newWeapon.Strength = 15;
		
		// Make this weapon into a katana
		//newWeapon.WeaponType = BaseWeapon.WeaponTypes.KATANA;
		//newWeapon
		
	}	
	
}
