using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
public  abstract class Monster : MonoBehaviour
{
  EnemyStatus enemyStatus;
    NavMeshAgent agent;
    void Awake()
    {
       enemyStatus = GetComponent<EnemyStatus>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // CallBatle();
       collision.GetComponent<Movement>().FaceMonster();
       agent.SetDestination(collision.transform.position); 
    }
    void CallBatle()
    {
        SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
        GameController.instance.Enemy = enemyStatus.GetTroops();
        GameController.instance.OnBattleCall.Invoke();
    }
}
