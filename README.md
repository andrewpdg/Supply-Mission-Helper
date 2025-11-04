# Supply Mission Helper

A Dalamud plugin for FFXIV that helps you calculate all materials needed to complete your daily Grand Company Supply Missions.

## Features (Planned)
- Scan current Supply Mission requests
- Calculate all raw materials needed for crafting
- Display a comprehensive shopping list
- Track which materials you've gathered

## Setup for Development

### Prerequisites
1. FFXIV with XIVLauncher/Dalamud installed
2. .NET 8.0 SDK
3. Visual Studio 2022 or Rider (recommended) or VS Code

### Building the Plugin

1. Clone this repository
2. Make sure the `DalamudLibPath` in the `.csproj` points to your Dalamud dev folder
   - Default: `$(appdata)\XIVLauncher\addon\Hooks\dev\`
3. Build the project:
   ```bash
   dotnet build
   ```

### Installing for Testing

1. Build the project in Release mode
2. Copy the output DLL to your Dalamud devPlugins folder:
   - Default location: `%APPDATA%\XIVLauncher\devPlugins\SupplyMissionHelper\`
3. Enable the plugin in-game using `/xlplugins`

## Usage

1. Open your Grand Company Supply Mission window
2. Use the command `/supplymission` to open the helper window
3. Click "Scan Supply Missions" to read the current missions
4. View your material list!

## Current Status

✅ Basic plugin structure
✅ Main window UI
✅ Configuration system
⏳ Supply Mission scanning (TODO)
⏳ Recipe data parsing (TODO)
⏳ Material calculation (TODO)
⏳ UI for material list (TODO)

## Development Roadmap

1. **Phase 1**: Read Supply Mission window data
2. **Phase 2**: Parse recipe sheets and calculate materials
3. **Phase 3**: Display material list with quantities
4. **Phase 4**: Add gathering location info (optional)
5. **Phase 5**: Add inventory checking

## Contributing

Feel free to submit issues or pull requests!

## License

[Choose your license]
