using System.Collections;
using System.Collections.Generic;
using LiquidVolumeFX;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    [SerializeField]private bool _withElementCH4 = false;
    
    private LiquidVolume lv;

    public GameObject particle_smoke;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CH4")
        {
            if (_withElementCH4 == false)
            {
                _withElementCH4 = true;
                Debug.Log("Пояснил за шлот");
            }
        }
        else
        {
            if (_withElementCH4)
            {
                StartCoroutine(smoking());
                //Start smoking
                Debug.Log("reaction worked");
            }
        }
        
    }

    private IEnumerator smoking()
    {
        particle_smoke.SetActive(true);
        yield return  new WaitForSeconds(5f);
        particle_smoke.SetActive(false);
    }

}
