using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Statistics", menuName = "ScriptableObjects/Statistics")]
public class Statistics : ScriptableObject
{
    [SerializeField] private int _level = 0;
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

    public int HpMax { get => _hpMax; set => _hpMax = value; }
    public int Strength { get => _strength; set => _strength = value; }
    public int Dexterity { get => _dexterity; set => _dexterity = value; }
    public int Intelligence { get => _intelligence; set => _intelligence = value; }
    public int DefensePhy { get => _defensePhy; set => _defensePhy = value; }
    public int DefenseMag { get => _defenseMag; set => _defenseMag = value; }
    public int Resistance { get => _resistance; set => _resistance = value; }
    public int Chance { get => _chance; set => _chance = value; }
    public int DodgeRate { get => _dodgeRate; set => _dodgeRate = value; }
    public int CritRate { get => _critRate; set => _critRate = value; }
    public int CritDamage { get => _critDamage; set => _critDamage = value; }
    public int Speed { get => _speed; set => _speed = value; }
}
