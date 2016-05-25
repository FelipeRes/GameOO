using UnityEngine;
using System.Collections;

public class Espada : Arma {

	public Elemento elemnto;
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
			if(ProcessoDeElementos.elementoMaisForte(elemnto,coll.gameObject.GetComponent<Inimigo> ().elemento)){
				danoNoInimigo += danoNoInimigo / 100 * 20;
			}
			coll.gameObject.GetComponent<InimigoMain> ().inimigo.AdicionarDano (danoNoInimigo);
		}
	}
}
