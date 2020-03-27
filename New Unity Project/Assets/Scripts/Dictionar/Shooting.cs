using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//opdaracht 2 - met enums
public class Shooting : MonoBehaviour
{
    public enum keys
    {
        MACHINE_GUN,
        PISTOL,
        THERMONUCLEAR_WARHEAD
    }

    Dictionary<keys, int> inventory = new Dictionary<keys, int>
    {
        {keys.MACHINE_GUN, 100},
        {keys.PISTOL, 20},
        {keys.THERMONUCLEAR_WARHEAD, 1}
    };

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            inventory[keys.MACHINE_GUN] -= 1;
        }

        if (inventory.ContainsKey(keys.MACHINE_GUN))
        {
            int value = inventory[keys.MACHINE_GUN];
            Debug.Log(value);
        }
    }
}