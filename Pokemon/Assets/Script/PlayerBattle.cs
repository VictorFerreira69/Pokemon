using UnityEngine;

public class PlayerBattle : MonoBehaviour
{
    Attibutes[] status;
    void Start()
    {
        status = GameController.instance.Player.GetTroops();
    }
     public void EnterFinish()
    {
        BattleController.instance.OnCharactersEnterEnd.Invoke();
    }
}
