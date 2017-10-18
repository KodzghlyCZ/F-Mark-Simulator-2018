using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			
			GameObject calc_prefab = Instantiate ((Resources.Load ("calc") as GameObject), transform.position, transform.rotation);
			calc_prefab.GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed*10);
		}
	}
}
