using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour
{
    #region Attributes
    private static TeamManager _instance;

    private List<Character> _team = new List<Character>();
    #endregion Attributes

    #region Properties
    public static TeamManager Instance { get => _instance;}
    public List<Character> Team { get => _team; set => _team = value; }
    #endregion Properties

    void Awake()
    {
        SingletonVerification();
    }

    void Start()
    {

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
}
