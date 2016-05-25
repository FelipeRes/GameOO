using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Character character;
	public Animator anim;
	public Transform GroundCheck1;
	public LayerMask groundLayer; 
	public Transform armaPosition;
	public float razaoVida;

	public RectTransform barraDeVida;

	private bool isGrounded;
	private bool isWait;
	public bool OnRight;

	void Start () {
		character.arma.character = character;
	}

	void Update () {
		razaoVida = character.vidaDoPlayer / character.vida;
		Vector2 barra = new Vector2 ();
		barra.x = razaoVida;
		barra.y = 1;
		barraDeVida.anchorMax = barra;
		isGrounded = Physics2D.OverlapCircle (GroundCheck1.position, 0.15f, groundLayer);
		if (isWait == false) {
			if (isGrounded == true) {
				anim.SetBool ("isGrounded", true);
				if (Input.GetKeyDown (KeyCode.Space)) {
					this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 300));
					anim.Play ("ShanoaJump");
				}
				if (Input.GetKeyDown (KeyCode.O)) {
					autoDano ();
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
				OnRight = true;
			} else if (Input.GetAxis ("Horizontal") < 0) {
				this.transform.Translate (new Vector2 (-1 * Time.deltaTime * character.velocidade, 0));
				this.transform.localScale = new Vector2 (-1, 1);
				anim.SetBool ("isRunning", true);
				OnRight = false;
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
		if (!OnRight) {
			arma.transform.localScale = new Vector2 (-1, 1);
		}
		Destroy (arma, 0.3f);
	}

	public void autoDano(){
		character.AdicionarDano (3);
	}
}
