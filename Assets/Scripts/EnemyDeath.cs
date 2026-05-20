using UnityEngine;

public class EnemyDeath : MonoBehaviour 
{


    [SerializeField] private ParticleSystem deathEffect;
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
        if(AudioManager.instance !=null)
        {
            AudioManager.instance.PlayEnemyDeath();
        }
    }
    public void OnDeathComplete()
    {
        EnemyManager.instance.killedCount++;
        EnemyManager.instance.activeEnemies.Remove(transform.parent.gameObject);
        SaveManager.instance.data.totalKills = EnemyManager.instance.killedCount;
        SaveManager.instance.SaveData();
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
        Destroy(transform.parent.gameObject);
    }

}