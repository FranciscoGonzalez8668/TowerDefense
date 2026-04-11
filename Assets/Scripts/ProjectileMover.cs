using UnityEngine;

public class ProjectileMover : MonoBehaviour
{
    
    [SerializeField] private float speed = 10f;

    void Update()
    {
        transform.position +=transform.forward*speed*Time.deltaTime;
    }
}