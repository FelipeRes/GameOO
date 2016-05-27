using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {


	public bool menuIsOn;
	public GameObject menuObject;
	public GameObject menuArmaContent;
	public GameObject armaTest;
	public PlayerMove player;

	void Start(){
		menuIsOn = false;
		menuObject.SetActive (false);
		player = FindObjectOfType<PlayerMove> ();
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (menuIsOn) {
				menuIsOn = false;
				Debug.Log (menuIsOn);
			} else {
				menuIsOn = true;
				Debug.Log (menuIsOn);
			}
			menuObject.SetActive (menuIsOn);
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			AdicionarArma(armaTest);
		}
	}

	public void mudaArma(GameObject armaObject){
		player.character.MudarDeArma (armaObject);
	}

	public void AdicionarArma(GameObject armaItem){
		GameObject armaItemReference = Instantiate (armaItem, Vector3.zero, Quaternion.identity) as GameObject;
		armaItemReference.transform.parent = menuArmaContent.transform;
	}

}
