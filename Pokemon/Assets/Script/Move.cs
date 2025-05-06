using UnityEngine;

public  abstract class Move : MonoBehaviour
{
    [SerializeField] Type type;
    [SerializeField] Mode mode;
    [SerializeField] int damage;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
    int temPP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        temPP = pp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
