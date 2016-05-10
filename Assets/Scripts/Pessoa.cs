using UnityEngine;
using System.Collections;

public class Pessoa : MonoBehaviour {

	public float altura;
	public float peso;
	public int idade;
	public string nome;

	public void Falar(string palavras){
		Debug.Log (palavras);
	}
}
