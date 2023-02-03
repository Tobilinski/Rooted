using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem intance;
    public List<Items> items = new List<Items>();

    public Transform itemContent;
    public GameObject inventoryItem;

    public Toggle delete;

    public itemRemove[] itemInventory;

    private void Awake()
    {
        intance = this;
    }

    public void Add(Items _item)
    {
        items.Add(_item);
    }

    public void Remove(Items _item)
    {
        items.Remove(_item);
    }

    public void ListItem()
    {
        foreach (var iTem in items)
        {
            GameObject obj = Instantiate(inventoryItem, itemContent);
            var itemName = obj.transform.Find("Name").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("Image").GetComponent<Image>();
            var itemRemove = obj.transform.Find("Exit").GetComponent<Button>();


            itemName.text = iTem.itemName;
            itemIcon.sprite = iTem.icon;

            if (delete.isOn)
            {
                itemRemove.gameObject.SetActive(true);
            }
        }

        setInventoryItems();


    }

    public void deleteItem()
    {
        if (delete.isOn)
        {
            foreach (Transform item in itemContent)
            {
                item.Find("Exit").gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Transform item in itemContent)
            {
                item.Find("Exit").gameObject.SetActive(false);
            }
        }
    }

    public void setInventoryItems()
    {
        itemInventory = itemContent.GetComponentsInChildren<itemRemove>();

        for (int i = 0; i < items.Count; i++)
        {
            itemInventory[i].AddItem(items[i]);
        }
    }
}

