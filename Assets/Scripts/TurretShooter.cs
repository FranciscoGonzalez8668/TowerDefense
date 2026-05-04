using UnityEngine;

public class TurretShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;

    [SerializeField] private Animator canonAnimation;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip shootClip;


    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.parent.rotation);

            canonAnimation.SetTrigger("Fire");

            audioSource.PlayOneShot(shootClip);
        }
    }
}