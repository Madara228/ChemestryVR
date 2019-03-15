using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using SimpleJSON;
using UnityEditor;

public class JsonController : MonoBehaviour
{
    string path;

    public static JSONNode node;
//    string GetStreamingAssetsPath()
//    {
//        string path;
//    #if UNITY_EDITOR
//        path = "file:" + Application.dataPath + "/StreamingAssets";
//    #elif UNITY_ANDROID
//        path = "jar:file://"+ Application.dataPath + "!/assets/";
//    #elif UNITY_IOS
//        path = "file:" + Application.dataPath + "/Raw";
//    #else
//        path = "file:"+ Application.dataPath + "/StreamingAssets";
//    #endif
//        return path;
//    }

    void Start()
    {
//        path = GetStreamingAssetsPath();
//        StartCoroutine(ReloadFile());
        LoadRes();
    }
    
//    private IEnumerator ReloadFile(){
////        WWW data = new WWW(path + "/Water.json");
//        var data = new WWW(Resources.Load<TextAsset>("Water.json"));
//        yield return data;
//        //Debug.Log(data.text + "data.text");
//        node = JSON.Parse(data.text);
//        for (int i = 0; i < node.Count; i++)
//        {
//            string itemsContent = node[i]["name"];
//            string itemsContent_1 = node[i]["description"];   
////            Debug.Log(itemsContent);
////            Debug.Log(itemsContent_1);
//        }
//      
//    }
    private void LoadRes()
    {
        var jsonTextFile = Resources.Load<TextAsset>("Water");
        Debug.Log(jsonTextFile);
        node = JSON.Parse(jsonTextFile.text);
        for (int i = 0; i < node.Count; i++)
        {
            string itemsContent = node[i]["name"];
            string itemsContent_1 = node[i]["description"];   
//            Debug.Log(itemsContent);
//            Debug.Log(itemsContent_1);
        }
    }
}

