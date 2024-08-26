using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScaleOrbitalToMouse : MonoBehaviour
{
    [SerializeField] Camera mainCam;

    [HideInInspector] public bool shouldMove;

    float distance;
    float maxDistance;
    Vector3 intermediate;
    Vector2 mousePosition;

    const float ENERGY_1 = 1;
    const float ENERGY_2 = 2;
    const float ENERGY_3 = 3;
    const float ENERGY_4 = 5;
    const float ENERGY_5 = 7;

    SpriteRenderer sr;

    void Start() {
        sr = GetComponent<SpriteRenderer>();
        maxDistance = Mathf.Sqrt(mainCam.orthographicSize * mainCam.orthographicSize * (1 + mainCam.aspect * mainCam.aspect));
    }

    void OnEnable() {
        mainCam = Camera.main;
        shouldMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!shouldMove) return;

        mousePosition = Pointer.current.position.ReadValue();

        intermediate = mainCam.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
        
        distance = Mathf.Sqrt(intermediate.x * intermediate.x + intermediate.y * intermediate.y);

        if (0 < distance && distance <= 1.5f) {
            distance = 1;
        } else if (1.5f < distance && distance <= 2.5f) {
            distance = 2;
        } else if (2.5f < distance && distance <= 4) {
            distance = 3;
        } else if (4 < distance && distance <= 6) {
            distance = 5;
        } else if (6 < distance) {
            distance = 7;
        }

        transform.localScale = new Vector3(distance, distance, 1);

        float percent = (maxDistance - distance) / maxDistance;
        sr.color = new Color(0.05f, 0.75f, 1, percent);
    }
}
