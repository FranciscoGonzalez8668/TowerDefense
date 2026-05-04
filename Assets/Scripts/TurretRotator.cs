using UnityEngine;

public class TurretRotator : MonoBehaviour
{
    public float rotationSpeed = 200f;
    public float damping = 5f;

    private float currentVelocity;

    void Update()
    {
        float scroll = Input.mouseScrollDelta.y;
        currentVelocity += scroll * rotationSpeed * Time.deltaTime;
        currentVelocity = Mathf.Lerp(currentVelocity, 0f, damping * Time.deltaTime);
        transform.Rotate(0f, currentVelocity, 0f);
    }
}