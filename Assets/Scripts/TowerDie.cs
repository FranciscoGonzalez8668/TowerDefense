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

            transform.parent.gameObject.SetActive(false);
        }
    }

}
