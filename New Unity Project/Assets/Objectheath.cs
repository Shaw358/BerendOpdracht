using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectheath : MonoBehaviour
{
    private int health;

    private void Awake()
    {
        health = 100;
    }
    
    public void setHealth(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public int getHealth()
    {
        return health;
    }
}
