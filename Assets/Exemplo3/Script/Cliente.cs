using UnityEngine;
using System.Collections;

public class Cliente : MonoBehaviour {

	public string nome;
	public int idade;
	public int peso;
	public float altura;
	public int cpf;
	public Sexo sexo;

	public Cliente(string nome,  int idade, int peso, float altura, int cpf){
		this.nome = nome;
		this.idade = idade;
		this.peso = peso;
		this.altura = altura;
		this.cpf = cpf;
		this.sexo = sexo;

	} 
		

}
