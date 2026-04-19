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
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }

    }
    public void OnDeathComplete()
    {
        Debug.Log("Enemy died");
        Destroy(transform.parent.gameObject);   
    }

}