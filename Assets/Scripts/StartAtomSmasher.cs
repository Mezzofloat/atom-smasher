using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAtomSmasher : MonoBehaviour
{
    public void OnClick() {
        SceneManager.LoadScene("SampleScene");
    }
}
