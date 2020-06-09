﻿using UnityEngine;
using System.Collections;

public class FleeState : State {

	public override void Act(){
		transform.Translate(new Vector3(0.1f, 0, 0));
	}
	
	public override void Reason(){
		// hier staat niks
		// De FleeState blijft hierdoor vluchten
		// beetje een mietje, deze bewaker
	}

}
