using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class OrbitalHealth : MonoBehaviour
{
    public int health { get; private set; }
    public int energy;
    
    [SerializeField] int MaxElectrons;

    public void SetHealth() {
        SetHealth((int)transform.localScale.x);
    }

    public void SetHealth(int h) {
        health = h > 0 ? (h < MaxElectrons ? h : MaxElectrons) : 0;
        float percent = 1 - h / (float)MaxElectrons;

        GetComponent<SpriteRenderer>().color = new Color(0.05f, 0.75f, 1, percent);
    }

}
