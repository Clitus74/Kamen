using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUI : MonoBehaviour
{
    [SerializeField] private string questID;
    [SerializeField] private TextMeshProUGUI des;
    [SerializeField] private TextMeshProUGUI reward;
    [SerializeField] private TextMeshProUGUI progress;
    [SerializeField] private GameObject completeObj;
    [SerializeField] private Slider scrollBar;

    public string QuestID { get => questID; set => questID = value; }
    private void Start()
    {
        scrollBar.interactable = false;
    }
    public void SetQuestData(string questID, string des, string reward, Tuple<int, int> progress)
    {
        this.QuestID = questID;
        this.des.text = des;
        this.reward.text = reward;
        if (progress.Item2 < 1000)
        {
            this.progress.text = progress.Item1 + "/" + progress.Item2;
        }
        else
        {
            this.progress.text = progress.Item1 + "/\n" + progress.Item2;
        }
        if (progress.Item2 > 0)
        {
            float fillAmount = Mathf.Clamp01((float)progress.Item1 / progress.Item2);
            scrollBar.value = fillAmount;
        }
        else
        {
            scrollBar.value = 0;
        }
    }
    private void FixedUpdate()
    {
        QuestBase quest = AchievementManager.instance.GetQuestById(QuestID);
        this.des.text = quest.description;
        Tuple<int, int> progress = quest.GetProgress();
        if (progress.Item2 < 1000)
        {
            this.progress.text = progress.Item1 + "/" + progress.Item2;
        }
        else
        {
            this.progress.text = progress.Item1 + "/\n" + progress.Item2;
        }
        if (progress.Item2 > 0)
        {
            float fillAmount = Mathf.Clamp01((float)progress.Item1 / progress.Item2);
            scrollBar.value = fillAmount;
        }
        else
        {
            scrollBar.value = 0;
        }
        if (progress.Item1 >= progress.Item2)
        {
            completeObj.SetActive(true);
        }
        else
        {
            completeObj.SetActive(false);
        }
        if (quest.isReward)
            Destroy(this.gameObject);
    }
}
