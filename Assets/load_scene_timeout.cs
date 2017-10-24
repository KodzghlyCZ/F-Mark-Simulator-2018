using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene_timeout : MonoBehaviour {
	public int time = 3;
	// Use this for initialization
	void Start () {
		StartCoroutine (respawn());
		//Scene scene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator respawn()
	{
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			
	}
}
