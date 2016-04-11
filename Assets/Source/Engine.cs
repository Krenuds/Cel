using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Engine : MonoBehaviour {

	private SelectionController selectionController;
	private UiController uiController;
	private TeamController teamController;
	private EntityController entityController;

	private Level level;

	void Start () {
		LoadLevel ();
	}

	void LoadLevel () {
		level = new Level ();
		selectionController = new SelectionController (level);
		uiController = new UiController (level);
		teamController = new TeamController (level);
		entityController = new EntityController (level);

		EventManager.AddListener<SelectionEvent>(OnSelection);
		EventManager.AddListener<StartSelectBoxEvent>(OnStartSelectBox);
		EventManager.AddListener<DragSelectBoxEvent>(OnDragSelectBox);
		EventManager.AddListener<WaypointSetEvent>(OnWaypointSet);
	}
		
    void Update () {
		if (Input.GetMouseButtonDown(0)) {
			selectionController.CreateBoxSelection();
		}

		if (Input.GetMouseButtonUp(0)) {
			selectionController.SelectEntities();
		}

		if (Input.GetMouseButtonDown (1)) {
			teamController.SetWaypoint ();
		}

		selectionController.DragBoxSelection();
	}

	private void OnSelection(SelectionEvent e) {
		//_commandController.selection = e.selection;
		uiController.ClearBox();
	}

	private void OnStartSelectBox(StartSelectBoxEvent e) {
		uiController.StartSelectBox(e.anchor);
	}

	private void OnDragSelectBox(DragSelectBoxEvent e) {
		uiController .DragSelectBox(e.outer);
	}

	private void OnWaypointSet (WaypointSetEvent e) {
		entityController.UpdateEntityWaypoints (selectionController.selection, e.waypoint);
	}

}