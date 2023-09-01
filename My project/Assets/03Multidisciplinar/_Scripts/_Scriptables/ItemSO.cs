using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "newItem.asset", menuName = "Item/NewItem")]
public class ItemSO : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite Sprite;
}
