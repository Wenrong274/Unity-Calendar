using hyhy.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

public class testGetDate : MonoBehaviour
{
    [SerializeField] private UnityCalendar unityCalendar;
    [SerializeField] private Text text;

    public void OnClick_GetDate()
    {
        DateTime dt = unityCalendar.GetDate();
        text.text = dt.ToString("yyyy-MM-dd");
    }

    public void OnClick_Clear()
    {
        text.text = string.Empty;
        unityCalendar.Init();
    }
}
