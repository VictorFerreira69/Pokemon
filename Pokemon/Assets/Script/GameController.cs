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
  GameStates _gameStates = GameStates.GAME;

    [SerializeField] AllyStatus1 player;
    Attibutes[] enemy;
 


    public UnityEvent OnBattleCall;
    public UnityEvent OnBattleEnd;
    public GameStates GameStates { get => _gameStates; set => _gameStates = value; }
    public Attibutes[] Enemy { get => enemy; set => enemy = value; }
    public AllyStatus1 Player { get => player; }

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnBattleCall.AddListener(SetBattleMode);
        OnBattleEnd.AddListener(SetGameMode);
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
    void SetGameMode()
    {
        _gameStates = GameStates.GAME;
    }
}
