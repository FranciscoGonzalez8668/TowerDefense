using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyManager;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    private float time = 0;
    private bool counting = true;

    public void StopCounting()
    {
        counting = false;
    }

    public float GetTime() => time;

    void Update()
    {
        if (counting) time += Time.deltaTime;

        scoreText.text = $"Killed: {enemyManager.killedCount}";
        timeText.text = $"Time: {Mathf.FloorToInt(time)}s";
        if (highScoreText != null && SaveManager.instance != null)
            highScoreText.text = $"Best: {SaveManager.instance.data.highScore} kills | {Mathf.FloorToInt(SaveManager.instance.data.bestTime)}s";
    }


}
