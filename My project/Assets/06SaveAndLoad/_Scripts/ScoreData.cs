using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData
{
    public int Score;
    public bool saved = false;
    public ScoreData(int score)
    {
        Score = score;
        saved = true;
    }

}
