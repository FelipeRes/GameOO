using UnityEngine;
using System.Collections;

public class Inimigo : Creature {

	public TipoInimigo tipo;
	public Elemento elemento;

	public void AdicionarDano(int dano){
		vida -= dano;
		if (vida <= 0) {
			Destroy (this.gameObject);
		}
	}
}
