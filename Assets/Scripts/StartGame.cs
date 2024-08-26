using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class StartGame : MonoBehaviour
{
    [SerializeField] Camera mainCam;

    public UnityEvent gameStarted;
    
    void OnStartGame()
    {
        mainCam.DOOrthoSize(12, 1).SetEase(Ease.OutElastic);
        gameStarted.Invoke();
    }

}
