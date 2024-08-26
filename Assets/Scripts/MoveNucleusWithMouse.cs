using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MoveNucleusWithMouse : MonoBehaviour
{
    [SerializeField] Camera mainCam;

    public bool shouldMove;

    Vector3 p, i;

    // Start is called before the first frame update
    public void OnStartMoving()
    {
        shouldMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!shouldMove) return;

        p = Pointer.current.position.ReadValue();

        i = mainCam.ScreenToWorldPoint(p + Vector3.forward * 10);

        transform.position = i;
    }
}
