using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timeout : MonoBehaviour {
	public int countdown;
    public string scene_name;
	// Use this for initialization
	void Start () {
		StartCoroutine (countdown_numerator());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator countdown_numerator()
	{
		while (true) {
			if (countdown > 0) 
			{
				countdown--;
				GetComponent<Text> ().text = countdown.ToString ();
			}
		    else 
			{
				SceneManager.LoadScene(scene_name);
			}
			yield return new WaitForSeconds (1);
		}

	}
}
