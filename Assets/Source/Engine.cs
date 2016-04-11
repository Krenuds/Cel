using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Engine : MonoBehaviour {

	private SelectionController selectionController;
	private UiController uiController;

	void Awake () {
		selectionController = new SelectionController (new Level());
		uiController = new UiController ();
		EventManager.AddListener<SelectionEvent>(OnSelection);
		EventManager.AddListener<StartSelectBoxEvent>(OnStartSelectBox);
		EventManager.AddListener<DragSelectBoxEvent>(OnDragSelectBox);
	}
		
    void Update () {
		if (Input.GetMouseButtonDown(0)) {
			selectionController.CreateBoxSelection();
		}

		if (Input.GetMouseButtonUp(0)) {
			selectionController.SelectEntities();
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

}