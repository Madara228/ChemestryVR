using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    private bool canDrag;
    
    public void OnDrag()
    {
        canDrag = true;
    }

    public void onExit()
    {
        canDrag = false;
    }

    private void Update()
    {
        if (canDrag)
        {
            GameObject recticlePointer = GameObject.Find("GvrReticlePointer");
            this.gameObject.transform.position = recticlePointer.transform.position + new Vector3(2,2,2);
        }
    }
}
