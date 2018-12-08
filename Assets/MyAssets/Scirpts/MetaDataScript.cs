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

    public Button btn;
    
    
    

    void Start()
    {
    }

    void Update()
    {
        new_text.text = str.ToString();
    }

    public void OnClick()
    {
        Debug.Log(JsonController.node[str]["name"]);
        Debug.Log(JsonController.node[str]["description"]);
    }
}
