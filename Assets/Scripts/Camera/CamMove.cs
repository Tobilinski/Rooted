using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform ScreenTo;
    public Transform ScreenFrom;
    public Transform BoxTo;
    public Transform BoxFrom;
    public float speed = 1f;
    public Vector3 velocity= Vector3.zero;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject panel;

    public GameObject NormalCam;
    public GameObject MazeCam;

 
    public Camera camera;
    // Start is called before the first frame update
   
    public void MoveToScreen()
    {
       transform.position = new Vector3(ScreenTo.position.x, ScreenTo.position.y, ScreenTo.position.z);
        panel.SetActive(true);
       camera.transform.LookAt(Target1.transform);
    }
    public void MoveFromScreen()
    {
        transform.position = new Vector3(ScreenFrom.position.x, ScreenFrom.position.y, ScreenFrom.position.z);
        panel.SetActive(false);
        camera.transform.LookAt(Target2.transform);
    }
    public void MoveToBox()
    {
        transform.position = new Vector3(BoxTo.position.x, BoxTo.position.y, BoxTo.position.z);
        panel.SetActive(false);
        camera.transform.LookAt(Target3.transform);
    }
    public void MoveFromBox()
    {
        transform.position = new Vector3(BoxFrom.position.x, BoxFrom.position.y, BoxFrom.position.z);
        panel.SetActive(false);
        camera.transform.LookAt(Target2.transform);
    }
    public void MoveToMaze()
    {
        NormalCam.SetActive(false);
        MazeCam.SetActive(true);
        panel.SetActive(false);
    }

}
