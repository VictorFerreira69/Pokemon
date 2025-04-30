using UnityEngine;

[System.Serializable]
public class Attibutes
{
    [SerializeField] int life;
    [SerializeField] int speed;
    [SerializeField] int level;
}
public abstract class Status : MonoBehaviour
{
    [SerializeField] Attibutes attibutes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
