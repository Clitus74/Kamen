﻿using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    private string timeAPI = "https://timeapi.io/api/Time/current/zone?timeZone=Asia/Ho_Chi_Minh";
    public static TimeManager Instance;
    public string ServerDate { get; private set; }
    public DateTime ServerDateTime { get; private set; } // Lưu thời gian đầy đủ
    public bool IsTimeFetched  = false; // Đánh dấu đã lấy xong thời gian

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartCoroutine(GetServerTime()); // Lấy thời gian ngay khi game khởi động
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator GetServerTime()
    {
        int maxRetries = 3; // Số lần thử lại tối đa
        int retryCount = 0;
        float retryDelay = 0.5f; // Thời gian chờ giữa mỗi lần thử 

        while (retryCount < maxRetries)
        {
            using (UnityWebRequest request = UnityWebRequest.Get(timeAPI))
            {
                request.certificateHandler = new BypassCertificate();
                yield return request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.Success)
                {
                    string jsonResult = request.downloadHandler.text;
                    ServerTimeData timeData = JsonUtility.FromJson<ServerTimeData>(jsonResult);
                    ServerDateTime = DateTime.Parse(timeData.dateTime);
                    ServerDate = ServerDateTime.ToString("yyyy-MM-dd");
                    IsTimeFetched = true;
                    Debug.Log("✅ Lấy thời gian từ server thành công: " + ServerDate);
                    yield break; // Thoát coroutine nếu thành công
                }
                else
                {
                    retryCount++;
                    Debug.LogWarning($"⚠️ Lỗi lấy thời gian từ server! Thử lại ({retryCount}/{maxRetries})...");
                    yield return new WaitForSeconds(retryDelay);
                }
            }
        }

        // Fallback: Lấy thời gian từ thiết bị
        ServerDateTime = DateTime.UtcNow.AddHours(7);
        ServerDate = ServerDateTime.ToString("yyyy-MM-dd");
        IsTimeFetched = true;
        Debug.LogWarning("⛔ Không thể lấy thời gian từ server, dùng thời gian thiết bị: " + ServerDate);
    }

    public TimeSpan GetTimeUntilMidnight()
    {
        if (!IsTimeFetched) return TimeSpan.Zero;
        DateTime now = DateTime.Now;
        DateTime nextNoon = now.Date.AddHours(12); 

        if (now >= nextNoon)
        {
            nextNoon = now.Date.AddDays(1).AddHours(12); 
        }

        return nextNoon - now;
    }
    public string GetEffectiveDateForDailyQuest()
    {
        DateTime effectiveDateTime = IsTimeFetched ? ServerDateTime : DateTime.UtcNow.AddHours(7);

        Debug.Log("Hour:" + effectiveDateTime.Hour+" -Minute:"+ effectiveDateTime.Minute);

        if (effectiveDateTime.Hour < 12)
        {
            effectiveDateTime = effectiveDateTime.AddDays(-1); // Trước 12h trưa → tính là hôm trước
        }

        return effectiveDateTime.ToString("yyyy-MM-dd");
    }


    [Serializable]
    private class ServerTimeData
    {
        public string dateTime;
    }

    private class BypassCertificate : CertificateHandler
    {
        protected override bool ValidateCertificate(byte[] certificateData) => true;
    }
}
