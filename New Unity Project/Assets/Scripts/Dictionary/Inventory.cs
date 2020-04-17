using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///opdracht 3 - inventory system, tracking 
public class Inventory : MonoBehaviour
{
    public enum Keys
    {
        MACHINE_GUN,
        PISTOL,
        THERMONUCLEAR_WARHEAD
    }

    private Keys curWep;

    private Dictionary<Keys, List<GameObject>> inventory = new Dictionary<Keys, List<GameObject>>();

    private void Start()
    {
        curWep = Keys.MACHINE_GUN;
        inventory[Keys.MACHINE_GUN] = new List<GameObject>();
        inventory[Keys.PISTOL] = new List<GameObject>();
        inventory[Keys.THERMONUCLEAR_WARHEAD] = new List<GameObject>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            input();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintList((int)curWep);
        }
    }

    private void input()
    {
        if (inventory.ContainsKey(Keys.MACHINE_GUN))
        {

        }
        //int temp_int;ddd
        //temp_int = (int)curWep;
        switch ((int)curWep)
        {
            case 0:
                print("Machine gun");
                break;

            case 1:
                print("Pistol");
                break;

            case 2:
                print("Thermonuclear weapon");
                break;
        }
    }

    public void SetMachineGunAmmo(GameObject gameobject)
    {
        inventory[Keys.MACHINE_GUN].Add(gameObject);
    }

    private void PrintList(int index)
    {
        switch(index)
        {
            case 0:
                Debug.Log("Weapon packs collected for the Machine gun" + inventory[Keys.MACHINE_GUN].Count);
                break;
            case 1:
                Debug.Log("Weapon packs collected for the Pistol" + inventory[Keys.PISTOL].Count);
                break;
            case 2:
                Debug.Log("Parts collected for the Warhead" + inventory[Keys.THERMONUCLEAR_WARHEAD].Count);
                break;
        }
    }
    
}