using UnityEngine;
using System.Collections;

public class Character : Creature {

	public Profissao profissao;
	public Arma arma;
	public GameObject armaObject;
	public Flecha flecha;
	public GameObject flechaObject;
	public int mana;
	public int nivel;
	public float vidaDoPlayer;

	void Start(){
		vidaDoPlayer = vida;
	}

	public void AdicionarDano( int dano){
		Debug.Log (dano);
		vidaDoPlayer -= dano;
	}

}
