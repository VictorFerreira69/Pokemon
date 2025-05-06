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
    
}
public class BattleController : MonoBehaviour
{
    public static BattleController instance;
    public UnityEvent OnCharactersEnterEnd;
  

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
