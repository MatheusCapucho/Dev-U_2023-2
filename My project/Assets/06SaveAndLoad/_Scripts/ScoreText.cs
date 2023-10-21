using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI _textComponent;

    private void Awake()
    {
        _textComponent = GetComponent<TextMeshProUGUI>();
    }
    void FixedUpdate()
    {
        _textComponent.text = "Score = " + StaticScoreManager.Score; 
    }
}
