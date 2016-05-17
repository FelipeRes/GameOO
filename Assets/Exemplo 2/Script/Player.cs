using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Character character;
	public Animator anim;
	private Rigidbody2D rigidbody;
	private bool rightDirection;
	private bool isWait; 
	private bool canFlip;

	public bool isGrounded = false;
	public Transform GroundCheck1; // Put the prefab of the ground here
	public LayerMask groundLayer; // Insert the layer here.

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (!isWait) {
			isGrounded = Physics2D.OverlapCircle (GroundCheck1.position, 0.15f, groundLayer);
			if (isGrounded) {
				canFlip = true;
				if (Input.GetKeyDown (KeyCode.P)) {
					this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 300));
					anim.Play ("ShanoaJump");
				}
				if (Input.GetKeyDown (KeyCode.O)) {
					Wait (0.4f);
					if (Input.GetAxis ("Vertical") < 0) {
						anim.Play ("ShanoaAtackCrounch");
					} else {
						anim.Play ("ShanoaAtacando");
					}
				}
				if (Input.GetAxis ("Vertical") < 0) {
					anim.SetBool ("isCrounch", true);
				} else {
					anim.SetBool ("isCrounch", false);
				}
			} else {
				if (Input.GetKeyDown (KeyCode.O)) {
					canFlip = false;
					anim.Play ("ShanoaAtacandoAr");
				}
			}
			anim.SetBool ("isGrounded", isGrounded);
			if (Input.GetAxis ("Horizontal") > 0) {
				this.transform.Translate (1 * Time.deltaTime * character.velocidade, 0, 0);
				if (canFlip) {
					this.transform.localScale = new Vector2 (1, 1);
				}
				anim.SetBool ("isRunning", true);
				if (rightDirection == false && isGrounded) {
					rightDirection = true;
					anim.Play ("ShanoaFlip");
				}
			} else if (Input.GetAxis ("Horizontal") < 0) {
				this.transform.Translate (-1 * Time.deltaTime * character.velocidade, 0, 0);
				if (canFlip) {
					this.transform.localScale = new Vector2 (-1, 1);
				}
				anim.SetBool ("isRunning", true);
				if (rightDirection == true && isGrounded) {
					rightDirection = false;
					anim.Play ("ShanoaFlip");
				}
			} else {
				anim.SetBool ("isRunning", false);
			}
		}
	}

	public void Wait(float time){
		isWait = true;
		Invoke ("Return", time);
	}
	public void Return(){
		isWait = false;
	}
}