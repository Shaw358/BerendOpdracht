using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectheath : MonoBehaviour
{
    private int health;

    public delegate void HealthChanged(int x);
    public HealthChanged healthChanged;

    private void Awake()
    {
        health = 100;
    }
    
    public void setHealth(int damage = 10)
    {
        health -= damage;

        healthChanged(health);

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