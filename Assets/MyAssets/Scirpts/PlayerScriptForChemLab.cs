using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptForChemLab : MonoBehaviour
{
    CharacterController cc;
    [SerializeField]private float speed = 5f;
    private bool moveForward;
    public Transform camera;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if (camera.transform.eulerAngles.x > 30f && camera.transform.eulerAngles.x<90f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
    }

    private void FixedUpdate()
    {
        if (moveForward)
        {
            Vector3 forward = camera.TransformDirection(Vector3.forward * speed * Time.fixedDeltaTime);
            cc.SimpleMove(forward);
        }
    }
}
