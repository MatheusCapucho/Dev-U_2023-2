using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObjective : MonoBehaviour
{
    public static Action Notify;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>() == null) return;

        Destroy(other.gameObject);
        Notify?.Invoke();
    }
}
