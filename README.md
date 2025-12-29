# NotesApp

![image](https://github.com/enochwong3111/Notes-dotNet-project/blob/main/ReadmeResources/appImg.png)

NotesApp is a Windows desktop note-taking application built with C# (7.3) and .NET Framework 4.8 using Windows Forms. It supports creating and managing notes, setting reminders, and tracking note progress states (e.g., Draft, In Progress, Done).

## Features
- Create, edit, and delete notes
- Set time-based reminders for notes in "In Progress" state (desktop popup notification)
- Note progress states (Draft, In Progress, Done), with visual priority indicators
- Configurable time display through app settings (`timeFormat`, `fontFamily`, `fontSize`)
- Displays application version (from assembly)
- Test mode option for development and debugging

## System Requirements
- Windows 10 or later
- .NET Framework 4.8
- Visual Studio 2026 (recommended) or a compatible IDE for building

## Quick Start (Development)
1. Clone the repository:

   git clone https://github.com/enochwong3111/Notes-dotNet-project.git

2. Open the solution file (`.sln`) in Visual Studio.
3. Restore NuGet packages if prompted. Use the Visual Studio UI or run in the Package Manager Console: __Tools > NuGet Package Manager > Package Manager Console__ and execute package restore if necessary.
4. Set `NotesApp` as the startup project and press F5 or use __Debug > Start Debugging__ to run the application.

## Configuration (App.config)
You can change display and behavior using `App.config` appSettings keys:
- `timeFormat` ¡X .NET DateTime format string for current time display (e.g., `HH:mm:ss` or `yyyy-MM-dd HH:mm`)
