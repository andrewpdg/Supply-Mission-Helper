# Supply Mission Helper

A Dalamud plugin for FFXIV that helps you calculate all materials needed to complete your daily Grand Company Supply Missions.

![Plugin Version](https://img.shields.io/github/v/release/andrewpdg/Supply-Mission-Helper?label=version)
![Downloads](https://img.shields.io/github/downloads/andrewpdg/Supply-Mission-Helper/total)

## Features

- 🔍 **Scan Supply Missions** - Automatically reads your current Grand Company supply missions
- 📋 **Material Calculation** - Calculates all raw materials needed for crafting (Coming Soon)
- ✅ **Shopping List** - Provides a comprehensive list of everything you need to gather
- 📊 **Progress Tracking** - See what you've already completed

## Installation

### For Players

1. Open FFXIV with **XIVLauncher/Dalamud**
2. Type `/xlsettings` in chat
3. Go to the **Experimental** tab
4. Under **Custom Plugin Repositories**, paste this URL:
   ```
   https://andrewpdg.github.io/Supply-Mission-Helper/repo.json
   ```
5. Click the **+ button**, then **Save and Close**
6. Open the plugin installer by typing `/xlplugins`
7. Search for **Supply Mission Helper**
8. Click **Install**

### For Developers

See [GITHUB_SETUP.md](GITHUB_SETUP.md) for development setup instructions.

## Usage

1. Open your **Grand Company Supply Mission** window (Sergeant at your Grand Company HQ)
2. Type `/supplymission` to open the helper window
3. Click **"Scan Supply Missions"** to read your current missions
4. View the list of items needed (material calculation coming soon!)

## Current Status

✅ Basic plugin structure  
✅ Main window UI  
✅ Configuration system  
✅ Supply Mission window detection  
✅ Debug addon inspector  
⏳ Supply Mission data scanning (In Progress)  
⏳ Recipe data parsing (TODO)  
⏳ Material calculation (TODO)  
⏳ Gathering location info (TODO)  

## Development Roadmap

- [x] **Phase 0**: Basic plugin structure and UI
- [ ] **Phase 1**: Read Supply Mission window data
- [ ] **Phase 2**: Parse recipe sheets and calculate materials  
- [ ] **Phase 3**: Display material list with quantities
- [ ] **Phase 4**: Add gathering location info (optional)
- [ ] **Phase 5**: Add inventory checking
- [ ] **Phase 6**: Integration with teamcraft or external tools

## Screenshots

*Coming soon*

## Commands

- `/supplymission` - Opens the Supply Mission Helper window

## Configuration

- **Show Raw Materials Only** - Only displays base materials (no intermediate crafts)
- **Include Gathering Locations** - Shows where to gather materials (coming soon)

## Support & Feedback

- **Bug Reports**: [Open an issue](https://github.com/andrewpdg/Supply-Mission-Helper/issues)
- **Feature Requests**: [Open an issue](https://github.com/andrewpdg/Supply-Mission-Helper/issues)
- **Questions**: Check the [FAQ](#faq) below

## FAQ

**Q: The plugin says "Please open the Grand Company Supply Mission window first!"**  
A: Make sure you have the supply mission window open before clicking the scan button.

**Q: No missions are found when I scan**  
A: This feature is still in development. The scanning logic needs to be completed.

**Q: Can this work with Squadron missions?**  
A: Currently only Grand Company Supply/Provisioning missions are supported.

**Q: Does this work with all Grand Companies?**  
A: Yes, it should work with Maelstrom, Twin Adders, and Immortal Flames.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Building from Source

### Prerequisites
- .NET 8.0 SDK
- Visual Studio 2022, Rider, or VS Code
- FFXIV with XIVLauncher/Dalamud installed

### Steps
```bash
git clone https://github.com/andrewpdg/Supply-Mission-Helper.git
cd Supply-Mission-Helper
dotnet restore
dotnet build -c Release
```

The compiled plugin will be in `bin/Release/net8.0-windows/`

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- Thanks to the Dalamud team for the plugin framework
- Thanks to the FFXIV modding community
- Thanks to all contributors and testers

## Disclaimer

This plugin is not affiliated with or endorsed by Square Enix. Use at your own risk.

---

**Note**: This plugin is currently in early development. Features may be incomplete or subject to change.
