using UnityEngine;
using System.Collections;

public class InimigoMain : MonoBehaviour {

	public Inimigo inimigo;
	public PlayerMove player;
	public Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			anim.SetBool ("Perseguindo", true);
			if (player.gameObject.transform.position.x < this.transform.position.x) {
				this.transform.localScale = new Vector2 (1, 1);
				this.GetComponent<Rigidbody2D> ().isKinematic = true;
			} else {
				this.transform.localScale = new Vector2 (-1, 1);
				this.GetComponent<Rigidbody2D> ().isKinematic = true;
			}
		} else {
			anim.SetBool ("Perseguindo", false);
		}

	}

	public void OnTriggerEnter2D(Collider2D coll){
		Debug.Log ("oi");
		if (coll.gameObject.GetComponent<PlayerMove> () != null) {
			coll.gameObject.GetComponent<PlayerMove> ().character.AdicionarDano (inimigo.forcaFisica);
			player = coll.gameObject.GetComponent<PlayerMove> ();
		}
	}


}
