using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Character character;
	public Animator anim;
	public Transform GroundCheck1;
	public LayerMask groundLayer; 
	public Transform armaPosition;

	private bool isGrounded;
	private bool isWait;

	void Start () {
	
	}

	void Update () {
		isGrounded = Physics2D.OverlapCircle (GroundCheck1.position, 0.15f, groundLayer);
		if (isWait == false) {
			if (isGrounded == true) {
				anim.SetBool ("isGrounded", true);
				if (Input.GetKeyDown (KeyCode.Space)) {
					this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 300));
					anim.Play ("ShanoaJump");
				}
				if (Input.GetKeyDown (KeyCode.O)) {
					anim.Play ("ShanoaAtacando");
					Atack ();
					isWait = true;
					Invoke ("podeMover", character.arma.tempo);
				}
			} else {
				anim.SetBool ("isGrounded", false);
			}
			if (Input.GetAxis ("Horizontal") > 0) {
				this.transform.Translate (new Vector2 (1 * Time.deltaTime * character.velocidade, 0));
				this.transform.localScale = new Vector2 (1, 1);
				anim.SetBool ("isRunning", true);
			} else if (Input.GetAxis ("Horizontal") < 0) {
				this.transform.Translate (new Vector2 (-1 * Time.deltaTime * character.velocidade, 0));
				this.transform.localScale = new Vector2 (-1, 1);
				anim.SetBool ("isRunning", true);
			} else {
				anim.SetBool ("isRunning", false);
			}
		}

	
	}

	public void podeMover(){
		isWait = false;
	}

	public void Atack(){
		GameObject arma = Instantiate (character.armaObject, armaPosition.position, Quaternion.identity) as GameObject;
		if (this.transform.localScale.x < 0) {
			arma.transform.localScale = new Vector2 (-1, 1);
		}
		Destroy (arma, 0.3f);
	}
}
