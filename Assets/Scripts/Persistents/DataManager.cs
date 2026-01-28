using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    #region Attributes
    private static DataManager _instance;
    
    private Item[] _itemsData;
    private Dictionary<string, Item> _itemDictionary;

    private Character[] _charactersData;
    private Dictionary<string, Character> _characterDictionary;
    #endregion Attributes

    #region Properties
    public static DataManager Instance { get => _instance;}
    #endregion Properties

    void Awake()
    {
        SingletonVerification();
    }

    void Start()
    {
        SetupDictionaries();
    }

    void Update()
    {
        
    }

    private void SingletonVerification()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void SetupDictionaries()
    {
        for (int i = 0; i < _itemsData.Length; i++)
        {
            _itemDictionary.Add(_itemsData[i].ItemName, _itemsData[i]);
        }
        for (int i = 0; i < _charactersData.Length; i++)
        {
            _characterDictionary.Add(_itemsData[i].ItemName, _charactersData[i]);
        }
    }
}
