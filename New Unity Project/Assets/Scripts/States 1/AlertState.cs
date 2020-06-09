using UnityEngine;
using System.Collections;

public class AlertState : State {

	[SerializeField]
	private float alertDuration = 4f;

	private float _currentAlarmTime;

	public override void Enter(){
		_currentAlarmTime = 0f;
	}

	public override void Act(){
		float size = Random.Range(0.5f, 1.5f);
		transform.localScale = new Vector3(size, size, size);
		_currentAlarmTime += Time.deltaTime;
	}

	public override void Reason(){
		if(_currentAlarmTime > alertDuration)
			GetComponent<StateMachine>().SetState( StateId.Fleeing);

	}

}