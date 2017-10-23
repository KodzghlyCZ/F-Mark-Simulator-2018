using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour {
    Scene scene;
	public string additive_scene;
	public bool additive_scene_load;
	// Use this for initialization
	void Start () {


        scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		if (additive_scene_load) {
			SceneManager.LoadScene(additive_scene);	
		}
		else
		{
		SceneManager.LoadScene("menu");
		}
	}
}
