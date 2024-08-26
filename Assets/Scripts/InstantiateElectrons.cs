using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateElectrons : MonoBehaviour
{
    [SerializeField] float electronSpawnRate, electronSpawnDistance;
    [SerializeField] int initialElectronNumber;
    [SerializeField] GameObject electronPrefab;

    // Start is called before the first frame update
    public void OnStart() => Invoke("SpawnEs", 4);

    public void SpawnEs() {
        float angleDistance = 360 / initialElectronNumber;

        float angle = 0;
        for (int i = 0; i < initialElectronNumber; i++) {
            Instantiate(electronPrefab, new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * electronSpawnDistance, Quaternion.identity);
            angle += angleDistance;
        }

        StartCoroutine("SpawnElectron");
    }

    IEnumerator SpawnElectron() {
        while (true) {
            float angle = Random.Range(0, 360);

            Instantiate(electronPrefab, electronSpawnDistance * new Vector3(Mathf.Cos(angle), Mathf.Sin(angle)), Quaternion.identity);
            yield return new WaitForSeconds(electronSpawnRate);
        }
    }
}
