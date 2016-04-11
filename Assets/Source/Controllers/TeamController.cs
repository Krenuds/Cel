using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TeamController {

	public Level level;
	public Vector2 Waypoint { get; private set; }

	public TeamController (Level level) {
		this.level = level;
		FindAndAddTeammates (level.playerTeam);
	}

	public void FindAndAddTeammates (Team team) {
		foreach (GameObject g in GameObject.FindGameObjectsWithTag("Player")) {
			Debug.Log ("Adding to team");
			team.mates.Add (g.GetComponent<Entity>());
		}
	}

	public void SetWaypoint () {
		this.Waypoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		EventManager.Trigger (new WaypointSetEvent (Waypoint));
	}
}
