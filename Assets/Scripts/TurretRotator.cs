using UnityEngine;

public class TurretRotator : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        float scroll = Input.mouseScrollDelta.y;
        transform.Rotate(0f,scroll*rotationSpeed*Time.deltaTime,0f);
    } 
}