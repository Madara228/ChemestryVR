using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
public class ApplyNewScript : MonoBehaviour
{	
	public GameObject ball;
//	public GameObject box;
	public GameObject meta_data_text;
	private MetaDataScript _metaDataScript;
	[SerializeField] private Renderer _ball_renderer;	
	
	public Vector3 center, size;
	void Start ()
	{
		_metaDataScript = meta_data_text.GetComponent<MetaDataScript>();
	}

	public void Apply()
	{
		for (int i = 0; i < _metaDataScript.data.Count; i++)
		{
			Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
			GameObject ball_gobj = ball;
			var txt = ball_gobj.GetComponentInChildren<TextMesh>();
			txt.text = _metaDataScript.data[i].ToString();
			Debug.Log(txt.text + "TextMesh");
			Instantiate(ball,pos,Quaternion.identity);
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawCube(center, size);
	}
}
