using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class disable_spawner : MonoBehaviour {
    public GameObject spwner;
    public GameObject cutscene;

    // Use this for initialization
    void Start () {
        spwner = GameObject.Find("Spawner");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "drozdik")
        {
            print("Cold");

            Destroy(spwner);

            cutscene.SetActive(true);
            StartCoroutine(menu());
        }

    }
    IEnumerator menu()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene("menu");


    }
}
 