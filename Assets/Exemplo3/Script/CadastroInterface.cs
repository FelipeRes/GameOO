using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CadastroInterface : MonoBehaviour {

	public Text nome;
	public Text idade;
	public Text peso;
	public Text altura;
	public Text cpf;

	public void Cadastrar(){
		string nomeForm = nome.text;
		int idadeForm = int.Parse (idade.text);
		int pesoForm = int.Parse(idade.text);
		float alturaForm = float.Parse(idade.text);
		int cpfForm = int.Parse(idade.text);
		Cliente cliente = new Cliente (nomeForm, idadeForm, pesoForm, alturaForm, cpfForm);
		Debug.Log (cliente.nome);
	}
}
