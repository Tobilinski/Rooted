using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUP : MonoBehaviour
{
    public Items item;

    void pickUP()
    {
        InventorySystem.intance.Add(item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        pickUP();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickUP();
        }
    }
}
