using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level {

	public Team playerTeam;
	public string Name { get; private set;}
	public List<Entity> LevelEntities { get; private set;}

	public Level () {
		
	}
}
