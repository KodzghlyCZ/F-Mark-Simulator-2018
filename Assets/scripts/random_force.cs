using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_force : MonoBehaviour {
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		StartCoroutine (wait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator wait ()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			if (Random.Range (1, 4) == 1)
			{
				
			}
			if (Random.Range (1, 4) == 2)
			{
				
			}
			if (Random.Range (1, 4) == 3)
			{
				
			}
			if (Random.Range (1, 4) == 4)
			{
				
			}
			switch (Random.Range (0, 4)) {
			case 0:
				rb.AddForce (transform.up * 1000);
				break;
			case 1:
				rb.AddForce (transform.right * 1000);
				break;
			case 2: 
				rb.AddForce (-transform.up * 1000);
				break;
			case 3:
				rb.AddForce (-transform.right * 1000);
				break;
			default:
				break;
				{
				}




				print ("pulse");
			}
		}
	}
}
