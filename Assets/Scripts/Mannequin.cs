using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Mannequin : MonoBehaviour, IAttackable
{
    [SerializeField] private float hp;

    public void TryToGainDamage(float damage)
    {
        hp -= damage;
    }
}
