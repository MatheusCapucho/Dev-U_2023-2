using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaveAndLoad : MonoBehaviour
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
        PlayerPrefs.SetInt("saveScore", StaticScoreManager.Score);
    }
    public void LoadData()
    {
        if (!PlayerPrefs.HasKey("saveScore")) return;

        var score = PlayerPrefs.GetInt("saveScore");
        StaticScoreManager.Score = score;
    }
}
