using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///opdracht 1 - zonder enums
public class Dictionary1 : MonoBehaviour
{
    private static int machine_gun_ammo = 100;
    Dictionary<string, int> inventory = new Dictionary<string, int>
    {
        {"machine_gun", machine_gun_ammo},
        {"pistol", 20},
        {"thermonuclear_warhead", 1}
    };

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            inventory["machine_gun"] -= 1;
        }

        if (inventory.ContainsKey("machine_gun"))
        {
            int value = inventory["machine_gun"];
            Debug.Log(value);
        }
    }
}