using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0, 3, -5);

    void Update()
    {
        transform.position = target.position + target.rotation * offset;
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, target.rotation.eulerAngles.y, transform.eulerAngles.z);
    }
}
