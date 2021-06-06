using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Wizard : Player
{
    public override void OnAttack()
    {
        base.OnAttack();
        Debug.Log("aaa");
    }
}
