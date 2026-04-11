using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [Header( "Velocidad")]
    public float minSpeed = 2f;
    public float maxSpeed = 5f;

    [Header ( "Zigzag")]
    public float zigzagAmplitude = 0.5f;
    public float zigzagFrequency = 2f;

    private float speed;

    private float phase;


    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        phase = Random.Range(0f, 2f * Mathf.PI);
    
    }

    void Update()
    {
        Vector3 forward = transform.forward * speed * Time.deltaTime;
        float lateral = Mathf.Sin(Time.time * zigzagFrequency+phase) * zigzagAmplitude*Time.deltaTime;

        transform.position += forward + transform.right * lateral;
    }
}