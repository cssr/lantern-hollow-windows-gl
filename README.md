# Lantern Hollow: MonoGame starter (Windows, DesktopGL)

The starting point for the class "Vibe Coding a 2D Game with an AI Agent" (MonoGame edition).
It is an empty game window with one passing test. During the class the agent builds the game around it.
This copy is for **Windows** and uses the **DesktopGL** (OpenGL) platform.

## Instructions

1. Install the **.NET 10 SDK**: https://dotnet.microsoft.com/download/dotnet/10.0
2. Get the project: `git clone <URL of this repo>` (or download the ZIP and unzip it).
3. Open a terminal **in the project folder** (the one that contains `LanternHollow.sln`) and run:

```
dotnet build -warnaserror
dotnet test
dotnet run --project Platforms/DesktopGL
```

You should see `Build succeeded`, then `Passed! ... Passed: 1`, then a blue window.
Press Esc to close the window.

The first build downloads many packages and builds the Content Builder, so it is slow.
Do it at home, not in class.

> Always run `dotnet build` once for the **whole solution** before running a single platform.
> The Content Builder needs that first solution-wide restore.

## What is in the project

| Path | What it is |
|---|---|
| `Source/Game1.cs` | The game loop: Update runs the rules, Draw only paints. Empty for now. |
| `Source/Tuning.cs` | All game numbers (MoveSpeed 220, Gravity 1800, JumpSpeed 588). |
| `Tests/SmokeTests.cs` | One test: proves the test project runs and sees `Tuning`. |
| `Platforms/DesktopGL/` | The entry point for Windows. No game logic here. |
| `Content/` | The Content Builder project. Raw art goes in `Content/Assets/`; each file is registered in `Content/Builder/Builder.cs`. Empty for now. |
| `Resources/` | Icon and the game's name (`Identity.props`). |
| `AGENTS.md` | The map the agent reads at the start of every task. You add one rule in Ex 2. |
| `LanternHollow.sln` | The solution. Lets `dotnet build` and `dotnet test` work from the project folder. |

## Troubleshooting

| Symptom | Fix |
|---|---|
| `dotnet` is not recognised | Install the .NET 10 SDK, then open a new terminal. |
| `MSB1003: specify a project or solution file` | You are not in the project folder (the one with `LanternHollow.sln`). |
| Restore or package errors | Check your network, then run `dotnet build` again. |
| Content build error on a clean clone | Run `dotnet build` for the whole solution again; the first run restores the Content Builder. |
| A test fails right after you cloned | Ask in class. The starter should always pass. |


