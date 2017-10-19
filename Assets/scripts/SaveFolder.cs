using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveFolder : MonoBehaviour
{
    public GameObject CSL;
	public string savePath;
    void Start()
    {
        CSL = GameObject.FindGameObjectWithTag("Events");
		savePath = CSL.GetComponent<SaveSystem> ().path;
		print (savePath);


		if (System.IO.File.Exists (savePath + "savePath.txt")) {
			savePath = CSL.GetComponent<SaveSystem> ().CLoadString ("savePath");
			gameObject.GetComponent<InputField> ().text = savePath;
		} else {
			print ("else");
            CSL.GetComponent<SaveSystem>().CSave(@"\savePath", savePath);
		}
           
    }
    public void Change_value()
    {
		
			CSL.GetComponent<SaveSystem>().CSave("savePath", gameObject.GetComponent<InputField> ().text);

	}

    

}
