using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDone : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject MazeCam;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            NormalCam.SetActive(true);
            MazeCam.SetActive(false);
            Debug.Log("You win");
        }
    }
}
