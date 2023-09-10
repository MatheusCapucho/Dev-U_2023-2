using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : BaseSubject
{
    private AnimateTree[] _forest;

    [SerializeField] private ModifyUI modifyUI;

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

        AddObserver(modifyUI);

    }
    private void OnDisable()
    {
        foreach (IObserver tree in _forest)
        {
            RemoveObserver(tree);
        }
        RemoveObserver(modifyUI);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Bullet>() == null) return;

        Destroy(other.gameObject);
        Notify();
    }
}
