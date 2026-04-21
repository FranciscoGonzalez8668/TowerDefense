using UnityEngine;

public class EnemyDeath : MonoBehaviour 
{
    private Animator animator;


    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    public void TriggerDeath()
    {
        GetComponentInParent<Collider>().enabled = false;
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }
    }
    public void OnDeathComplete()
    {
        EnemyManager.instance.killedCount++;
        EnemyManager.instance.activeEnemies.Remove(transform.parent.gameObject);
        Destroy(transform.parent.gameObject);
    }

}