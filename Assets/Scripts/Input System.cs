using UnityEngine;

public class UnlockCursor : MonoBehaviour {
    void Start() {
        Cursor.lockState = CursorLockMode.None; // lock mouse
        Cursor.visible = true;                  // show mouse
    }
}