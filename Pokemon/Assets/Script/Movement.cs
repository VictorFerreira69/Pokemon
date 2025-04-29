using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float speed;
    Vector2 movement;
    Rigidbody2D rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameController.instance.OnBattleCall.AddListener(BattleMode);
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate()
    {
        if (GameController.instance.GameStates.Equals(GameStates.BATTLE))
           return;
        
            
        rb.linearVelocity = movement * speed;
    }
    void BattleMode()
    {
        rb.linearVelocity = Vector2.zero;
    }
}
