using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO;
public class move_drozdik : MonoBehaviour {
	public Rigidbody2D rb;
    public bool movement;
	void Start () {
		rb = GetComponent<Rigidbody2D>();

        GameObject CSL = GameObject.FindGameObjectWithTag("Events");
        //go.GetComponent<SaveSystem>().CSave("score","15");
        movement = CSL.GetComponent<SaveSystem>().CLoadBool("movement");


    }
    void Update () 
	{
		
		if (Input.GetKeyDown(KeyCode.W))
		{
            if (movement)
            {
                rb.velocity = Vector3.zero;
            }
           
            rb.AddForce (transform.up * 1000);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
            if (movement)
            {
                rb.velocity = Vector3.zero;
            }
            rb.AddForce (-transform.up * 1000);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
            if (movement)
            {
                rb.velocity = Vector3.zero;
            }
            rb.AddForce (transform.right * 1000);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
            if (movement)
            {
                rb.velocity = Vector3.zero;
            }
            rb.AddForce (-transform.right * 1000);
		}
	}
}
