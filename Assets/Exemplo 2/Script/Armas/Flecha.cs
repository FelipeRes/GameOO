using UnityEngine;
using System.Collections;

public class Flecha : Arma {

	public Elemento elemento;

	void Start(){

	}
	override public int calculaDano(){
		return dano;
		// aqui retorna o dano da arma
	}

	public void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.GetComponent<InimigoMain> () != null) {
			int danoNoInimigo = 0;
			danoNoInimigo = dano - coll.gameObject.GetComponent<InimigoMain> ().inimigo.defesaFisica;
			if(ProcessoDeElementos.elementoMaisForte(elemento,coll.gameObject.GetComponent<Inimigo> ().elemento)){
				danoNoInimigo += danoNoInimigo;
			}
			coll.gameObject.GetComponent<InimigoMain> ().inimigo.AdicionarDano (danoNoInimigo);
		}
		Destroy (this.gameObject);
	}
}
