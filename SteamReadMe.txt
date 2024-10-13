[h1]Enable Cheats[/h1]


Enables the game's Cheat hotkeys.  Based on Steam user [url=https://steamcommunity.com/sharedfiles/filedetails/?id=2333969105]dv's Cheatcodes mod[/url].

Press the Ctrl+] (Left control + right bracket) key to enable and disable the cheats.  Once enabled, use the Shift + <some key> to execute a cheat.

See the Cheat Keys section for the list of cheats.

[h2]Mod Differences[/h2]

This mod has a couple of differences from dv's:
[list]
[*]Does not require overwriting the game's original files.  This makes mod more compatible with other mods.
[*]Uses a hotkey instead of the game's "magic text" to activate.
[*]Can be toggled on and off.
[/list]

[h1]Steam Workshop[/h1]

For Steam Users, subscribing to this mod does not install the mod.
Follow Installation section instructions below to install.

[h1]Compatibility[/h1]
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[*]Safe to add and remove from existing saves.
[/list]

[h1]Cheat Keys[/h1]

This is the list of cheat keys that are available.
[table]
[tr]
[td]Description
[/td]
[td]Key
[/td]
[/tr]
[tr]
[td]Make Fire
[/td]
[td]Shift + G
[/td]
[/tr]
[tr]
[td]Extinguish Fire
[/td]
[td]Shift + E
[/td]
[/tr]
[tr]
[td]Jump To Closest Unvisited Poi
[/td]
[td]Shift + H
[/td]
[/tr]
[tr]
[td]Jump To Closest Unvisited Shop
[/td]
[td]Shift + J
[/td]
[/tr]
[tr]
[td]Jump To Closest Enemy
[/td]
[td]Shift + K
[/td]
[/tr]
[tr]
[td]Give Resources
[/td]
[td]Shift + L
[/td]
[/tr]
[tr]
[td]Kill Enemies
[/td]
[td]Shift + O
[/td]
[/tr]
[tr]
[td]Delete Savegame And Settings
[/td]
[td]Shift + Delete
[/td]
[/tr]
[tr]
[td]Add Fate
[/td]
[td]Shift + Insert
[/td]
[/tr]
[tr]
[td]Advance Main Quest
[/td]
[td]Shift + F
[/td]
[/tr]
[tr]
[td]Unlock Sectors
[/td]
[td]Shift + S
[/td]
[/tr]
[tr]
[td]Unlock Ships
[/td]
[td]Shift + I
[/td]
[/tr]
[tr]
[td]Speed Up
[/td]
[td]Shift + N
[/td]
[/tr]
[tr]
[td]Make Ship And Crew Almost Immortal
[/td]
[td]Shift + B
[/td]
[/tr]
[tr]
[td]Make All Modules Craftable
[/td]
[td]Shift + R
[/td]
[/tr]
[/table]

[h2]Cheats that Do Not Work[/h2]

Technical note:  There are some cheats that do not work because I was unable to find the prefab for ShowMutexes and onKeypressSpawnUiPrefab.

If anyone has a suggestion as to where they can be found, please let me know.
[table]
[tr]
[td]Description
[/td]
[td]Key
[/td]
[/tr]
[tr]
[td]Unlock All Mutexes
[/td]
[td]Shift + Home
[/td]
[/tr]
[tr]
[td]Zoom Pixel Perfect
[/td]
[td]Shift + P
[/td]
[/tr]
[tr]
[td]Mini Profiler
[/td]
[td]Shift + F11
[/td]
[/tr]
[tr]
[td]Hide Mutexes
[/td]
[td]Shift + U
[/td]
[/tr]
[tr]
[td]Unlock Perks
[/td]
[td]Shift + P
[/td]
[/tr]
[tr]
[td]Spawn Intview Enemy
[/td]
[td]Shift + V
[/td]
[/tr]
[tr]
[td]Toggle Own Ship AI
[/td]
[td]Shift + M
[/td]
[/tr]
[tr]
[td]Unlock Some Perks
[/td]
[td]Shift + Comma
[/td]
[/tr]
[/table]

[h1]Configuration[/h1]

The configuration file will be created on the first game run and can be found at [i]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\EnableCheat.cfg[/i].  The changes will take effect the next time the game is run.
[table]
[tr]
[td]Name
[/td]
[td]Default
[/td]
[td]Description
[/td]
[/tr]
[tr]
[td]EnableCheatKeys
[/td]
[td]Left Ctrl + ]
[/td]
[td]The key to enable the binding.
[/td]
[/tr]
[/table]

[h1]Support[/h1]

If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!

[h1]Installation[/h1]

This section covers how to install the BepInEx mod loader and the mod itself.

[h2]BepInEx Setup[/h2]

If BepInEx has already been installed, skip to the Mod Install section.
[list]
[*]Download BepInEx from https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip
[*]Extract of the BepInEx zip file into the game's directory:
[i]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/i]
[*]Move all of the files in the new [i]BepInEx_win_x64_5.4.23.2[/i] folder to the game's root directory.
[*]If installed correctly, the following folders and files will exist in the game's directory:
[/list]
[code]
<Game Directory>
|   doorstop_config.ini
|   ST Earth.exe
+---BepInEx
+---Data
[/code]
[list]
[*]Run the game.  Once the main menu is shown, exit the game.
[*]If the install was successful, there will now be a [i]<Game Directory>/BepInEx/plugins[/i] directory.
[/list]

[h2]Mod Install[/h2]
[list]
[*]Download the EnableCheat.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from https://github.com/NBKRedSpy/STTE-EnableCheat/releases/
[/list]
[*]Extract the contents of the zip file into the [i]<Game Dir>/BepInEx/plugins[/i] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]

[h1]Uninstalling[/h1]

[h2]Uninstalling This Mod Only[/h2]

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the directory [i]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\EnableCheat[/i].

[h2]Uninstall the Mod and BepInEx[/h2]

This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.

Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]

[h1]Change Log[/h1]

[h2]1.0.0[/h2]
[list]
[*]Release
[/list]

[h1]Source Code[/h1]

Source code is available on GitHub at https://github.com/NBKRedSpy/STTE-EnableCheat
