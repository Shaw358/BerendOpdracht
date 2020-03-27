using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunAmmoPack : MonoBehaviour
{
    private Transform poolLocation;

    private void Start()
    {
        poolLocation = GameObject.Find("Pool_Location").GetComponent<Transform>(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name.Equals("Player"))
        {
            collision.gameObject.GetComponent<Inventory>().SetMachineGunAmmo(gameObject);
        }
    }

    private void GotoPoolLocation()
    {
        gameObject.transform.position = poolLocation.position;
    }
}
