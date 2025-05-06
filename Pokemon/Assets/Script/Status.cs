using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Attibutes
{
    [SerializeField] string name;
    [SerializeField] int life;
    [SerializeField] int phsicalAttack;
    [SerializeField] int specialAttack;
    [SerializeField] int phsicalDefense;
    [SerializeField] int specialDefense;

    [SerializeField] int speed;
    [SerializeField] int level



    public bool TakeDamage(int damage)
    {
        life -= damage;

        return life <= 0;
        
            
        
    }
}
public abstract class Status : MonoBehaviour
{
   
    [SerializeField] List<Attibutes> attibutes = new List<Attibutes>();

    [SerializeField] string[] starterMoves;
    Transform moves;

    public Attibutes[] GetTroops()
    {
        return attibutes.ToArray();
    }

    void Start()
    {
        moves = transform.GetChild(0);
        foreach (var move in starterMoves)
        {
            Instantiate(GameController.instance.GetAttack(move), moves);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
