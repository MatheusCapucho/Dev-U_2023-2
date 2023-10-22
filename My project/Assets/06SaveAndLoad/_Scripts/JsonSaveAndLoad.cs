using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class JsonSaveAndLoad : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            SaveData();
        if (Input.GetKeyDown(KeyCode.L))
            LoadData();
    }
    public void SaveData()
    {
        ScoreData scoreData = new ScoreData(StaticScoreManager.Score);
        string json = JsonUtility.ToJson(scoreData);
        Debug.Log(json);

        string path = Application.persistentDataPath + "/scoreData.json";
        Debug.Log(path);

        File.WriteAllText(path, json);

    }
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/scoreData.json";

        if (!File.Exists(path))
            return;

        string json = File.ReadAllText(path);

        ScoreData scoreData = JsonUtility.FromJson<ScoreData>(json);
        StaticScoreManager.Score = scoreData.Score;

    }
}
