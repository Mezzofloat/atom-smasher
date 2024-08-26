using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWithEnergy : MonoBehaviour
{
    [SerializeField] List<Color> energyColors;
    [SerializeField] int maxEnergyLevel;

    int energyLevel;

    public void DecrementEnergyLevel(int i) {
        if (i >= (int)energyLevel) Destroy(gameObject);

        SetEnergyLevel(energyLevel - i);
    }

    public void SetEnergyLevel(int e) {
        switch (e) {
            case 0:
                GetComponent<SpriteRenderer>().color = Color.red;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.red;
                GetComponent<MovePhoton>().photonSpeed = 10;
                break;
            case 1:
                GetComponent<SpriteRenderer>().color = Color.red + Color.yellow;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.red + Color.yellow;
                GetComponent<MovePhoton>().photonSpeed = 15;
                break;
            case 2:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.yellow;
                GetComponent<MovePhoton>().photonSpeed = 20;
                break;
            case 3:
                GetComponent<SpriteRenderer>().color = Color.green;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.green;
                GetComponent<MovePhoton>().photonSpeed = 25;
                break;
            case 4:
                GetComponent<SpriteRenderer>().color = Color.blue;
                transform.GetChild(0).GetComponent<TrailRenderer>().endColor = transform.GetChild(0).GetComponent<TrailRenderer>().startColor = Color.blue;
                GetComponent<MovePhoton>().photonSpeed = 30;
                break;
            case 5:
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
