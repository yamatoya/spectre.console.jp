Title: Prompt
Order: 4

---

ユーザーの入力を受付たい時、 `Prompt<TResult>`　を私用します。

# 確認

```csharp
if (!AnsiConsole.Confirm("Run example?"))
{
    return;
}
```

```text
Run example? [y/n] (y): _
```

# シンプル

```csharp
// Ask for the user's name
string name = AnsiConsole.Ask<string>("What's your [green]name[/]?");

// Ask for the user's age
int age = AnsiConsole.Ask<int>("What's your [green]age[/]?");
```

```text
What's your name? Patrik
What's your age? 37
```

# 選択

```csharp
var fruit = AnsiConsole.Prompt(
    new TextPrompt<string>("What's your [green]favorite fruit[/]?")
        .InvalidChoiceMessage("[red]That's not a valid fruit[/]")
        .DefaultValue("Orange")
        .AddChoice("Apple")
        .AddChoice("Banana")
        .AddChoice("Orange"));
```

```text
What's your favorite fruit? [Apple/Banana/Orange] (Orange): _
```

# 入力チェック

```csharp
var age = AnsiConsole.Prompt(
    new TextPrompt<int>("What's the secret number?")
        .Validate(age =>
        {
            return age switch
            {
                < 99 => ValidationResult.Error("[red]Too low[/]"),
                > 99 => ValidationResult.Error("[red]Too high[/]"),
                _ => ValidationResult.Success(),
            };
        }));
```

```text
What's the secret number? 32
Too low
What's the secret number? 102
Too high
What's the secret number? _
```

# 秘密

```csharp
var password = AnsiConsole.Prompt(
    new TextPrompt<string>("Enter [green]password[/]")
        .PromptStyle("red")
        .Secret());
```

```text
Enter password: ************_
```

# 任意

```csharp
var color = AnsiConsole.Prompt(
    new TextPrompt<string>("[grey][[Optional]][/] [green]Favorite color[/]?")
        .AllowEmpty());
```

```text
[Optional] Favorite color? _
```
