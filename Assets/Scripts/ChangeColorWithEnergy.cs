using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWithEnergy : MonoBehaviour
{
    public EnergyLevel energyLevel;

    public void DecrementEnergyLevel(int i) {
        if (i >= (int)energyLevel) Destroy(gameObject);

        SetEnergyLevel((EnergyLevel)((int)energyLevel - i));
    }

    public void SetEnergyLevel(EnergyLevel e) {
        switch (e) {
            case EnergyLevel.Red:
                GetComponent<SpriteRenderer>().color = Color.red;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.red;
                GetComponent<MovePhoton>().photonSpeed = 10;
                break;
            case EnergyLevel.Orange:
                GetComponent<SpriteRenderer>().color = Color.red + Color.yellow;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.red + Color.yellow;
                GetComponent<MovePhoton>().photonSpeed = 15;
                break;
            case EnergyLevel.Yellow:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.yellow;
                GetComponent<MovePhoton>().photonSpeed = 20;
                break;
            case EnergyLevel.Green:
                GetComponent<SpriteRenderer>().color = Color.green;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.green;
                GetComponent<MovePhoton>().photonSpeed = 25;
                break;
            case EnergyLevel.Blue:
                GetComponent<SpriteRenderer>().color = Color.blue;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.blue;
                GetComponent<MovePhoton>().photonSpeed = 30;
                break;
            case EnergyLevel.Purple:
                GetComponent<SpriteRenderer>().color = Color.magenta;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.white;
                GetComponent<MovePhoton>().photonSpeed = 35;
                break;
            default:
                Destroy(gameObject);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetEnergyLevel(energyLevel);
    }

}

public enum EnergyLevel {
    Red = 1,
    Orange = 2,
    Yellow = 3,
    Green = 4,
    Blue = 5,
    Purple = 6
}
