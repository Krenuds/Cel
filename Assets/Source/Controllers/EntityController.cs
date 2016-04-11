using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EntityController {
	public Level level { get; private set; }

	public EntityController (Level level) {
		this.level = level;
	}

	public void UpdateEntityWaypoints (List<Entity> selections, Vector2 waypoint) {
		Vector2 nextWaypoint = waypoint;
		foreach (Entity e in selections) {
			e.Waypoint = nextWaypoint;
			nextWaypoint = CalculateNextWayPoint ();
		}
	}

	private Vector2 CalculateNextWaypoint ();
}
