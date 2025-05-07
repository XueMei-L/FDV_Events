using UnityEngine;
using UnityEngine.UI;
using StarterAssets;  // to get Third Person Controller Script

public class SpeedControl : MonoBehaviour {
    // Buttons
    public Button normalButton;
    public Button turboButton;

    // Speeds
    public float normalSpeed = 5f;
    public float turboSpeed = 10f;

    // Get third Person Controller object
    public ThirdPersonController playerController;

    void Start() {
        normalButton.onClick.AddListener(() => {
            playerController.MoveSpeed = normalSpeed;
            Debug.Log("Move with normal Speed");
        });

        turboButton.onClick.AddListener(() => {
            playerController.MoveSpeed = turboSpeed;
            Debug.Log("Move with turbo Speed");
        });
    }
}