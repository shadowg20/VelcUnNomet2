using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Objekti objektuSkripts;
	//laiks iet kamer tas ir true
	void Update () {
		if (objektuSkripts.laiksir == true) {
			objektuSkripts.laiks += Time.deltaTime;
		}	
	}
}
