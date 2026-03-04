using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private static InventoryManager _instance;
    [SerializeField] private List<Item> _items = new List<Item>();

    [SerializeField] private Transform _itemContent = null;
    [SerializeField] private GameObject _inventoryItem = null;
    [SerializeField] private Item _item = null;

    private void Awake()
    {
        _instance = this;
    }

    public void Add(Item item)
    {
       _items.Add(item);
    }

    public void Remove(Item item)
    {
        _items.Remove(item);
    }

    public void ListItem()
    {
        foreach (var item in _items)
        {
            GameObject inventoryItem = Instantiate(_inventoryItem, _itemContent);
            var itemName = inventoryItem.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = inventoryItem.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = _item.ItemName ;
            //itemIcon.sprite = ;

        }
    }

}
