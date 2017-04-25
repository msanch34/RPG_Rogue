using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	// declare two new player objects of the characters adolfo and kazumi
	private BaseCharacterClass adolfo = new PlayerCharacterClass{};
	
	//public TextMesh text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
	
	/*
		// print attriibutes, first adolfos, then kazumi's
		GUILayout.Label (adolfo.CharacterClassName);
		GUILayout.Label (adolfo.CharacterClassDescription);
		GUILayout.Label ("Adolfo's Attributes:");
		
		GUILayout.Label("STR: " + adolfo.Strength.ToString());
		GUILayout.Label("END: " + adolfo.Endurance.ToString());
		GUILayout.Label("STA: " + adolfo.Stamina.ToString());
		GUILayout.Label("INT: " + adolfo.Intellect.ToString());
		
		GUILayout.Label (kazumi.CharacterClassName);
		GUILayout.Label (kazumi.CharacterClassDescription);
		GUILayout.Label ("Kazumi's Attributes:");
		*/
	
	}
}