using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public enum Mode
{
    Phsical,Special,Status
}
public enum Type
{
    Normal,Fire,Water,Ghost
}
[System.Serializable]
public class Attack
{
    [SerializeField] string name;
    [SerializeField] Type type;
    [SerializeField] Mode mode;
    [SerializeField] int damage;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
}
public class BattleController : MonoBehaviour
{
    public static BattleController instance;
    public UnityEvent OnCharactersEnterEnd;
   [SerializeField] Attack[] Attacks;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Battle"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RunAway()
    {
        GameController.instance.OnBattleEnd.Invoke();
        SceneManager.UnloadSceneAsync("Battle");
    }
}
