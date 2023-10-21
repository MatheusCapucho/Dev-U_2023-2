using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private void Awake()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StaticScoreManager.Score++;

        Destroy(this.gameObject);
    }
}
