using UnityEngine;
using System.Collections;

public class TestaJogo : MonoBehaviour {

	Pessoa p1 = new Pessoa();
	Conta conta = new ContaPoupanca();

	void Start(){
		p1.nome = "Joao Vitor Nudes";
		p1.idade = 32;
		p1.altura = 1.78f;
		p1.cpf = 32423422;
		p1.peso = 128;
		p1.identidade = 3232321;

		conta.pessoa = p1;

		Debug.Log("A conta de " + p1.nome + " possui " + conta.getSaldo());
		conta.Depositar (300);
		Debug.Log("A conta de " + p1.nome + " possui " + conta.getSaldo());

		Debug.Log(MatematicaFinanceira.calcularJuroSimples (conta.getSaldo (), 50, 5));
	}

}
