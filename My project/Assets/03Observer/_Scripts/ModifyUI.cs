using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ModifyUI : MonoBehaviour, IObserver
{
    private TextMeshProUGUI _tmp;
    private void Awake()
    {
        _tmp = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        _tmp.text = "Esperando . . .";
    }
    public void OnNotify()
    {
        _tmp.text = "Notificado";
    }

}
