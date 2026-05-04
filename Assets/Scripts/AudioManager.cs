using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instance;

    [SerializeField] private AudioSource backgroundMusicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Music")]
    [SerializeField] private AudioClip gameMusicClip;

    [Header("SFX Clips")]
    [SerializeField] private AudioClip deathClip;
    [SerializeField] private AudioClip defeatClip;

    void Awake()
    {
        if (instance !=null){Destroy(gameObject); return;}
        instance = this;
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        if(gameMusicClip != null)
        {
            backgroundMusicSource.clip = gameMusicClip;
            backgroundMusicSource.loop = true;
            backgroundMusicSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        if(clip == null) return;
        sfxSource.PlayOneShot(clip);
    }

    public void PlayEnemyDeath()=>PlaySFX(deathClip);
    public void PlayDefeat()
    {
        backgroundMusicSource.Stop();
        PlaySFX(defeatClip);
    }

}