using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public float speed = 25;
	public float interval;
	public GameObject[] prefs;
	// Use this for initialization
	void Start () {
		StartCoroutine (spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator spawn()
	{
		while (true) 
		{
			float y = Random.Range (2.5f, 17.5f);
			transform.position = new Vector3(transform.position.x, y, transform.position.z);
			GameObject calc_prefab = Instantiate (prefs[Random.Range(0,prefs.Length)], transform.position, transform.rotation);
			calc_prefab.GetComponent<Rigidbody2D> ().AddForce (Vector2.left * speed);
			yield return new WaitForSeconds (interval);
				



		}
	}
}
