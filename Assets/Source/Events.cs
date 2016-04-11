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

public class SelectionEvent : GameEvent {

	public List<Entity> selection { get; private set; }

	public SelectionEvent(List<Entity> selection){
		this.selection = selection;
	}
}

public class StartSelectBoxEvent : GameEvent {

	public Vector3 anchor { get; private set; }

	public StartSelectBoxEvent(Vector3 anchor){
		this.anchor = anchor;
	}
}

public class DragSelectBoxEvent : GameEvent {

	public Vector3 outer { get; private set; }

	public DragSelectBoxEvent(Vector3 outer){
		this.outer = outer;
	}
}

public class WaypointSetEvent : GameEvent {
	public Vector2 waypoint;

	public WaypointSetEvent (Vector2 waypoint) {
		this.waypoint = waypoint;
	}
}
