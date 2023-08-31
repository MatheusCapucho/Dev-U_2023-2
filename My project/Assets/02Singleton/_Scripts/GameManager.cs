using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    [SerializeField] private float _enemySpeed;
    public float EnemySpeed => _enemySpeed;

    [SerializeField] private int maxJumps;
    public int MaxJumps => maxJumps;

    /*
    public static GameManager GetInstance() 
    { 
        return _instance;
    }
    */

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;

        } else
        {
            Destroy(this);
        }

        DontDestroyOnLoad(_instance);

    }

}
