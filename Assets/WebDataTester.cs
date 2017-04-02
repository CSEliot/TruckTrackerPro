using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;



public class WebDataTester : MonoBehaviour {


    public TruckData myData;

    public tk2dTextMesh texty;

    void Start()
    {

            LoadFiles();
        
        //if no file, create one?
    }

        // Use this for initialization
    void SaveS ()
    {
       

        myData.uniqueTruckID++;
        texty.text = myData.uniqueTruckID.ToString();

       // if (Application.platform == RuntimePlatform.WebGLPlayer)
       // {


       SaveFiles();
        
    }
	
    void LoadFiles()
    {
        
        myData = SaveLoadData.Load();
        texty.text = myData.uniqueTruckID.ToString();
    }

    void SaveFiles()
    {
        SaveLoadData.Save(myData);
    }
}
