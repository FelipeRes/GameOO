using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

	public float peso;
	public int dano;
	public float tamanho;
	public string descricao;
	public float tempo;

	virtual public int calculaDano(){
		return dano;
		// aqui retorna o dano da arma
	}

}
