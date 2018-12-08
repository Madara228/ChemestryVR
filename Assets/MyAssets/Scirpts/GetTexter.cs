using UnityEngine;
using UnityEngine.UI;
public class GetTexter : MonoBehaviour
{

	[SerializeField] private Text text_of_element;
	[SerializeField] private Button btn;
	[SerializeField] private MetaDataScript _metaDataScript;
	[SerializeField] private GameObject metaData_g_obj ;
	
	void Start ()
	{
		btn = GetComponent<Button>();
		btn.onClick.AddListener(onClick);
		text_of_element = GetComponentInChildren<Text>();
		metaData_g_obj = GameObject.Find("MyText");
		_metaDataScript = metaData_g_obj.GetComponent<MetaDataScript>();

	}

	
	
	public void onClick()
	{
		_metaDataScript.data.Add(text_of_element.text.ToString());
		_metaDataScript.str = "";
		for (int i = 0; i < _metaDataScript.data.Count; i++)
		{
			_metaDataScript.str += _metaDataScript.data[i];
		}
		
		print(text_of_element.text.ToString());
	}
	
}
