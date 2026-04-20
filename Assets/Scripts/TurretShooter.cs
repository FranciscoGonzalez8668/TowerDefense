using UnityEngine;

public class TurretShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;

    [SerializeField] private Animator canonAnimation;


    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.parent.rotation);

            canonAnimation.SetTrigger("Fire");

        }
    }
}