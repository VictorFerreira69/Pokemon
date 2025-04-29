using UnityEngine;
using UnityEngine.SceneManagement;

public  abstract class Monster : MonoBehaviour
{
  
    void Start()
    {
        
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

        GameController.instance.OnBattleCall.Invoke();
    }
}
