﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBomb : HiddenObject
{
    public override void ActiveSkill()
    {
        if (isDestroying)
        {
            Debug.Log("Không thể kích hoạt skill vì đối tượng đang biến mất.");
            return;
        }
        PlaySFX();
        PlayerController.instance.hitPoint.TakeDamage(10);
        DestroyObject();
    }
}
