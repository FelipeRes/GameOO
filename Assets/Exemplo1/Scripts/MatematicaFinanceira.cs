using UnityEngine;
using System.Collections;

public class MatematicaFinanceira : MonoBehaviour {

	static public float calcularJuroSimples(float capital, float taxa, int periodos){
		return capital * taxa * periodos;
	}
}
