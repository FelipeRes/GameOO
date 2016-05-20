using UnityEngine;
using System.Collections;

public class Espada : Arma {

	override public int calculaDano(){
		return dano;
		// aqui retorna o dano da arma
	}

	public void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.GetComponent<Inimigo> () != null) {
			int danoNoInimigo = 0;
			danoNoInimigo = dano - coll.gameObject.GetComponent<Inimigo> ().defesaFisica;
			if (coll.gameObject.GetComponent<Inimigo> ().tipo == TipoInimigo.Zumbi) {
				danoNoInimigo += danoNoInimigo;
			}
			coll.gameObject.GetComponent<Inimigo> ().adicionarDano (danoNoInimigo);
		}
	}
}
