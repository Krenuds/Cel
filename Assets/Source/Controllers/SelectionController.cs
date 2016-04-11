using UnityEngine;
using System.Collections.Generic;


public class SelectionController {

	private Level level;
	private Team playerTeam;

	public List<Entity> selection { get; private set; }

	private Vector3 anchor;
	private Vector3 outer;
	private bool hasActiveBox;



	public SelectionController(Level level){
		this.level = level;
		selection = new List<Entity>();
		this.playerTeam = level.playerTeam;
	}

	public void ClearSelection() {
		RemoveAllSelections();
		Debug.Log ("Triggering selectionEvent");
		EventManager.Trigger(new SelectionEvent(selection));
	}

	private void AddToSelection(Entity entity) {

		selection.Add(entity);

		entity.transform.Find("Halo").gameObject.SetActive(true);
	}

	private void AddAllWithinBounds() {
		Bounds bounds = SelectUtil.GetViewportBounds(Camera.main, anchor, outer);

		foreach (Entity entity in this.level.playerTeam.mates) {
			if (SelectUtil.IsWithinBounds(Camera.main, bounds, entity.transform.position)) {
				Debug.Log ("Added");
				AddToSelection(entity);
			}
		}
	}

	private void AddSingleEntity() {
		Entity entity = SelectUtil.FindEntityAt(Camera.main, anchor);

		if (entity != null) {
			if (entity.team == level.playerTeam) {
				AddToSelection(entity);
			}
		}
	}

	private void RemoveAllSelections() {

		foreach (Entity entity in selection) {
			entity.transform.Find("Halo").gameObject.SetActive(false);
		}

		selection.Clear();
	}

	public void SelectEntities() {
		RemoveAllSelections();

		if (outer == anchor) {
			AddSingleEntity();
		} else {
			AddAllWithinBounds();
		}

		hasActiveBox = false;

		EventManager.Trigger(new SelectionEvent(selection));
	}

	public void CreateBoxSelection() {
		
		hasActiveBox = true;

		anchor = Input.mousePosition;
		outer = Input.mousePosition;
		Debug.Log ("Triggering selectionEvent");
		EventManager.Trigger(new StartSelectBoxEvent(anchor));
	}

	public void DragBoxSelection() {
		
		if (hasActiveBox) {
			outer = Input.mousePosition;
			Debug.Log ("Triggering DragBoxSelection");
			EventManager.Trigger(new DragSelectBoxEvent(outer));
		}
	}

}
