using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("You win");
        }
    }
}
