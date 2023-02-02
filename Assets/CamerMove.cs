using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CamerMove : MonoBehaviour
{
    public GameObject target;
    public Camera caMera;
    public static bool selectionMade;
    public float Speed = 50.0f;
    Vector3 velocity = Vector3.zero;



    private void Update()
    {
        camRotate();

        
    }
    void camRotate()
    {
        if (selectionMade == true)
        {
            caMera.transform.LookAt(target.transform);
            //caMera.transform.Translate(Vector3.right * Time.deltaTime);
            
            caMera.fieldOfView = Mathf.Lerp(caMera.fieldOfView, 20f, 0.5f * Time.deltaTime);
            
            

        }
    

    }
  
}
