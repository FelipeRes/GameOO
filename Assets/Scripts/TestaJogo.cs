using UnityEngine;
using System.Collections;

public class TestaJogo : MonoBehaviour {

	Pessoa p = new Pessoa ();
	Conta conta;

	void Start(){
		conta = new Conta (p,123123,500);
		p.nome = "Maria Lucia";
		p.idade = 43;
		p.altura = 1.65f;

		Debug.Log (conta.pessoa.nome + " possui " + conta.saldo + " em sua conta");
		conta.Depositar (100);
		Debug.Log (conta.pessoa.nome + " possui " + conta.saldo + " em sua conta");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
