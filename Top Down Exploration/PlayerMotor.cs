using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerMotor : MonoBehaviour {

	public float _Speed = 2;
	
	public int randomBattle = 1;
	
	
	TurnBasedCombatStateMachine startGame = new TurnBasedCombatStateMachine();
	
	
	[SerializeField]
	private Vector2 _DeltaForce;
	private Rigidbody2D _RGB;
	private Animator _Anim;
	private BoxCollider2D _BoxCollider;
	
	void Awake() {
	
		_Anim = GetComponent<Animator>();
		_RGB = GetComponent<Rigidbody2D>();
		_BoxCollider = GetComponent<BoxCollider2D>();
	}
	
	// Use this for initialization
	void Start () {
	
		_RGB.gravityScale = 0;
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	CheckInput ();
	
	randomBattle = randomBattle + 1;
	
	if(randomBattle == 300) {

            enterBattle();
           
            resumeGame();
            
	    }

        Time.timeScale = 1;

    }
	
	void CheckInput() {
		
		var _H = Input.GetAxisRaw("Horizontal");
		var _V = Input.GetAxisRaw("Vertical");
		
		_DeltaForce = new Vector2(_H,_V);
		CalculateMovement(_DeltaForce * _Speed);
	}
	
	void CalculateMovement(Vector2 _PlayerForce) {
	
		_RGB.velocity = Vector2.zero;
		_RGB.AddForce (_PlayerForce,ForceMode2D.Impulse);
	
	}
	
	public void enterBattle() {
        Time.timeScale = 0;
        SceneManager.LoadScene("TurnBasedBattle", LoadSceneMode.Additive);
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        //SceneManager.UnloadScene("Exploration");

    }
}
