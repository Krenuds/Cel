using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour{
<<<<<<< HEAD

	public Team team;
	public string Name { get; private set;}
	public int ID { get; private set; }
=======
	public Team team;
	public string Name { get; private set; }
	public float Health { get; private set; }
	public int ID { get; private set; }
	public Vector2 Waypoint;

	void Start () {
		team = null;
		Health = 100.0f;
		Name = "Default";
		ID = 666;
		Debug.Log (Waypoint);
	}
>>>>>>> 56ffbcb84a4803e7a8c230a6fab0e78ffb2ab7be
}
