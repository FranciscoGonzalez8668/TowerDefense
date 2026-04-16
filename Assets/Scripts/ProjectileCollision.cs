using UnityEngine;


public class ProjectileCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyDeath>().TriggerDeath();
            gameObject.SetActive(false);
        }
    }
}