# Lantern Hollow
2D platformer. MonoGame 3.8, DesktopGL (Windows), .NET 10, C#.

## Commands
- Build: dotnet build -warnaserror
- Test:  dotnet test
- Run:   dotnet run --project Platforms/DesktopGL

## Map
- Source/Game1.cs    the game loop, shared by every platform project
- Source/Tuning.cs   all game numbers (pixels and seconds, Y points down)
- Tests/             xUnit tests, run with dotnet test
- Content/Assets/    raw art and sound; register each file in Content/Builder/Builder.cs
- Platforms/DesktopGL/  entry point only, no game logic

## Rules
- All game numbers live in Source/Tuning.cs.
- Never edit a test to make it pass.
- Keep changes small. Touch only files named
  in the task. Ask before adding a package.
- After every change: build, then test.

## Not now
No menus, no save system, no multiplayer.
