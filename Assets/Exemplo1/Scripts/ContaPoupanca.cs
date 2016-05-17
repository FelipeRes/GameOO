using UnityEngine;
using System.Collections;

public class ContaPoupanca : Conta {
	public float rendimento;

	public void incrementar(){
		saldo = saldo + saldo / 100 * rendimento;
	}
}
