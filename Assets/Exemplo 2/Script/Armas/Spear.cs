using UnityEngine;
using System.Collections;

public class Spear : Arma {

	override public int calculaDano(){
		return dano;
		// aqui retorna o dano da arma
	}

	public void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.GetComponent<Inimigo> () != null) {
			int danoNoInimigo = 0;
			danoNoInimigo = dano - coll.gameObject.GetComponent<Inimigo> ().defesaFisica;
			coll.gameObject.GetComponent<Inimigo> ().AdicionarDano (danoNoInimigo);
		}
	}
}
