using UnityEngine;

public class PlayerBattle : MonoBehaviour
{
    
    void Start()
    {
        
    }
     public void EnterFinish()
    {
        BattleController.instance.OnCharactersEnterEnd.Invoke();
    }
}
