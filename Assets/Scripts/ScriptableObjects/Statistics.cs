using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Statistics", menuName = "ScriptableObjects/Statistics")]
public class Statistics : ScriptableObject
{
    [SerializeField] private int _hpMax = 0;
    [SerializeField] private int _strength = 0;
    [SerializeField] private int _dexterity = 0;
    [SerializeField] private int _intelligence = 0;
    [SerializeField] private int _defensePhy = 0;
    [SerializeField] private int _defenseMag = 0;
    [SerializeField] private int _resistance = 0;
    [SerializeField] private int _chance = 0;
    [SerializeField] private int _dodgeRate = 0;
    [SerializeField] private int _critRate = 0;
    [SerializeField] private int _critDamage = 0;
    [SerializeField] private int _speed = 0;
}
