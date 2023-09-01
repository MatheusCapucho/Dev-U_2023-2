using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    [SerializeField] protected PlayerAttributesSO _playerAttributes;

    private void Start()
    {
        // ...
    }
    public abstract void Punch();

}
