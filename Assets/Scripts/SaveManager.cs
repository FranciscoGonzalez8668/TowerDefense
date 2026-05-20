using UnityEngine;
using System.IO;

[System.Serializable]
public class GameData
{
    public int highScore;
    public int totalKills;
    public float bestTime;
}

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    public GameData data = new GameData();

    private string _savePath;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        _savePath = Application.persistentDataPath + "/save.json";
        LoadData();
    }

    public void SaveData()
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(_savePath, json);
    }

    public void LoadData()
    {
        if (File.Exists(_savePath))
        {
            string json = File.ReadAllText(_savePath);
            data = JsonUtility.FromJson<GameData>(json);
        }
    }
}
