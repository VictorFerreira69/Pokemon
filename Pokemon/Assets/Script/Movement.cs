using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float speed;
    Vector2 movement;
    Rigidbody2D rb;
    bool isLocked;

    public bool IsLocked { get => isLocked; }

    public void FaceMonster()
    {

        isLocked = true;
        rb.linearVelocity = Vector2.zero;   
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameController.instance.OnBattleCall.AddListener(BattleMode);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isLocked)
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate()
    {
        if (GameController.instance.GameStates.Equals(GameStates.BATTLE))
           return;

        if (!isLocked)
            rb.linearVelocity = movement * speed;
    }
    void BattleMode()
    {
        rb.linearVelocity = Vector2.zero;
    }
}
