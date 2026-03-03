using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum ECombatSteps
{
    StartCombat,
    WaitingAction,
    WaitingAnimation,
    CheckingTeams,
    NextTurn,
    EndCombat
}

public class CombatManager : MonoBehaviour
{
    #region Attributes
    private static CombatManager _instance;
    private List<Character> _characterTeam = new List<Character>();
    private List<Enemy> _enemyTeam = new List<Enemy>();
    private List<Character> _turnOrder = new List<Character>();
    private ECombatSteps _currentCombatStep = ECombatSteps.StartCombat;

    #endregion Attributes

    #region Properties
    public static CombatManager Instance { get => _instance;}
    #endregion Properties

    void Start()
    {
        SingletonVerification();
    }

    void Update()
    {
        CombatLogic();
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

    private void CombatLogic()
    {
        switch (_currentCombatStep)
        {
            case ECombatSteps.StartCombat:
                DetermineTurnOrder();
                _currentCombatStep++;
                break;
            case ECombatSteps.WaitingAction:
                break;
            case ECombatSteps.WaitingAnimation:
                break;
            case ECombatSteps.CheckingTeams:
                break;
            case ECombatSteps.NextTurn:
                break;
            case ECombatSteps.EndCombat:
                break;
        }
    }

    private void DetermineTurnOrder()
    {
        _turnOrder.AddRange(_characterTeam);
        _turnOrder.AddRange(_enemyTeam);
        List<Character> sortedList = _turnOrder.OrderBy(o=>o.Statistics.Speed).ToList();
        _turnOrder = sortedList;
    }
}
