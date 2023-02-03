using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRemove : MonoBehaviour
{
   Items item;

    public void removeItem()
    {
        InventorySystem.intance.Remove(item);

        Destroy(gameObject);
    }

    public void AddItem(Items newItems)
    {
        item = newItems;
    }

    public void useItem()
    {
        switch (item.itemtype)
        {
            case Items.itemType.Key:
                Debug.Log("Key Open");
                break;
            case Items.itemType.Book:
                break;
            case Items.itemType.Roock:
                break;
            default:
                break;
        }
        removeItem();
    }
}
