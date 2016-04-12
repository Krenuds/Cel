using UnityEngine;
using System.Collections;

public class UiController {

	GameObject selectboxObject;
	GameObject canvas;
	RectTransform rectTransform;
	Vector2 anchor;
<<<<<<< HEAD

	public UiController() {
=======
	public Level level;

	public UiController(Level level) {
		this.level = level;
>>>>>>> 56ffbcb84a4803e7a8c230a6fab0e78ffb2ab7be
		selectboxObject = GameObject.Find("Selectbox");
		rectTransform = selectboxObject.GetComponent<RectTransform>();
		canvas = GameObject.Find("Canvas");

		ClearBox();
	}

	public void StartSelectBox(Vector3 anchor) {
		Debug.Log ("Starting Selection");
		selectboxObject.SetActive(true);

		this.anchor = ScreenToLocal(anchor);

		rectTransform.localPosition = new Vector3(this.anchor.x, this.anchor.y, rectTransform.localPosition.z);
	}

	public void DragSelectBox(Vector3 outer) {
		Debug.Log ("Dragging Selection");
		Vector2 rectPos = ScreenToLocal(outer);
		Vector2 newSize = new Vector2();
		Vector3 newPosition = new Vector3(anchor.x, anchor.y, rectTransform.localPosition.z);

		if (rectPos.x - anchor.x < 0) {
			// move location
			newSize.x = anchor.x - rectPos.x;
			newPosition.x = rectPos.x;
		} else {
			newSize.x = rectPos.x - anchor.x;
		}

		if (rectPos.y - anchor.y < 0) {
			// move location
			newSize.y = anchor.y - rectPos.y;
			newPosition.y = rectPos.y;
		} else {
			newSize.y = rectPos.y - anchor.y;
		}

		rectTransform.sizeDelta = newSize;
		rectTransform.localPosition = newPosition;
	}

	private Vector2 ScreenToLocal(Vector3 point) {
		Vector2 pos;
		RectTransformUtility.ScreenPointToLocalPointInRectangle( canvas.transform as RectTransform, point, Camera.main, out pos);

		return pos;
	}

	public void ClearAll() {
		ClearBox();
	}

	public void ClearBox() {
		selectboxObject.SetActive(false);
		rectTransform.sizeDelta = new Vector2(0, 0);
	}

}
