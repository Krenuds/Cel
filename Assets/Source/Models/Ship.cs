using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Entity))]
public class Ship : MonoBehaviour {

	public Entity entity;
	public float moveSpeed;

	void Start () {
		entity = GetComponent<Entity> ();
	}

	void Update () {
		if (entity.Waypoint != Vector2.zero) {
			transform.position = Vector2.MoveTowards (transform.position, entity.Waypoint, moveSpeed * Time.deltaTime);
		}
	}
}
