using UnityEngine;
using System.Collections;

public class Machado : Arma {

	virtual public int calculaDano(Inimigo inimigo){
		int d = dano;
		if (inimigo.tipo == TipoInimigo.Demonio) {
			d = dano /= 2;
		}
		return d;
		// aqui retorna o dano da arma
	}
	public void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.GetComponent<InimigoMain> () != null) {
			int danoNoInimigo = calculaDano(coll.gameObject.GetComponent<InimigoMain> ().inimigo);
			coll.gameObject.GetComponent<InimigoMain> ().inimigo.AdicionarDano (danoNoInimigo);
		}
	}
}
