using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplesData
{
    public Apple[] Apples = new Apple[2];

    public void SetApple(Apple apple, int index)
    {
        Debug.Log(Apples[index]);
        if (Apples[index] == null)
            Apples[index] = apple;
        Debug.Log(Apples[index]);
    }

    public void SetApple(Apple[] apples) 
    {
        Apples = new Apple[2];
        Apples = apples;
    }
    public Apple[] GetApples()
    {
        return Apples;
    }
  
}
