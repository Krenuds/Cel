using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Team : MonoBehaviour{
	public string Name { get; private set; }
	public List<Entity> Teammates { get; private set; }

	public Team () {
		
	}
}
