Title: Calendar
Order: 2
RedirectFrom: calendar
---

`Calendar` はターミナルにカレンダーを描画するのに使用できます。

# 使用方法

カレンダーを描画するために、対象日を指定して `Calendar` インスタンスを作成します。

```csharp
var calendar = new Calendar(2020,10);
AnsiConsole.Render(calendar);
```

```text
               2020 October
┌─────┬─────┬─────┬─────┬─────┬─────┬─────┐
│ Sun │ Mon │ Tue │ Wed │ Thu │ Fri │ Sat │
├─────┼─────┼─────┼─────┼─────┼─────┼─────┤
│     │     │     │     │ 1   │ 2   │ 3   │
│ 4   │ 5   │ 6   │ 7   │ 8   │ 9   │ 10  │
│ 11  │ 12  │ 13  │ 14  │ 15  │ 16  │ 17  │
│ 18  │ 19  │ 20  │ 21  │ 22  │ 23  │ 24  │
│ 25  │ 26  │ 27  │ 28  │ 29  │ 30  │ 31  │
│     │     │     │     │     │     │     │
└─────┴─────┴─────┴─────┴─────┴─────┴─────┘
```

## 言語

ローカライズされた曜日を表示するために、カレンダーの言語を設定できます。

```csharp
var calendar = new Calendar(2020,10);
calendar.Culture("ja-JP");
AnsiConsole.Render(calendar);
```

```text
               Oktober 2020
┌─────┬─────┬─────┬─────┬─────┬─────┬─────┐
│ Mån │ Tis │ Ons │ Tor │ Fre │ Lör │ Sön │
├─────┼─────┼─────┼─────┼─────┼─────┼─────┤
│     │     │     │ 1   │ 2   │ 3   │ 4   │
│ 5   │ 6   │ 7   │ 8   │ 9   │ 10  │ 11* │
│ 12  │ 13  │ 14  │ 15  │ 16  │ 17  │ 18  │
│ 19  │ 20  │ 21  │ 22  │ 23  │ 24  │ 25  │
│ 26  │ 27  │ 28  │ 29  │ 30  │ 31  │     │
│     │     │     │     │     │     │     │
└─────┴─────┴─────┴─────┴─────┴─────┴─────┘
```

## ヘッダー

カレンダーヘッダーを非表示にできます。

```csharp
var calendar = new Calendar(2020,10);
calendar.ShowHeader();
AnsiConsole.Render(calendar);
```

```text
┌─────┬─────┬─────┬─────┬─────┬─────┬─────┐
│ Sun │ Mon │ Tue │ Wed │ Thu │ Fri │ Sat │
├─────┼─────┼─────┼─────┼─────┼─────┼─────┤
│     │     │     │     │ 1   │ 2   │ 3   │
│ 4   │ 5   │ 6   │ 7   │ 8   │ 9   │ 10  │
│ 11  │ 12  │ 13  │ 14  │ 15  │ 16  │ 17  │
│ 18  │ 19  │ 20  │ 21  │ 22  │ 23  │ 24  │
│ 25  │ 26  │ 27  │ 28  │ 29  │ 30  │ 31  │
│     │     │     │     │     │     │     │
└─────┴─────┴─────┴─────┴─────┴─────┴─────┘
```

カレンダーのヘッダーのスタイルを設定できます。

```csharp
var calendar = new Calendar(2020, 10);
calendar.HeaderStyle(Style.Parse("blue bold"));
AnsiConsole.Render(calendar);
```


## カレンダーイベント

カレンダーにイベントを追加できます。
その日にイベントが設定されていると、カレンダーで日付がハイライトされます。

```csharp
var calendar = new Calendar(2020,10);
calendar.AddCalendarEvent(2020, 10, 11);
AnsiConsole.Render(calendar);
```

```text
               2020 October
┌─────┬─────┬─────┬─────┬─────┬─────┬─────┐
│ Sun │ Mon │ Tue │ Wed │ Thu │ Fri │ Sat │
├─────┼─────┼─────┼─────┼─────┼─────┼─────┤
│     │     │     │     │ 1   │ 2   │ 3   │
│ 4   │ 5   │ 6   │ 7   │ 8   │ 9   │ 10  │
│ 11* │ 12  │ 13  │ 14  │ 15  │ 16  │ 17  │
│ 18  │ 19  │ 20  │ 21  │ 22  │ 23  │ 24  │
│ 25  │ 26  │ 27  │ 28  │ 29  │ 30  │ 31  │
│     │     │     │     │     │     │     │
└─────┴─────┴─────┴─────┴─────┴─────┴─────┘
```

### ハイライトのスタイル

`SetHighlightStyle`経由で、カレンダーイベントのハイライトスタイルを設定できます。

```csharp
var calendar = new Calendar(2020, 10);
calendar.AddCalendarEvent(2020, 10, 11);
calendar.HighlightStyle(Style.Parse("yellow bold"));
AnsiConsole.Render(calendar);
```
