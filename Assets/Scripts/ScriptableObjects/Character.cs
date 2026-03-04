using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character")]
public class Character : ScriptableObject
{
    [SerializeField] private Sprite _spriteImage;
    [SerializeField] private AnimatorController _animatorController;
    [SerializeField] private AnimationClip _idleAnimation;
    [SerializeField] private string _name;
    [SerializeField] private Statistics _statistics;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Helmet _helmet;
    [SerializeField] private Chestplate _chesplate;
    [SerializeField] private Leggings _leggings;
    [SerializeField] private Boots _boots;
    [SerializeField] private Spell[] _spells;

    public Sprite SpriteImage { get => _spriteImage; set => _spriteImage = value; } 
    public string Name { get => _name; set => _name = value; }
    public Statistics Statistics { get => _statistics; set => _statistics = value; }
    public Weapon Weapon { get => _weapon; set => _weapon = value; }
    public Helmet Helmet { get => _helmet; set => _helmet = value; }
    public Chestplate Chesplate { get => _chesplate; set => _chesplate = value; }
    public Leggings Leggings { get => _leggings; set => _leggings = value; }
    public Boots Boots { get => _boots; set => _boots = value; }
    public Spell[] Spells { get => _spells; set => _spells = value; }
    public AnimatorController AnimatorController { get => _animatorController; set => _animatorController = value; }
    public AnimationClip IdleAnimation { get => _idleAnimation; set => _idleAnimation = value; }
}
