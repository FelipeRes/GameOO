using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArmaItem : MonoBehaviour {

	public Arma armaObject;
	public Arma arma;
	public Image imagem;
	public Text nomeDaArma;
	public Button button;
	// Use this for initialization
	void Start () {	
		imagem.sprite = arma.imagem;
		nomeDaArma.text = arma.nome;
		//button.onClick.AddListener(()+= act



	}

}
