using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Team : MonoBehaviour{
	public string Name { get; private set; }
	public List<Entity> mates { get; private set; }

	public Team () {
		this.Name = "Default";
		this.mates = new List<Entity> ();
	}

	public Team (string name) {
		this.Name = name;
		this.mates = new List<Entity> ();
	}
}
