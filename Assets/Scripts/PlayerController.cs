using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour {
    public TextMeshProUGUI  collectCountText;
    public TextMeshProUGUI  strengthText;
    private int _collectedCount = 0;
    private int _strength = 100;

    void Start() {
        Collectable.OnCollected += OnCollect;
    }

    void OnCollect(Collectable item) {
        Debug.Log("Find Collectable object, collected!");
        _collectedCount++;
        collectCountText.text = $"Objects: {_collectedCount}";

        // check is the object is special
        if (item.isSpecial) {
            _strength = Mathf.Max(0, _strength - 10);
            strengthText.text = $"Strength: {_strength}";
        }
    }
}