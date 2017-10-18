using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class load_scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Play()
    {
        SceneManager.LoadScene("lvl1");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
