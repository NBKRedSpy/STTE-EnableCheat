# Enable Cheats

![thumbnail icon](media/thumbnail.png)

Enables the game's Cheat hotkeys.  Based on Steam user [dv's Cheatcodes mod](https://steamcommunity.com/sharedfiles/filedetails/?id=2333969105).

Press the Ctrl+\] (Left control + right bracket) key to enable and disable the cheats.  Once enabled, use the Shift + <some key> to execute a cheat.

See the [Cheat Keys](#cheat-keys) section for the list of cheats.

## Mod Differences
This mod has a couple of differences from dv's:

* Does not require overwriting the game's original files.  This makes the mod more likely to be compatible with other mods.
* Uses a hotkey instead of the game's "magic text" to activate.
* Can be toggled on and off.

# Steam Workshop
For Steam Users, subscribing to this mod does not install the mod.
Follow [Installation section](#installation) instructions below to install.

# Compatibility
* Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
    * This mod does not affect the original game files.
* Safe to add and remove from existing saves.

# Cheat Keys

This is the list of cheat keys that are available.

|Description|Key|
|--|--|
|Make Fire|Shift + G|
|Extinguish Fire|Shift + E|
|Jump To Closest Unvisited Poi|Shift + H|
|Jump To Closest Unvisited Shop|Shift + J|
|Jump To Closest Enemy|Shift + K|
|Give Resources|Shift + L|
|Kill Enemies|Shift + O|
|Delete Savegame And Settings|Shift + Delete|
|Add Fate|Shift + Insert|
|Advance Main Quest|Shift + F|
|Unlock Sectors|Shift + S|
|Unlock Ships|Shift + I|
|Speed Up|Shift + N|
|Make Ship And Crew Almost Immortal|Shift + B|
|Make All Modules Craftable|Shift + R|


## Cheats that Do Not Work
Technical note:  There are some cheats that do not work because I was unable to find the prefab for ShowMutexes and onKeypressSpawnUiPrefab.

If anyone has a suggestion as to where they can be found, please let me know.

|Description|Key|
|--|--|
|Unlock All Mutexes|Shift + Home|
|Zoom Pixel Perfect|Shift + P|
|Mini Profiler|Shift + F11|
|Hide Mutexes|Shift + U|
|Unlock Perks|Shift + P|
|Spawn Intview Enemy|Shift + V|
|Toggle Own Ship AI|Shift + M|
|Unlock Some Perks|Shift + Comma|

# Configuration
The configuration file will be created on the first game run and can be found at `<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\EnableCheat.cfg`.  The changes will take effect the next time the game is run.

|Name|Default|Description|
|--|--|--|
|EnableCheatKeys|Left Ctrl + \]|The key to enable the binding.|

# Support
If you enjoy my mods and want to buy me a coffee, check out my [Ko-Fi](https://ko-fi.com/nbkredspy71915) page.
Thanks!

# Installation 

This section covers how to install the BepInEx mod loader and the mod itself.

## BepInEx Setup
If BepInEx has already been installed, skip to the [Mod Install](#mod-install) section.

* Download BepInEx from https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip
* Extract of the BepInEx zip file into the game's directory:
```<Steam Directory>\steamapps\common\Shortest Trip to Earth```
* Move all of the files in the new ```BepInEx_win_x64_5.4.23.2``` folder to the game's root directory.
* If installed correctly, the following folders and files will exist in the game's directory:
```
<Game Directory>
|   doorstop_config.ini
|   ST Earth.exe
+---BepInEx
+---Data
```
* Run the game.  Once the main menu is shown, exit the game.  
* If the install was successful, there will now be a ```<Game Directory>/BepInEx/plugins``` directory.

## Mod Install
* Download the EnableCheat.zip.  
    * If on Nexumods.com, download from the Files tab.
    * Otherwise, download from https://github.com/NBKRedSpy/STTE-EnableCheat/releases/
* Extract the contents of the zip file into the ```<Game Dir>/BepInEx/plugins``` folder.
* Run the Game.  The mod will now be enabled.

# Uninstalling

## Uninstalling This Mod Only

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the directory ```<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\EnableCheat```.

## Uninstall the Mod and BepInEx
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.

Delete the following files and folders in the game's directory:
```
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
```

# Change Log 

## 1.0.0
* Release

# Source Code
Source code is available on GitHub at https://github.com/NBKRedSpy/STTE-EnableCheat
