using UnityEngine;
using System.Collections;

public class ContaCorrente : Conta {
	
	public float tributos = 5.0f;

	public override void Depositar(float valor){
		saldo = saldo + valor;
		saldo -= tributos;
	}
	public override void Sacar(float valor){
		if (saldo >= valor) {
			saldo = saldo - valor;
			saldo = saldo - tributos;
		} else {
			Debug.Log ("Saldo insuficiente");
		}
	}

}
