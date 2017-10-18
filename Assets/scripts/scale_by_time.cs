using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale_by_time : MonoBehaviour {


	public float speed = 1f; //1 by default in inspector

	//This method is executed every frame
	private void Update(){
		transform.localScale += Vector3.one * speed * Time.deltaTime;

	}
}