using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

	public string nome;
	public float peso;
	public int dano;
	public float tamanho;
	public string descricao;
	public float tempo;
	public Character character;
	public Sprite imagem;
	public GameObject particula;

	virtual public int calculaDano(){
		return dano;
		// aqui retorna o dano da arma
	}

}
