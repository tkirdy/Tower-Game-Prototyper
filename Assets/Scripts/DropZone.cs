using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler {
    public CurrentPlayer tracker;
    private void Start() {
        tracker = GameObject.FindGameObjectWithTag("Canvas").GetComponentInChildren<CurrentPlayer>();
    }
    public void OnDrop(PointerEventData eventData) {
        Cell target = this.GetComponent<Cell>();
        if (target != null) {
            if (!target.filled) {

                // Only drop if cell is at the bottom or on top of a filled cell
                bool valid = target.row == 0 || target.GetComponentInParent<Board>().getCell(target.row - 1, target.col).filled;
                if (!valid) {
                    return;
                }

                target.filled = true;
                Tile d = eventData.pointerDrag.GetComponent<Tile>();
                d.dragTarget = this.transform;

                tracker.getCurrentPlayer().addPoints(d.calculateValue(target.row, target.col));
                tracker.endTurn();
            }
        }
    }
}
