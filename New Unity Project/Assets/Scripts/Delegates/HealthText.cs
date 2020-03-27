using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    [SerializeField] private Objectheath objectHealth;
    [SerializeField] private TextMeshProUGUI txt;

    private void Start()
    {
        objectHealth.healthChanged += updateText;
        //txt.text = objectHealth.getHealth().ToString();
    }

    public void updateText(int x)
    {
        txt.text = x.ToString();
    }
}