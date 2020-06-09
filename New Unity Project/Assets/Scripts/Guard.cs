using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum StateId
{
	NullStateId = 0,
	Wandering = 1,
	Alerting = 2,
	Fleeing = 3,
    Explode = 4
}

public class Guard : MonoBehaviour {

	private StateMachine _stateMachine;

	void Start () {
		_stateMachine = GetComponent<StateMachine>();
		
		_stateMachine.AddState( StateId.Alerting, GetComponent<AlertState>() );
		_stateMachine.AddState( StateId.Wandering, GetComponent<WanderState>() );
		_stateMachine.AddState( StateId.Fleeing, GetComponent<FleeState>() );
        _stateMachine.AddState( StateId.Explode, GetComponent<ExplodeState>());

        _stateMachine.SetState( StateId.Wandering );
	}

}