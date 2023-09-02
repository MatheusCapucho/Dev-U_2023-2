using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerAttribute.asset", menuName = "Player/NewPlayerAttribute")]
public class PlayerAttributesSO : ScriptableObject
{

    [SerializeField] private string _name;
    [SerializeField] private float _strenght;
    [SerializeField] private float _speed;
    [SerializeField] private float _maxHealth;

    public string Name => _name;
    public float Strenght => _strenght;
    public float Speed => _speed;
    public float MaxHealth => _maxHealth;
    //teste
    //hshs
}
