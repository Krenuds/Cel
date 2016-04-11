using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour{
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
}
