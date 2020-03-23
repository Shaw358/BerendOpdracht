using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClickDetection : MonoBehaviour
{
    [SerializeField] private HealthText healthText;
    [SerializeField] private Objectheath objectHealth;
    [SerializeField] private CameraShake cameraShake;

    public void OnMouseDown()
    {        
        objectHealth.setHealth();
        //cameraShake.setShake(1);
    }
}