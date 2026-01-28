using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField] private string _itemName;
    [SerializeField] private Statistics _statistics;

    public string ItemName { get => _itemName; set => _itemName = value; }
}
