using UnityEngine;
using System.Collections;

public enum Elemento{
	Terra,
	Luz,
	Trevas,
	Trovao,
	Agua,
	Fogo,
	Ar,
	Neutro
}
public class ProcessoDeElementos{
	static public bool elementoMaisForte(Elemento elementoDaArma, Elemento elementoDoInimigo){
		if (elementoDaArma == Elemento.Terra && elementoDoInimigo == Elemento.Luz) {
			return true;
		} else if (elementoDaArma == Elemento.Luz && elementoDoInimigo == Elemento.Trevas) {
			return true;
		} else if (elementoDaArma == Elemento.Trevas && elementoDoInimigo == Elemento.Trovao) {
			return true;
		} else if (elementoDaArma == Elemento.Trovao && elementoDoInimigo == Elemento.Agua) {
			return true;
		} else if (elementoDaArma == Elemento.Agua && elementoDoInimigo == Elemento.Fogo) {
			return true;
		} else if (elementoDaArma == Elemento.Fogo && elementoDoInimigo == Elemento.Ar) {
			return true;
		} else if (elementoDaArma == Elemento.Ar && elementoDoInimigo == Elemento.Terra) {
			return true;
		} else {
			return false;
		}
	}
}
