using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;
	//GameObject, kas uzglabās velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementaMasina;
	public GameObject e46;
	public GameObject ekskavators;
	public GameObject policija;
	public GameObject traktors1;
	public GameObject traktorsS;
	public GameObject Ugunsdzesejs;
	public GameObject Uzvara;
	public GameObject Zvaigzne1;
	public GameObject Zvaigzne2;
	public GameObject Zvaigzne3;
	public GameObject nojauna;
	public float laiks;
	public bool laiksir=true;
	public Text rezult;

	public int punkti=0;
	//Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementaKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 ekskaKoord;
	[HideInInspector]
	public Vector2 poliKoord;
	[HideInInspector]
	public Vector2 trak1Koord;
	[HideInInspector]
	public Vector2 trakSKoord;
	[HideInInspector]
	public Vector2 UgunKoord;

	//Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
	public AudioSource skanasAvots;
	//Masīvs, kas uzglabā visas iespējamās skaņas
	public AudioClip[] skanaKoAtskanot;
	//Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabās pēdējo objektu, kurš pakustināts
	public GameObject pedejaisVIlktais = null;

	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		b2Koord = b2.GetComponent<RectTransform> ().localPosition;
		cementaKoord = cementaMasina.GetComponent<RectTransform> ().localPosition;
		e46Koord = e46.GetComponent<RectTransform> ().localPosition;
		ekskaKoord = ekskavators.GetComponent<RectTransform> ().localPosition;
		poliKoord = policija.GetComponent<RectTransform> ().localPosition;
		trak1Koord = traktors1.GetComponent<RectTransform> ().localPosition;
		trakSKoord = traktorsS.GetComponent<RectTransform> ().localPosition;
		UgunKoord = Ugunsdzesejs.GetComponent<RectTransform> ().localPosition;
		Uzvara.SetActive (false);
		Zvaigzne1.SetActive (false);
		Zvaigzne2.SetActive (false);
		Zvaigzne3.SetActive (false);
		nojauna.SetActive (false);
		rezult.GetComponent<Text> ().enabled = false;
	}
}
