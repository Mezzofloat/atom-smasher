using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePhotons : MonoBehaviour
{
    [SerializeField] float photonSpawnRate, photonSpawnDistance;
    [SerializeField] int initialPhotonNumber;
    [SerializeField] GameObject photonPrefab;

    // Start is called before the first frame update
    public void OnStart() => Invoke("SpawnPs", 4);

    public void SpawnPs() {
        float angleDistance = 360 / initialPhotonNumber;

        float angle = 0;
        for (int i = 0; i < initialPhotonNumber; i++) {
            Instantiate(photonPrefab, new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * photonSpawnDistance, Quaternion.identity);
            angle += angleDistance;
        }

        StartCoroutine("SpawnPhoton");
    }

    IEnumerator SpawnPhoton() {
        ChangeColorWithEnergy p;

        while (true) {
            float angle = Random.Range(0, 360);

            p = Instantiate(photonPrefab, photonSpawnDistance * new Vector3(Mathf.Cos(angle), Mathf.Sin(angle)), Quaternion.identity).GetComponent<ChangeColorWithEnergy>();
            
            int el = Random.Range(0,6);
            p.SetEnergyLevel(el);
            yield return new WaitForSeconds(photonSpawnRate);
        }
    }
}
