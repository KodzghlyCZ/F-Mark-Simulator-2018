using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour {
    Scene scene;
	// Use this for initialization
	void Start () {


        scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && scene.name != "menu") {
			SceneManager.LoadSceneAsync ("menu");
		} 
		else 
		{
			Application.Quit ();
		}
	}
}
