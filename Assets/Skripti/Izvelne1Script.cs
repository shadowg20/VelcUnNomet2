using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importe, lai varetu ieladet ainas
using UnityEngine.SceneManagement;

public class Izvelne1Script : MonoBehaviour {

	//Izdarot kliksi uz pogas "uzAinu", tiks atverta aina "izvelne1"
	public void uzIzvelni ()
	{
		SceneManager.LoadScene ("izvelne1", LoadSceneMode.Single);
		//Drikst nosaukuma vieta izmantot ari kartas indeksu
		//SceneManager.LoadScene(1,LoadSceneMode.Single);
	}
}
