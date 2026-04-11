using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    public List<GameObject> activeEnemies = new List<GameObject>();

    void Awake()
    {
        instance = this;
    }

    public void CheckFinish()
    {
        int inactive = 0;
        foreach(GameObject enemy in activeEnemies)
        {
            if(!enemy.activeInHierarchy)
                inactive++;

        }

        if( inactive >= activeEnemies.Count*2/3)
        {
            Debug.Log("Nivel Completado");
        }
    }
}