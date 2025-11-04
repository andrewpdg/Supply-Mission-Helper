# GitHub Setup Instructions

This guide will help you set up your repository for automatic building and distribution of your Dalamud plugin.

## Step 1: Enable GitHub Pages

1. Go to your repository on GitHub: `https://github.com/andrewpdg/Supply-Mission-Helper`
2. Click on **Settings** (top menu)
3. Scroll down to **Pages** in the left sidebar
4. Under **Source**, select:
   - Branch: `main`
   - Folder: `/ (root)`
5. Click **Save**
6. GitHub will give you a URL like: `https://andrewpdg.github.io/Supply-Mission-Helper/`

## Step 2: Upload Files to GitHub

Upload these files to your repository:

```
Supply-Mission-Helper/
├── .github/
│   └── workflows/
│       └── build.yml          # Auto-build workflow
├── SupplyMissionHelper.cs     # Main plugin file
├── Configuration.cs
├── MainWindow.cs
├── SupplyMissionScanner.cs
├── SupplyMissionScannerV2.cs
├── AddonInspector.cs
├── SupplyMissionHelper.csproj # Project file
├── SupplyMissionHelper.json   # Plugin manifest
├── repo.json                  # Repository manifest (for Dalamud)
├── README.md
└── .gitignore
```

## Step 3: Create Your First Release

### Option A: Using GitHub Actions (Recommended)

1. Commit and push all your files to the `main` branch
2. Create a new tag and push it:
   ```bash
   git tag v0.0.1
   git push origin v0.0.1
   ```
3. GitHub Actions will automatically:
   - Build your plugin
   - Create a release
   - Upload `SupplyMissionHelper.zip`
   - Update `repo.json` with the latest version

### Option B: Manual Release

1. Build your plugin locally:
   ```bash
   dotnet build -c Release
   ```
2. Create a zip file containing:
   - `bin/Release/net8.0-windows/SupplyMissionHelper.dll`
   - `SupplyMissionHelper.json`
3. Go to your GitHub repo → **Releases** → **Create a new release**
4. Create tag `v0.0.1`
5. Upload the zip file as `SupplyMissionHelper.zip`
6. Publish the release

## Step 4: Verify GitHub Pages

After a few minutes, verify your repo.json is accessible:
- Open: `https://andrewpdg.github.io/Supply-Mission-Helper/repo.json`
- You should see your plugin information

## Step 5: Tell Users How to Install

Share these instructions with users:

### Installation Instructions for Users

1. Open FFXIV with Dalamud (XIVLauncher)
2. Type `/xlsettings` in chat
3. Go to the **Experimental** tab
4. Under **Custom Plugin Repositories**, add:
   ```
   https://andrewpdg.github.io/Supply-Mission-Helper/repo.json
   ```
5. Click the **+ button** then **Save and Close**
6. Open the plugin installer (`/xlplugins`)
7. Search for **Supply Mission Helper**
8. Click **Install**

## Step 6: Adding Images (Optional)

To make your plugin look more professional:

1. Create an `images` folder in your repository
2. Add:
   - `icon.png` (64x64 or 128x128) - Plugin icon
   - `screenshot1.png` - Screenshot of your plugin in action
3. The URLs are already configured in `repo.json`

## Updating Your Plugin

To release a new version:

1. Make your code changes
2. Commit and push to `main`
3. Create and push a new tag:
   ```bash
   git tag v0.0.2
   git push origin v0.0.2
   ```
4. GitHub Actions will automatically build and release

## Troubleshooting

### Build fails in GitHub Actions
- Check that your .csproj file is correct
- Verify all file names match exactly (case-sensitive)
- Check the Actions tab for detailed error logs

### Users can't find your plugin
- Verify `repo.json` is accessible via GitHub Pages URL
- Check that the release has `SupplyMissionHelper.zip` attached
- Verify the download link in `repo.json` is correct

### Plugin won't load in game
- Check that `DalamudApiLevel` matches current Dalamud version (currently 10)
- Verify all dependencies are included
- Check Dalamud logs: `%AppData%\XIVLauncher\dalamud.log`

## Repository Structure

Your final repository should look like:

```
main branch:
- All source code files
- repo.json (gets updated automatically)
- README.md
- .github/workflows/build.yml

Releases:
- v0.0.1
  - SupplyMissionHelper.zip
- v0.0.2
  - SupplyMissionHelper.zip
...

GitHub Pages:
- Serves repo.json from main branch
```

## Testing Locally

Before pushing, you can test locally:

1. Build: `dotnet build -c Release`
2. Copy DLL to: `%AppData%\XIVLauncher\devPlugins\SupplyMissionHelper\`
3. Copy JSON to the same folder
4. Enable in `/xlplugins` → Development Plugins

## Additional Resources

- [Dalamud Plugin Development](https://goatcorp.github.io/Dalamud/)
- [FFXIVClientStructs](https://github.com/aers/FFXIVClientStructs)
- [Plugin Template](https://github.com/goatcorp/SamplePlugin)

## Support

If users have issues, direct them to:
- GitHub Issues: `https://github.com/andrewpdg/Supply-Mission-Helper/issues`
- Your README.md for documentation
