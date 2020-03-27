using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//opdracht 3 - inventory system, tracking 
public class Inventory : MonoBehaviour
{    
    public enum keys
    {
        MACHINE_GUN,
        PISTOL,
        THERMONUCLEAR_WARHEAD
    }

    private keys curWep;

    private Dictionary<keys, List<GameObject>> inventory = new Dictionary<keys, List<GameObject>>();

    private void Start()
    {
        curWep = keys.MACHINE_GUN;
        inventory[keys.MACHINE_GUN] = new List<GameObject>();
        inventory[keys.PISTOL] = new List<GameObject>();
        inventory[keys.THERMONUCLEAR_WARHEAD] = new List<GameObject>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintList();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            
        }
    }

    public void SetMachineGunAmmo(GameObject gameobject)
    {
        inventory[keys.MACHINE_GUN].Add(gameObject);
    }

    private void PrintList()
    {
        for (int i = 0; i < inventory[curWep].Count; i++)
        {
            Debug.Log("Ammo packs collected for " + inventory[curWep] + " " + i);
        }
    }
}