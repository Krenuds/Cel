using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Team : MonoBehaviour{
	public string Name { get; private set; }
<<<<<<< HEAD
	public List<Entity> Teammates { get; private set; }

	public Team () {
		
=======
	public List<Entity> mates { get; private set; }

	public Team () {
		this.Name = "Default";
		this.mates = new List<Entity> ();
	}

	public Team (string name) {
		this.Name = name;
		this.mates = new List<Entity> ();
>>>>>>> 56ffbcb84a4803e7a8c230a6fab0e78ffb2ab7be
	}
}
