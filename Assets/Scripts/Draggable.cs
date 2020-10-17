using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

    public Transform dragTarget;
    public bool isDraggable = true;

    public void OnDrag(PointerEventData eventData) {
        this.transform.position = eventData.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        if (!isDraggable) {
            eventData.pointerDrag = null;
            return;
        }
        dragTarget = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        Cell parent = dragTarget.GetComponent<Cell>();
        if (parent != null) {
            parent.filled = false;
        }
    }
    public void OnEndDrag(PointerEventData eventData) {
        this.transform.SetParent(dragTarget);
        Cell parent = dragTarget.GetComponent<Cell>();
        if (parent != null) {
            isDraggable = false;
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
