using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimateTree : MonoBehaviour, IObserver
{
    public void OnNotify()
    {   
        transform.DORotate(new Vector3(0f, 360f, 0f), 2f, RotateMode.FastBeyond360);
    }
}
