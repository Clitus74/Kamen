﻿using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class TextLocalizer:ITextLocalizer
{
    private readonly Dictionary<string, string> _richText;
    private readonly Dictionary<string, string> _plainText;

    public TextLocalizer(Dictionary<string, string> richText, Dictionary<string, string> plainText)
    {
        _richText = richText;
        _plainText = plainText;
    }

    public void SetLocalizedText(string key, TMP_Text text)
    {
        if (_richText.ContainsKey(key) && _plainText.ContainsKey(key))
            text.SetText(_plainText[key]);
        else
            text.SetText("Thông tin không khả dụng.");
    }

    public void SetLocalizedText(string key, TMP_Text[] texts)
    {
        foreach (var t in texts)
            SetLocalizedText(key, t);
    }
    public void SetLocalizedText(string key, Text text)
    {
        if (_richText.ContainsKey(key) && _plainText.ContainsKey(key))
            text.text = _plainText[key];
        else
            text.text = "Thông tin không khả dụng.";
    }

    public void SetLocalizedText(string key, Text[] texts)
    {
        foreach (var t in texts)
            SetLocalizedText(key, t);
    }
}