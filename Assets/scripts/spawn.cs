using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
	public GameObject[] pieces;
	public float frq;
	// Use this for initialization
	void Start () {
		StartCoroutine (spawn_objects());
	}
	
	// Update is called once per frame
	void Update () {
		
			
	}
	void spawn_obj ()
	{
		
	}
	IEnumerator spawn_objects ()
	{
		while (true) {
			Instantiate (pieces [Random.Range (0, pieces.Length)], new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
		
			yield return new WaitForSeconds (frq);
		}
	}
}
