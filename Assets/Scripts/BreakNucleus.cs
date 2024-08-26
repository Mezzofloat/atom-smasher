using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakNucleus : MonoBehaviour
{
    [SerializeField] StopGame sg;
    [SerializeField] NucleusProtonCount npc;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Photon")) {
            sg.OnStop();
        }

        if (other.gameObject.CompareTag("Proton")) {
            npc.AddProton();
            Destroy(other.gameObject);
        }
    }
}
