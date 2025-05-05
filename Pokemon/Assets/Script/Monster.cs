using UnityEngine;
using UnityEngine.SceneManagement;

public  abstract class Monster : MonoBehaviour
{
  EnemyStatus enemyStatus;
    void Awake()
    {
       enemyStatus = GetComponent<EnemyStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CallBatle();
    }
    void CallBatle()
    {
        SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
        GameController.instance.Enemy = enemyStatus.GetTroops();
        GameController.instance.OnBattleCall.Invoke();
    }
}
