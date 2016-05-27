using UnityEngine;
using System.Collections;

public class MudaArma : MonoBehaviour {

	public GameObject novaArma;

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.GetComponent<PlayerMove> () != null) {
			coll.gameObject.GetComponent<PlayerMove> ().character.MudarDeArma (novaArma);
		}
	}
}
