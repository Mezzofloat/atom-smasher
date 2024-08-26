using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class StopGame : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;

    public void OnStop() {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }

    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
