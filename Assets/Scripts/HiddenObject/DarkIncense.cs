﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class DarkIncense: HiddenObject
{
    public GameObject jyamatoPrefab;

    public override void ActiveSkill()
    {
        if (isDestroying)
        {
            Debug.Log("Không thể kích hoạt skill vì đối tượng đang biến mất.");
            return;
        }
        PlaySFX();
        var currentPos = PlayerController.instance.movementController.GetPos();
        int currentRow = currentPos.Item1;
        int currentCol = currentPos.Item2;
        int mapRows = LevelManager.instance.GetGrid().rows;
        int mapCols = LevelManager.instance.GetGrid().cols;
        Vector2Int[] spawnPositions = new Vector2Int[]
       {
        new Vector2Int(  currentRow+1,currentCol),
        new Vector2Int(currentRow -1, currentCol),
        new Vector2Int(currentRow , currentCol-1),
        new Vector2Int(currentRow , currentCol+1)
 
        };
        foreach (Vector2Int spawnPos in spawnPositions)
        {
            if (LevelManager.instance.CheckForHiddenObject(spawnPos.x, spawnPos.y) == null)
            {
                if (spawnPos.x >= 0 && spawnPos.x < mapRows && spawnPos.y >= 0
                    && spawnPos.y < mapCols && spawnPos !=LevelManager.instance.GetCurrentLevelData().endPos)
                {
                    GameObject cell = LevelManager.instance.GetGrid().grid[(int)spawnPos.x, (int)spawnPos.y];

                    GameObject hiddenObject = Instantiate(jyamatoPrefab, cell.transform.position, Quaternion.identity);
                    
                    hiddenObject.SetActive(true);
                    float screenWidth = Camera.main.orthographicSize * 2 * 9f / 16f;
                    float cellSize = (float)(screenWidth - 0.1 * (6 - 1)) / 6 - 0.1f;
                    hiddenObject.transform.localScale = new Vector3(cellSize, cellSize, 1);
                    LevelManager.instance.AddHiddenObjectToCurrentLevel(spawnPos.x, spawnPos.y, hiddenObject);
                    hiddenObject.transform.SetParent(cell.transform);
                }
            }
           
            
        }
 
        DestroyObject();


    }
}
