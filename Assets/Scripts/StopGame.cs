using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class StopGame : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] MoveNucleusWithMouse mNWM; 

    public void OnStop() {
        mNWM.shouldMove = false;
        DOVirtual.Float(1, 0, 2, (float f) => {
            Time.timeScale = f;
        }).SetUpdate(true).OnComplete(() => {
            gameOverScreen.SetActive(true);
        }).SetEase(Ease.OutSine);
    }

    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
