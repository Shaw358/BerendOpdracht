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
        txt.text = objectHealth.getHealth().ToString();
    }

    public void updateText()
    {
        txt.text = objectHealth.getHealth().ToString();
    }
}
