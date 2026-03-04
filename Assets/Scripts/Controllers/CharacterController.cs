using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Character _characterData;
    private SpriteRenderer _spriteRenderer;

    public Character CharacterData { get => _characterData; set => _characterData = value; }

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        SetCharacterData();
    }

    void Update()
    {
        
    }

    private void SetCharacterData()
    {
        if (CharacterData != null)
        {
            _spriteRenderer.sprite = CharacterData.SpriteImage;
        }
        else
        {
            Debug.Log("Missing Character Data");
        }
    }
}
