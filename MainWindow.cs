using System;
using System.Collections.Generic;
using System.Numerics;
using Dalamud.Interface.Windowing;
using ImGuiNET;

namespace SupplyMissionHelper
{
    public class MainWindow : Window, IDisposable
    {
        private SupplyMissionHelper Plugin;
        private List<SupplyMissionItem> scannedMissions = new();
        private string statusMessage = "Ready";

        public MainWindow(SupplyMissionHelper plugin) : base(
            "Supply Mission Helper", ImGuiWindowFlags.None)
        {
            this.SizeConstraints = new WindowSizeConstraints
            {
                MinimumSize = new Vector2(500, 400),
                MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
            };

            this.Plugin = plugin;
        }

        public void Dispose()
        {
            // Cleanup if needed
        }

        public override void Draw()
        {
            ImGui.Text("Supply Mission Helper");
            ImGui.Spacing();

            // Button row
            if (ImGui.Button("Scan Supply Missions"))
            {
                ScanSupplyMissions();
            }
            
            ImGui.SameLine();
            
            if (ImGui.Button("Inspect Addon (Debug)"))
            {
                Plugin.Inspector.InspectSupplyMissionAddon();
            }

            ImGui.Spacing();
            
            // Status message
            if (!string.IsNullOrEmpty(statusMessage))
            {
                ImGui.TextColored(new Vector4(0.8f, 0.8f, 0.8f, 1.0f), statusMessage);
            }

            ImGui.Spacing();
            ImGui.Separator();
            ImGui.Spacing();

            // Display scanned missions
            if (scannedMissions.Count > 0)
            {
                ImGui.Text($"Found {scannedMissions.Count} supply missions:");
                ImGui.Spacing();

                if (ImGui.BeginTable("MissionsTable", 4, ImGuiTableFlags.Borders | ImGuiTableFlags.RowBg))
                {
                    ImGui.TableSetupColumn("Item Name");
                    ImGui.TableSetupColumn("Type");
                    ImGui.TableSetupColumn("Quantity");
                    ImGui.TableSetupColumn("HQ");
                    ImGui.TableHeadersRow();

                    foreach (var mission in scannedMissions)
                    {
                        ImGui.TableNextRow();
                        
                        ImGui.TableNextColumn();
                        ImGui.Text(mission.ItemName);
                        
                        ImGui.TableNextColumn();
                        ImGui.Text(mission.MissionType.ToString());
                        
                        ImGui.TableNextColumn();
                        ImGui.Text($"{mission.QuantityNeeded}/{mission.QuantityRequested}");
                        
                        ImGui.TableNextColumn();
                        ImGui.Text(mission.IsHighQuality ? "Yes" : "No");
                    }

                    ImGui.EndTable();
                }
            }
            else
            {
                ImGui.TextColored(new Vector4(0.6f, 0.6f, 0.6f, 1.0f), "No missions scanned yet. Open the Grand Company Supply window and click 'Scan Supply Missions'.");
            }

            ImGui.Spacing();
            ImGui.Separator();
            ImGui.Spacing();

            // Configuration options
            ImGui.Text("Options:");
            if (ImGui.Checkbox("Show Raw Materials Only", ref Plugin.Configuration.ShowRawMaterialsOnly))
            {
                Plugin.Configuration.Save();
            }

            if (ImGui.Checkbox("Include Gathering Locations", ref Plugin.Configuration.IncludeGatheringLocations))
            {
                Plugin.Configuration.Save();
            }
        }

        private void ScanSupplyMissions()
        {
            // Check if window is open
            if (!Plugin.Scanner.IsSupplyMissionWindowOpen())
            {
                statusMessage = "❌ Please open the Grand Company Supply Mission window first!";
                scannedMissions.Clear();
                return;
            }

            // Scan the missions
            scannedMissions = Plugin.Scanner.ScanSupplyMissions();

            if (scannedMissions.Count > 0)
            {
                statusMessage = $"✓ Successfully scanned {scannedMissions.Count} missions!";
            }
            else
            {
                statusMessage = "⚠ No missions found. The scanning logic needs to be implemented.";
            }
        }
    }
}
