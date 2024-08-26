using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownText : MonoBehaviour
{
    [SerializeField] TMP_Text countdownText;

    public void OnStart()
    {
        StartCoroutine("CountDown");
    }

    // Update is called once per frame
    IEnumerator CountDown() {
        yield return new WaitForSeconds(1);
        countdownText.text = "3";
        yield return new WaitForSeconds(1);
        countdownText.text = "2";
        yield return new WaitForSeconds(1);
        countdownText.text = "1";
        yield return new WaitForSeconds(1);
        countdownText.text = "GO!";
        yield return new WaitForSeconds(1);
        countdownText.text = "";
    }
}
