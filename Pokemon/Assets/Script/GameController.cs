using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public enum GameStates
{
    GAME,BATTLE
}
public class GameController : MonoBehaviour
{
    public static GameController instance;
  [SerializeField]  GameStates _gameStates = GameStates.GAME;

    public UnityEvent OnBattleCall;
    public GameStates GameStates { get => _gameStates; set => _gameStates = value; }




    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnBattleCall.AddListener(SetBattleMode);
    }

    // Update is called once per frame
    void Update()
    {
        print(SceneManager.GetActiveScene().name);
    }
    void SetBattleMode()
    {
        _gameStates = GameStates.BATTLE;
    }
}
