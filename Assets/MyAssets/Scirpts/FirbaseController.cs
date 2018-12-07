using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEditor.PackageManager;
//using LitJson;
using SimpleJSON;

public class FirbaseController : MonoBehaviour
{
//    public Connection water = new Connection("HHO", "water");
//    private JsonData waterJson;

    string path;

    string GetStreamingAssetsPath()
    {
        string path;
    #if UNITY_EDITOR
        path = "file:" + Application.dataPath + "/StreamingAssets";
    #elif UNITY_ANDROID
     path = "jar:file://"+ Application.dataPath + "!/assets/";
    #elif UNITY_IOS
     path = "file:" + Application.dataPath + "/Raw";
    #else
     path = "file:"+ Application.dataPath + "/StreamingAssets";
    #endif
        return path;
    }

    void Start()
    {
        path = GetStreamingAssetsPath();
        StartCoroutine(ReloadFile());

    }
    
    private IEnumerator ReloadFile(){
        WWW data = new WWW(path + "/Water.json");
        yield return data;
        Debug.Log(data.text + "data.text");
        var N = JSON.Parse(data.text);
        for (int i = 0; i < N.Count; i++)
        {
            string itemsContent = N[i]["name"];
            string itemsContent_1 = N[i]["description"];   
            Debug.Log(itemsContent);
            Debug.Log(itemsContent_1);
        }
      
    }
}

public class Connection
{
    public string formule;
    public string description;

    public Connection(string formule, string description)
    {
        this.formule = formule;
        this.description = description;
    }
}