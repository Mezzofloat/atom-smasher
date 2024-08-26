using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NucleusProtonCount : MonoBehaviour
{
    int protonCount;

    public void AddProton() {
        protonCount++;
        GetComponent<TMP_Text>().text = protonCount.ToString();
    }
}
