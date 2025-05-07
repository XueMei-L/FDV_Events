using System;
using UnityEngine;

public class Collectable : MonoBehaviour {
    public bool isSpecial;
    public static event Action<Collectable> OnCollected;
    public float collectDistance = 1.0f;
    private Transform _player;

    void Start() {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        if (_player == null) Debug.LogError("Player not found!");
    }

    void Update() {
        if (_player == null) return;

        // cuando choca con el objeto especial
        if (Vector3.Distance(transform.position, _player.position) <= collectDistance) {
            OnCollected?.Invoke(this);
            Destroy(gameObject);
        }
    }
}