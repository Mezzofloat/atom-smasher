using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyPO : MonoBehaviour
{
    void OnDestroy() {
        transform.parent.GetComponent<PlaceOrbital>().hasBeenDestroyed = true;
    }
}
