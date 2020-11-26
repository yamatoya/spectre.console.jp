Title: Figlet
Order: 3
RedirectFrom: figlet
---

Spectre.Console は、 `FigletText` クラスを使用することで、[FIGlet](http://www.figlet.org/) を描画できます。

# 既定のフォント

```csharp
AnsiConsole.Render(
    new FigletText("Hello")
        .LeftAligned()
        .Color(Color.Red));
```

```text
 _   _          _   _          
| | | |   ___  | | | |   ___  
| |_| |  / _ \ | | | |  / _ \ 
|  _  | |  __/ | | | | | (_) |
|_| |_|  \___| |_| |_|  \___/ 
```

# フォントのカスタマイズ

```csharp
var font = FigletFont.Load("starwars.flf");

AnsiConsole.Render(
    new FigletText(font, "Hello")
        .LeftAligned()
        .Color(Color.Red));
```