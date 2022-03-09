using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour {
	public Objekti objektuSkripts;
	
	// Update is called once per frame
	void Update ()
	{
		//Ja ir vilks kads objekts, tad to vares kariget
		if (objektuSkripts.pedejaisVIlktais != null) {
			//Nospizot z taustinu rote preteji pulkstenraditaja virzienam
			if (Input.GetKey (KeyCode.Z)) {
				objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().Rotate (0, 0, Time.deltaTime * 100f);
			}
			//Nospiezot x taustinu rote pulkstenraditaja virziena
			if (Input.GetKey (KeyCode.X)) {
				objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().Rotate (0, 0, -Time.deltaTime * 100f);
			}
			//Nospiezot bultinu uz augsu iespejams stiept objektu pa y asi
			if (Input.GetKey (KeyCode.UpArrow)) {
				if (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.y < 0.8f) {
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.x, objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.y + 0.01f);
				}
			}
			//Nospiezot bultinu uz augsu iespejams stiept objektu pa y asi
			if (Input.GetKey (KeyCode.DownArrow)) {
				if (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.y > 0.3f) {
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.x, objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.y - 0.01f);
				}
			}
			//Nospiezot bultinu uz augsu iespejams stiept objektu pa x asi
			if (Input.GetKey (KeyCode.RightArrow)) {
				if (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.x < 0.8f) {
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.x + 0.01f, objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.y);
				}
			}
			//Nospiezot bultinu uz augsu iespejams stiept objektu pa x asi
			if (Input.GetKey (KeyCode.LeftArrow)) {
				if (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.x > 0.3f) {
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.x - 0.01f, objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().localScale.y);
				}
			}
		}
	}
}