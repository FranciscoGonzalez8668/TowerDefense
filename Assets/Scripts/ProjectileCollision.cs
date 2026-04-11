using UnityEngine;


public class ProjectileCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            EnemyManager.instance.CheckFinish();
            gameObject.SetActive(false);
        }
    }
}