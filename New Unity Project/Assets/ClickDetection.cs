using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClickDetection : MonoBehaviour
{
    [SerializeField] private HealthText healthText;
    [SerializeField] private Objectheath objectHealth;

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            objectHealth.setHealth(10);
            healthText.updateText();
        }
    }

}
