using UnityEngine;
using System.Collections;

public class Arco : Arma {
	void Start(){
		GameObject flecha = Instantiate (character.flechaObject, this.transform.position, Quaternion.identity) as GameObject;
		if (character.gameObject.GetComponentInParent<PlayerMove> ().OnRight) {
			flecha.GetComponent<Rigidbody2D> ().AddForce (new Vector2(500, 0));
		} else {
			flecha.GetComponent<Rigidbody2D> ().AddForce (new Vector2(-500, 0));
			flecha.transform.localScale = new Vector2 (-1, 1);
		}
		flecha.GetComponent<Flecha> ().dano += dano;
	}
	override public int calculaDano(){
		return dano;
		// aqui retorna o dano da arma
	}
		
}
