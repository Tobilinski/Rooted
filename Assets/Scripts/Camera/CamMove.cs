using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform ScreenTo;
    public Transform ScreenFrom;
    public float speed = 1f;
    public Vector3 velocity= Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void MoveToScreen()
    {
       transform.position = Vector3.SmoothDamp(transform.position, ScreenTo.position, ref velocity,speed * Time.deltaTime); 
    }
    public void MoveFromScreen()
    {
        transform.position = Vector3.SmoothDamp(transform.position, ScreenFrom.position, ref velocity, speed * Time.deltaTime);
    }
}
