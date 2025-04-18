﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSweep : HiddenObject
{
    public override void ActiveSkill()
    {
        if (isDestroying)
        {
            Debug.Log("Không thể kích hoạt skill vì đối tượng đang biến mất.");
            return;
        }
        PlaySFX();
        ClearSurroundingAndHeal();
        DestroyObject();

    }
    public void ClearSurroundingAndHeal()
    {
        var currentPos = PlayerController.instance.movementController.GetPos();
        int currentRow = currentPos.Item1;
        int currentCol = currentPos.Item2;

        List<GameObject> objectsAround = LevelManager.instance.GetHiddenObjectsAround(currentRow, currentCol);
        foreach (GameObject obj in objectsAround)
        {
            if (obj != null)
            {
                obj.GetComponentInParent<BoxCollider2D>().enabled = true;
                Destroy(obj);
            }
        }

        PlayerController.instance.hitPoint.Heal(1);

        Debug.Log("Xoá bỏ tất cả bùa lợi/chướng ngại vật xung quanh nhân vật và hồi phục 1 HP.");
    }

}
