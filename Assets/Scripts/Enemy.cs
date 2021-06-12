using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //enemy stat
    public float maxHp;
    public float hpLeft;
    public float hpPercentage;

    //component
    public Transform hpBarMask;

    private void Start()
    {
        hpLeft = maxHp;
        hpPercentage = 1;
    }

    public void DealDamage(float damage)
    {
        hpLeft -= damage;
        hpPercentage = hpLeft / maxHp;
        hpBarMask.localPosition = new Vector3(hpPercentage-1, hpBarMask.localPosition.y, hpBarMask.localPosition.z);
    }
}
