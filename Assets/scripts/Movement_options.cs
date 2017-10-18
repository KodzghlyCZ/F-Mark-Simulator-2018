using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement_options : MonoBehaviour {
    public GameObject CSL;
    
    void Start () {
        CSL = GameObject.FindGameObjectWithTag("Events");
        int slider;
        
        if (CSL.GetComponent<SaveSystem>().CLoadBool("movement") == false)
        {
            slider = 0;
        }
        else
        {
            slider = 1;
        }
        gameObject.GetComponent<Slider>().value = slider;
    }
    public void Change_value()
    {
        float value = gameObject.GetComponent<Slider>().value;
        if (value == 1)
        {
            CSL.GetComponent<SaveSystem>().CSave("movement", "true");
        }
        else
        {
            CSL.GetComponent<SaveSystem>().CSave("movement", "false");
        }
        
        

    }

}
