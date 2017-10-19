using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour {
    public string path;
    void Start()
    {
       
    }
	public void CSave (string name, string value) {
        System.IO.File.WriteAllText(path + name + ".txt",value);
        print("Stored variable " + name + " with value of " + value + " .");
    }
	public string CLoadString (string name)
    {
		string output = System.IO.File.ReadAllText(path + name + ".txt"); 
        return output;
	}
    public int CLoadInt(string name)
    {
        string output = System.IO.File.ReadAllText(path + name + ".txt") ;
        int    output_int = Convert.ToInt32(output);
        return output_int;
    }
    public double CLoadDouble(string name)
    {
		string output = System.IO.File.ReadAllText(path + name + ".txt");
        double output_double = Convert.ToDouble(output);
        return output_double;
    }
    public bool CLoadBool(string name)
    {
        string output = System.IO.File.ReadAllText(path + name + ".txt");
        bool   output_bool = Convert.ToBoolean(output);
        return output_bool;
    }
}
