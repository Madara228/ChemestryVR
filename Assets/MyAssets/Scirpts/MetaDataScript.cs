using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class MetaDataScript : MonoBehaviour
{

    public Text new_text;
    public string str;
    public List<string> data = new List<string>();
    public List<string> data_1 = new List<string>();

    void Start()
    {
        data_1.Add("HHO");
        data_1.Add("CHHHH");
        //new_text = GetComponentInChildren<Text>();

    }

    void Update()
    {
        new_text.text = str.ToString();
    }
}
