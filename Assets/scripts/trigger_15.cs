using UnityEngine;
using System.Collections;

public class trigger_15 : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Enemy")
		{
			print ("ApplyDamage");
		}

	}
}