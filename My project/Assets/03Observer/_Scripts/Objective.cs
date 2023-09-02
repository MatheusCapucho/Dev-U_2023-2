using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : BaseSubject
{
    private AnimateTree[] _forest;
    private void Awake()
    {
        _forest = FindObjectsOfType<AnimateTree>();
    }
    private void OnEnable()
    {
        foreach (IObserver tree in _forest)
        {
            AddObserver(tree);
        }
    }
    private void OnDisable()
    {
        foreach (IObserver tree in _forest)
        {
            RemoveObserver(tree);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Bullet>() == null) return;

        Destroy(other.gameObject);
        Notify();
    }
}
