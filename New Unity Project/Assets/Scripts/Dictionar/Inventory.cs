using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum keys
    {
        MACHINE_GUN,
        PISTOL,
        THERMONUCLEAR_WARHEAD
    }

    Dictionary<keys, List<GameObject>> inventory;

    private void Start()
    {
        inventory[keys.MACHINE_GUN] = new List<GameObject>();
        inventory[keys.PISTOL] = new List<GameObject>();
        inventory[keys.THERMONUCLEAR_WARHEAD] = new List<GameObject>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //inventory[keys.MACHINE_GUN] -= 1;
        }

        if (inventory.ContainsKey(keys.MACHINE_GUN))
        {
            //int value = inventory[keys.MACHINE_GUN];
            // Debug.Log(value);
        }
    }

    public void SetMachineGunAmmo(GameObject gameobject)
    {
        inventory[keys.MACHINE_GUN].Add(gameObject);
    }

    private void PrintList()
    {

    }
}