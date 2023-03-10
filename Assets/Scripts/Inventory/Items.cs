using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New item",menuName ="Item/Create New Item")]
public class Items : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
    public itemType itemtype;

    public enum itemType
    {
        MotelKey,
        CrimeKey,
        Scroll,
        Box,
        OfficeKey
      
    }

}
