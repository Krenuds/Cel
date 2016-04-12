using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level {

	public Team playerTeam;
<<<<<<< HEAD
	public string Name { get; private set;}
	public List<Entity> LevelEntities { get; private set;}

	public Level () {
		
=======
	public Team enemyTeam;

	public string Name { get; private set;}
	public int ActiveEntities { get; private set; }
	public List<Entity> LevelEntities { get; private set;}

	public Level () {
		playerTeam = new Team ();
>>>>>>> 56ffbcb84a4803e7a8c230a6fab0e78ffb2ab7be
	}
}
