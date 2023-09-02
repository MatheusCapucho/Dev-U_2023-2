using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionAnimateTree : MonoBehaviour
{
    private void OnEnable()
    {
        ActionObjective.Notify += OnNotify;
    }

    private void OnDisable()
    {
        ActionObjective.Notify -= OnNotify;
    }

    public void OnNotify()
    {
        transform.DORotate(new Vector3(0f, 360f, 0f), 2f, RotateMode.FastBeyond360);
    }
}
