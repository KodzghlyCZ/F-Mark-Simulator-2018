using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket_spawner : MonoBehaviour {
	public GameObject mic;
	// Use this for initialization
	void Start () {
		mic = (Resources.Load("mic") as GameObject);
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
		if(col.name == "mic" || col.name == "mic(Clone)" || col.name == "mic_basket(Clone)")
			{
			print ("Coll");
			col.name = "mic_comp";
			Instantiate (mic);
			}
	}
}
