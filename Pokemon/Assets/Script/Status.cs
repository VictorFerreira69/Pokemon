using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.Properties;

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
    [SerializeField] int level;

    [SerializeField] string[] startMoves;

    public string[] StartMoves { get => startMoves; }

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

    protected void Start()
    {
        moves = transform.GetChild(0);
        foreach (Attibutes move in attibutes)
        {
           foreach(string item in move.StartMoves)
                //Instancia cada golpe inicial de cada pokemon que existe na lista
            {
                Instantiate(GameController.instance.GetAttack(item), moves);
            }
        }
       
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
