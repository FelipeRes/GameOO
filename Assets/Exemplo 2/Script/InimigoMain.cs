using UnityEngine;
using System.Collections;

public class InimigoMain : MonoBehaviour {

	public Inimigo inimigo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnTriggerEnter2D(Collider2D coll){
		Debug.Log ("oi");
		if (coll.gameObject.GetComponent<PlayerMove> () != null) {
			coll.gameObject.GetComponent<PlayerMove> ().character.AdicionarDano (inimigo.forcaFisica);
		}
	}


}
