using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_bossfight : MonoBehaviour {
    public GameObject drozdo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "drozdik")
        {
            

            print("coll.");
            StartCoroutine(restart());
            //Instantiate(Resources.Load(""));
        }

    }

    IEnumerator restart()
    {
        drozdo = GameObject.Find("Drozdik");
        drozdo.transform.position = new Vector3(GameObject.Find("skvrnany_spawn").transform.position.x,
                                                GameObject.Find("skvrnany_spawn").transform.position.y,
                                                GameObject.Find("skvrnany_spawn").transform.position.z);
        yield return new WaitForSeconds(5);
        Application.LoadLevel(Application.loadedLevel);
    }
}
