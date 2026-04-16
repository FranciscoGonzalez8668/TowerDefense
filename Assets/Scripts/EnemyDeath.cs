using UnityEngine;

class EnemyDeath : MonoBehaviour 
{
    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TriggerDeath()
    {
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }

    }
    public void OnDeathComplete()
    {
        Destroy(gameObject);
    }

}