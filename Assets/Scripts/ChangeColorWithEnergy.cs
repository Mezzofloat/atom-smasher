using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWithEnergy : MonoBehaviour
{
    [SerializeField] List<Color> energyColors;
    [SerializeField] TrailRenderer tr;

    public int energyLevel { get; private set; }

    public void DecrementEnergyLevel(int i) {
        if (i >= (int)energyLevel) Destroy(gameObject);

        SetEnergyLevel(energyLevel - i);
    }

    public void SetEnergyLevel(int e) {
        if (e >= 0 & e <= 5) {
            var c = energyColors[e];

            GetComponent<SpriteRenderer>().color = c;
            tr.startColor = tr.endColor = c;
        }

        switch (e) {
            case 0:
                GetComponent<MovePhoton>().photonSpeed = 10;
                break;
            case 1:
                GetComponent<MovePhoton>().photonSpeed = 15;
                break;
            case 2:
                GetComponent<MovePhoton>().photonSpeed = 20;
                break;
            case 3:
                GetComponent<MovePhoton>().photonSpeed = 25;
                break;
            case 4:
                GetComponent<MovePhoton>().photonSpeed = 30;
                break;
            case 5:
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
