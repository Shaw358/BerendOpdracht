using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeState : State
{
    [SerializeField] private Transform target;
    private float blast_radius = 5;
    [SerializeField] private Sprite[] sprite;
    private bool is_exploding = false;

    private float delay = 0.5f;

    public override void Act()
    {
        if (is_exploding == false)
        {
            is_exploding = true;
            StartCoroutine(CountDown());
        }
    }

    public override void Reason()
    {
        float distanceToTarget = Vector2.Distance(target.transform.position, transform.position);

        if (distanceToTarget < blast_radius)
        {
            // we zijn dicht bij de target
            // creeper.exe
            GetComponent<StateMachine>().SetState(StateId.Alerting);
        }
    }

    private IEnumerator CountDown()
    {
        int cur_sprite = 0;
        for(int i = 0; i < 2; i++)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite[cur_sprite];
            yield return new WaitForSeconds(delay);
            if(cur_sprite == 1)
            {
                cur_sprite = 0;
            }
            cur_sprite++;
        }
        Destroy(gameObject);
    }
}
