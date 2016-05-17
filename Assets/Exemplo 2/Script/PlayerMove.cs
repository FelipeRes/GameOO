using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Character character;
	public Animator anim;
	private bool isGrounded;
	public Transform GroundCheck1;
	public LayerMask groundLayer; 

	void Start () {
	
	}

	void Update () {
		isGrounded = Physics2D.OverlapCircle (GroundCheck1.position, 0.15f, groundLayer);
		if (isGrounded == true) {
			anim.SetBool ("isGrounded", true);
			if (Input.GetKeyDown (KeyCode.Space)) {
				this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 300));
				anim.Play ("ShanoaJump");
			}
		} else {
			anim.SetBool ("isGrounded", false);
		}
		if (Input.GetAxis ("Horizontal") > 0) {
			this.transform.Translate (new Vector2 (1 * Time.deltaTime*character.velocidade, 0));
			this.transform.localScale = new Vector2 (1, 1);
			anim.SetBool ("isRunning", true);
		} else if (Input.GetAxis ("Horizontal") < 0) {
			this.transform.Translate (new Vector2 (-1 * Time.deltaTime*character.velocidade, 0));
			this.transform.localScale = new Vector2 (-1, 1);
			anim.SetBool ("isRunning", true);
		} else {
			anim.SetBool ("isRunning", false);
		}

	
	}
}
