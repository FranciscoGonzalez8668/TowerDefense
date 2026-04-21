using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyManager;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;
    private float time = 0;
    private bool counting = true;

    public void StopCounting()
    {
        counting = false;
    }

    void Update()
    {
        if (counting) time += Time.deltaTime;

        scoreText.text = $"Killed: {enemyManager.killedCount}";
        timeText.text = $"Time: {Mathf.FloorToInt(time)}s";
    }


}
