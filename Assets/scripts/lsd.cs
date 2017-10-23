using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lsd : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.L)) {
			if (Input.GetKey (KeyCode.S)) {
				if (Input.GetKeyDown (KeyCode.D)) {
					SceneManager.LoadScene ("test_chambermega");
				}
			}
		}
	}
}
