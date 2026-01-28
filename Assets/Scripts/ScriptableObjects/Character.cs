using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character")]
public class Character : ScriptableObject
{
    [SerializeField] private string _characterName;
    [SerializeField] private Statistics _statistics;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Helmet _helmet;
    [SerializeField] private Chestplate _chesplate;
    [SerializeField] private Leggings _leggings;
    [SerializeField] private Boots _boots;
}
