using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class ApplyNewScript : MonoBehaviour
{
    public GameObject ball;

//	public GameObject box;
    public GameObject meta_data_text;
    private MetaDataScript _metaDataScript;
    private Renderer renderer;
    public Vector3 center, size;
    public GameObject line;

    void Start()
    {
        _metaDataScript = meta_data_text.GetComponent<MetaDataScript>();
        //Получаем скрипт из текста
    }


    public void DeleteText()
    {
        _metaDataScript.data.RemoveAt(_metaDataScript.data.Count - 1);
        Refresh();
    }

    void Refresh()
    {
        _metaDataScript.str = "";
        for (int i = 0; i < _metaDataScript.data.Count; i++)
        {
            _metaDataScript.str += _metaDataScript.data[i];
            Debug.Log(_metaDataScript.str);
        }
        
    }

    public void Apply()
    {
        for (int i = 0; i < _metaDataScript.data.Count; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                              Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            //Рандомный инстанс
            var txt = ball.GetComponentInChildren<TextMesh>();
            txt.text = _metaDataScript.data[i].ToString();
            //Получаем наш текст

            if (i>0 && _metaDataScript.data[i] != _metaDataScript.data[i - 1])
            {
                //<Меняем цвет шариков>
                var ball_gobj = Instantiate(ball, pos, Quaternion.identity);
                var ball_renderer = ball_gobj.GetComponent<Renderer>();
                ball_renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                Debug.Log(ball_renderer.material.color);
                Debug.Log("material render");
                var gameobject = GameObject.FindGameObjectsWithTag("ball"); 
                //</Меняем цвет шариков>
            }
            else
            {
                Instantiate(ball, pos, Quaternion.identity);
                Debug.Log("not edited");
            }

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(center, size);
    }
}