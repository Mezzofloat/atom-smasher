using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaceOrbital : MonoBehaviour
{
    [SerializeField] GameObject orbitalPrefab;

    [SerializeField] GameObject orbitalToPlace;

    public bool hasBeenDestroyed;

    public void OnPlace() {
        if (!hasBeenDestroyed) {
            orbitalToPlace.GetComponent<ScaleOrbitalToMouse>().shouldMove = false;
            orbitalToPlace.GetComponent<OrbitalHealth>().SetHealth();
            orbitalToPlace = Instantiate(orbitalPrefab, transform);
        }
    }

    public void OnStart() {
        Destroy(orbitalToPlace);
    }

}