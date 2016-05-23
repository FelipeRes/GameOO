using UnityEngine;
using System.Collections;

public class Inimigo : Creature {

	public TipoInimigo tipo;
	public Elemento elemento;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void adicionarDano(int dano){
		Debug.Log ("Vida = " + vida + " Dano = " + dano);
		vida -= dano;
		if (vida < 0) {
			Destroy (this.gameObject);
		}
	}
}
