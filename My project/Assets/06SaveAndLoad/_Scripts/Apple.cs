using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] private int index;
    [SerializeField] private AppleSO appleSO;
    private void Awake()
    {
        if (AppleManager.Picked[index] == true)
            Destroy(this.gameObject);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StaticScoreManager.Score++;
        appleSO.index = 10;
        AppleManager.Picked[index] = true;
        Destroy(this.gameObject);
     
    }
}
