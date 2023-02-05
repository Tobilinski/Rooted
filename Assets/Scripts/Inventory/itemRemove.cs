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
                removeItem();
                InventorySystem.intance.door.SetActive(false);
                break;
            case Items.itemType.Scroll:
                break;
            case Items.itemType.Box:
                break;
            default:
                break;
        }
        
    }
}
