# Unity-Calendar

![gif]

## 使用方式

預設日期為`當天日期`。

可以直接使用 `UnityCalendar.GetDate()` 取得使用者設定日期，假如有錯誤會回報錯誤。

`testGetDate.cs`

```csharp
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
```

______________________________________________________________________

[gif]:https://i.imgur.com/Pe4nXry.gif
