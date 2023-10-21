using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private static LevelManager _instance;
    public static LevelManager Instance => _instance;
    private void Awake()
    {
        if (_instance == null) _instance = this;
        else Destroy(this);

        DontDestroyOnLoad(_instance);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            SceneManager.LoadScene("SaveScene02");
        if (Input.GetKeyDown(KeyCode.N))
            SceneManager.LoadScene("SaveScene01");
    }

}
