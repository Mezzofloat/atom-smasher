using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhoton : MonoBehaviour
{
    [HideInInspector] public float photonSpeed;
    [SerializeField] float angleTolerance;
    
    float randomAngle;

    // Start is called before the first frame update
    void Start()
    {
        randomAngle = Random.Range(-angleTolerance, angleTolerance);
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg + randomAngle + 180);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * photonSpeed * Time.deltaTime, Space.Self);

        if (transform.position.x * transform.position.x + transform.position.y * transform.position.y > 900) {
            Destroy(gameObject);
        }
    }
}
