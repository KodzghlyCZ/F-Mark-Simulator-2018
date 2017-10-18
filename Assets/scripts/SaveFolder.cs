using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveFolder : MonoBehaviour
{
    public GameObject CSL;
    string savePath;
    void Start()
    {
        CSL = GameObject.FindGameObjectWithTag("Events");

        savePath = CSL.GetComponent<SaveSystem>().CLoadString("savePath");
        
        //gameObject.GetComponent<Slider>().value = slider;
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
