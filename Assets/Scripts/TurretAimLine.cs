using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TurretAimLine : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private float maxLength = 20f;

    private LineRenderer _line;

    void Start()
    {
        _line = GetComponent<LineRenderer>();   
    }

    void Update()
    {
        Vector3 start = firePoint.position;
        Vector3 end;

        if(Physics.Raycast(start,firePoint.forward, out RaycastHit hit, maxLength))
            end = hit.point;
        else
            end = start + firePoint.forward * maxLength;
    
        _line.SetPosition(0,start);
        _line.SetPosition(1,end);    
    }
}