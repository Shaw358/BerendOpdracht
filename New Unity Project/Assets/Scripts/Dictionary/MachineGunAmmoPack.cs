using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunAmmoPack : MonoBehaviour
{
    private Transform poolLocation;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        poolLocation = GameObject.Find("Pool_Location").GetComponent<Transform>(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name.Equals("Player"))
        {
            collision.gameObject.GetComponent<Inventory>().SetMachineGunAmmo(gameObject);
            GotoPoolLocation();
        }
    }

    private void GotoPoolLocation()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
        gameObject.transform.position = poolLocation.position;
    }

    public void activate()
    {
        rb.constraints = RigidbodyConstraints.None;
    }
}
