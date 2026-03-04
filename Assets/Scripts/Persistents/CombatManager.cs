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
    private List<Character> _playerTeam = new List<Character>();
    private List<Character> _enemyTeam = new List<Character>();
    private List<Character> _turnOrder = new List<Character>();
    private ECombatSteps _currentCombatStep = ECombatSteps.StartCombat;
    private Transform[] _playerSpawnpoints;
    private Transform[] _enemySpawnpoints;
    [SerializeField] private CharacterController _characterPrefab;
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

    #region Methods
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
                SpawnCharacters();
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

    private void SpawnCharacters()
    {
        _playerTeam.AddRange(TeamManager.Instance.Team);
        for (int i = 0; i < _playerTeam.Count; i++)
        {
            CharacterController characterInstance = Instantiate(_characterPrefab, _playerSpawnpoints[i].transform);
            characterInstance.CharacterData = _playerTeam[i];
        }
        for (int i = 0; i < _enemyTeam.Count; i++)
        {
            CharacterController characterInstance = Instantiate(_characterPrefab, _enemySpawnpoints[i].transform);
            characterInstance.CharacterData = _enemyTeam[i];
        }
    }

    private void DetermineTurnOrder()
    {
        _turnOrder.AddRange(_playerTeam);
        _turnOrder.AddRange(_enemyTeam);
        List<Character> sortedList = _turnOrder.OrderBy(o=>o.Statistics.Speed).ToList();
        _turnOrder = sortedList;
    }
    #endregion Methods
}
