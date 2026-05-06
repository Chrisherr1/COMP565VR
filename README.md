# COMP565VR

A virtual reality project built in Unity for COMP565. The experience features interactive VR environments including a mansion scene and outdoor areas, with moving platforms, elevator mechanics, ambient music, and spatial audio.

## Built With

- Unity (URP)
- XR Interaction Toolkit
- TextMesh Pro
- WaterWorks
- Git LFS (for large assets)

## Scenes

- `Main.unity` — Main entry scene
- `VRscene.unity` — Primary VR environment

## Scripts

| Script | Description |
|---|---|
| `ButtonManager.cs` | Handles interactive button inputs |
| `FloorMusic.cs` | Manages floor-based ambient music triggers |
| `PlatformMoving.cs` | Controls moving platform behavior |
| `Platformparent.cs` | Parent logic for platform grouping |

## Setup

1. Clone the repo
```bash
git clone https://github.com/Chrisherr1/COMP565VR.git
```
2. Open in Unity (ensure Git LFS is installed)
3. Install XR plugin for your target headset via **Edit → Project Settings → XR Plug-in Management**
