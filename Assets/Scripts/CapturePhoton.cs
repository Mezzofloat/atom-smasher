using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePhoton : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Photon")) {
            var photonEnergy = (int)other.GetComponent<ChangeColorWithEnergy>().energyLevel;

            other.GetComponent<ChangeColorWithEnergy>().DecrementEnergyLevel(GetComponent<OrbitalHealth>().energy);

            if (other == null) {
                GetComponent<OrbitalHealth>().energy -= photonEnergy;
            } else {
                //GetComponent<AudioSource>().Play();
                Destroy(gameObject);
            }
        }
        
        if (other.gameObject.CompareTag("Proton")) {
            other.GetComponent<AudioSource>().Play();
            transform.parent.GetChild(1).GetChild(0).GetComponent<NucleusProtonCount>().AddProton();
            Destroy(other.gameObject);
        }
    }
}
