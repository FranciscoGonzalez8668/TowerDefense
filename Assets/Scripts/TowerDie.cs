using UnityEngine;

public class TowerDie : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<ScoreManager>().StopCounting();
            FindObjectOfType<TurretShooter>().enabled = false;

            Camera cam = transform.parent.GetComponentInChildren<Camera>();
            if (cam != null)
                cam.transform.SetParent(null);

            if (SaveManager.instance != null)
            {
                int kills = EnemyManager.instance.killedCount;
                if (kills > SaveManager.instance.data.highScore)
                    SaveManager.instance.data.highScore = kills;

                float currentTime = FindObjectOfType<ScoreManager>().GetTime();
                if (currentTime > SaveManager.instance.data.bestTime)
                    SaveManager.instance.data.bestTime = currentTime;

                SaveManager.instance.SaveData();
            }

            transform.parent.gameObject.SetActive(false);
        }
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlayDefeat();
        }
    }

}
