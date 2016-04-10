using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class GameEvent {

};

public class TestEvent : GameEvent {
	public int number;

	public TestEvent (int n) {
		number = n;
	}
}

public class MasterPulseEvent : GameEvent {
	
}
