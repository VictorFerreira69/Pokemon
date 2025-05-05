using UnityEngine;

public class EnemyBattle : MonoBehaviour
{
    Attibutes[] status;
    void Start()
    {
        status = GameController.instance.Enemy;
    }
    private void Update()
    {
        
    }
}

