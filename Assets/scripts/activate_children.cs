using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class activate_children : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "drozdik")
		{
			Time.timeScale = 0.5f;
			gameObject.transform.GetChild (0).gameObject.SetActive (true);
			StartCoroutine (restart ());
		}
	}
	IEnumerator restart()
	{
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene(Application.loadedLevel);
	}
}
