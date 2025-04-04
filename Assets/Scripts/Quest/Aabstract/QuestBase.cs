﻿using System;
using System.IO;
using UnityEngine;

public abstract class QuestBase
{
    public string questId;
    [NonSerialized] public string description;
    public int reward;
    public bool isReward;

    public virtual void UpdateProgress(int progress)
    {

    }
    public virtual void UpdateProgress(int progress1, int progress2)
    {

    }
    public abstract bool CheckCompletion();
    public virtual void SaveQuest()
    {
        string path = Application.persistentDataPath + $"/quest_{questId}.json";
        string json = JsonUtility.ToJson(this, true);
        File.WriteAllText(path, json);
    }
    public virtual void LoadQuest()
    {
        string path = Application.persistentDataPath + $"/quest_{questId}.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
    public virtual void DeleteQuest()
    {
        string path = Application.persistentDataPath + $"/quest_{questId}.json";
        if (File.Exists(path))
        {
            File.Delete(path);
            Debug.Log($"Quest {questId} deleted.");
        }
    }
    public virtual Tuple<int,int> GetProgress()
    {
        return Tuple.Create(0,0);
    }
    public void OnBeforeSerialize() { }
}
