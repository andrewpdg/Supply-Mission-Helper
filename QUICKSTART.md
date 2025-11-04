# Quick Start Guide

Get your plugin published in 5 minutes!

## Step 1: Push to GitHub (1 minute)

```bash
# Initialize git if you haven't already
git init
git add .
git commit -m "Initial commit"

# Add your remote (replace with your actual repo URL)
git remote add origin https://github.com/andrewpdg/Supply-Mission-Helper.git

# Push to GitHub
git branch -M main
git push -u origin main
```

## Step 2: Enable GitHub Pages (1 minute)

1. Go to: https://github.com/andrewpdg/Supply-Mission-Helper/settings/pages
2. Under **Source**, select:
   - Branch: `main`
   - Folder: `/ (root)`
3. Click **Save**
4. Wait 1-2 minutes for deployment

## Step 3: Create Your First Release (2 minutes)

### Option A: Let GitHub Actions Do It (Easiest)

```bash
# Create and push a version tag
git tag v0.0.1
git push origin v0.0.1
```

Wait 2-3 minutes and GitHub Actions will:
- Build your plugin
- Create a release
- Upload the zip file
- Everything is done automatically!

### Option B: Manual Release (If GitHub Actions fails)

1. Build locally:
   ```bash
   dotnet build -c Release
   ```

2. Create a zip with these files:
   ```
   SupplyMissionHelper.zip
   ├── SupplyMissionHelper.dll
   └── SupplyMissionHelper.json
   ```

3. Go to: https://github.com/andrewpdg/Supply-Mission-Helper/releases/new
4. Create tag: `v0.0.1`
5. Upload the zip as `SupplyMissionHelper.zip`
6. Click **Publish release**

## Step 4: Test Installation (1 minute)

1. Open FFXIV with Dalamud
2. Type `/xlsettings`
3. Go to **Experimental** tab
4. Add this URL:
   ```
   https://andrewpdg.github.io/Supply-Mission-Helper/repo.json
   ```
5. Open `/xlplugins` and search for your plugin!

## Verify Everything Works

Check these URLs are accessible:

✅ **Repository JSON**:
```
https://andrewpdg.github.io/Supply-Mission-Helper/repo.json
```

✅ **Latest Release**:
```
https://github.com/andrewpdg/Supply-Mission-Helper/releases/latest
```

✅ **Download Link**:
```
https://github.com/andrewpdg/Supply-Mission-Helper/releases/latest/download/SupplyMissionHelper.zip
```

## Share With Users

Give them this simple instruction:

> **Install Supply Mission Helper:**
> 
> 1. Type `/xlsettings` in FFXIV
> 2. Go to Experimental tab
> 3. Add this URL to Custom Plugin Repositories:
>    ```
>    https://andrewpdg.github.io/Supply-Mission-Helper/repo.json
>    ```
> 4. Type `/xlplugins` and search for "Supply Mission Helper"
> 5. Click Install!

## Troubleshooting

**"GitHub Actions failed"**
- Check the Actions tab for errors
- Make sure you have Windows runner enabled (it's free)
- Try manual release method

**"repo.json not found"**
- Wait 2-3 minutes for GitHub Pages to deploy
- Check Settings → Pages is enabled
- Verify the file is in your main branch

**"Plugin won't install"**
- Make sure the release has `SupplyMissionHelper.zip`
- Check the zip contains both .dll and .json files
- Verify the download URL in repo.json is correct

**"Build fails"**
- Make sure Dalamud libraries are found
- Check .csproj DalamudLibPath is correct
- Try building locally first to catch errors

## Next Steps

- Add an icon (64x64 PNG) to `/images/icon.png`
- Add screenshots to `/images/screenshot1.png`
- Update README.md with better documentation
- Implement the remaining features!

## Updating Your Plugin

For future updates:

```bash
# Make your changes
git add .
git commit -m "Add new feature"
git push

# Create new version tag
git tag v0.0.2
git push origin v0.0.2
```

That's it! GitHub Actions handles the rest.

---

Need help? Check [GITHUB_SETUP.md](GITHUB_SETUP.md) for detailed instructions.
