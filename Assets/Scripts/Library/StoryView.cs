﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StoryView:MonoBehaviour
{
    public string id;
    public TextMeshProUGUI titleTxt;
    public TextMeshProUGUI descriptionTxt;
    public GameObject content;
    public void SetData(string id)
    {
        RectTransform rectTransform = content.GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, 0);
        }
        this.id = id;
        ApplyText.instance.UpdateStoryInfo(id);
    }
}