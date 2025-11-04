# Supply Mission Scanner Implementation Guide

## Current Status

The basic structure is complete, but we need to implement the actual addon reading logic. Here's what needs to be done:

## Step 1: Understanding the Addon Structure

The `GrandCompanySupplyList` addon contains the supply mission data. To implement the scanner, we need to:

1. **Open the game and the Supply Mission window**
2. **Use the Debug Inspector** - Click "Inspect Addon (Debug)" in the plugin to see the structure
3. **Identify the data location** - Look for:
   - Item IDs or icons
   - Item names (text nodes)
   - Quantity values
   - HQ indicators

## Step 2: Finding the Right Approach

There are several ways to read the data:

### Option A: Agent-Based Reading (Recommended)
- Read directly from game memory using `AgentGrandCompanySupply`
- Most reliable but requires finding memory offsets
- Typically found in ClientStructs documentation or by reverse engineering

### Option B: Addon Node Reading
- Parse the UI nodes to extract displayed information
- More stable across updates
- Easier to implement but may be slower

### Option C: Hybrid Approach
- Use agents for item IDs and core data
- Use addon nodes for display-specific info
- Best of both worlds

## Step 3: Implementation Tasks

### Task 1: Find Item Data Location

In `SupplyMissionScanner.cs`, we need to complete:

```csharp
private SupplyMissionItem? TryParseListItem(AtkUnitBase* addon, int index)
{
    // Need to find:
    // 1. Node index or path that contains item ID
    // 2. Node that contains item name
    // 3. Nodes for quantity values
    // 4. HQ indicator
}
```

### Task 2: Use FFXIVClientStructs

Look for existing structures in FFXIVClientStructs:
- `AgentGrandCompanySupply` - may contain supply mission data
- Check ClientStructs documentation or source code
- Look for similar implementations in other plugins

### Task 3: Test and Validate

Once implemented:
1. Test with various supply missions
2. Verify HQ detection works correctly
3. Test with both Supply and Provisioning missions
4. Handle edge cases (empty slots, partially completed missions)

## Useful Resources

- **FFXIVClientStructs**: https://github.com/aers/FFXIVClientStructs
- **Dalamud Plugin Dev**: https://goatcorp.github.io/Dalamud/
- **Other Plugins**: Look at plugins that read similar data (e.g., TeamCraft integration plugins)

## Alternative: Quick Implementation

If you want to get started quickly, you can use a simpler approach:

1. **Read Item IDs from player's turn-in list**
   - When player selects an item to turn in, capture that data
   - Store it temporarily for material calculation

2. **Manual Entry**
   - Let user manually input item names
   - Plugin provides material calculation
   - Less automated but still useful

## Next Steps After Scanning Works

Once scanning is implemented:
1. Implement recipe lookup (use Lumina to read Recipe sheet)
2. Build material tree (recursive gathering of ingredients)
3. Display aggregated material list
4. Add inventory checking (optional)

## Testing Checklist

- [ ] Plugin compiles without errors
- [ ] Debug inspector shows addon structure
- [ ] Can detect when Supply Mission window is open
- [ ] Can read at least one item from the list
- [ ] Can read all items correctly
- [ ] HQ detection works
- [ ] Quantity values are accurate
- [ ] Works with both Supply and Provisioning missions
