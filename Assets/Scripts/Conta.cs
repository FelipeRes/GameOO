using UnityEngine;
using System.Collections;

public class Conta : MonoBehaviour {
	public Pessoa pessoa;
	public int numero;
	public float saldo;

	public Conta(Pessoa pessoa, int numero, float saldo){
		this.pessoa = pessoa;
		this.numero = numero;
		this.saldo = saldo;
	}

	public void Sacar(float valor){
		saldo = saldo - valor;
	}

	public void Depositar(float valor){
		saldo = saldo + valor;
	}
}
