using UnityEngine;
using System.Collections;

public class Conta : MonoBehaviour {

	public Pessoa pessoa;
	public int numero;
	public float saldo;

	public virtual void Depositar(float valor){
		saldo = saldo + valor;
	}

	public virtual void Sacar(float valor){
		if (saldo >= valor) {
			saldo = saldo - valor;
		} else {
			Debug.Log ("Saldo insuficiente");
		}
	}

	public float getSaldo(){
		return saldo;
	}
}
