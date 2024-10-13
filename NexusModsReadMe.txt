[b][size=5]Enable Cheats[/size][/b] 
 
 
Enables the game's Cheat hotkeys.  Based on Steam user [url=https://steamcommunity.com/sharedfiles/filedetails/?id=2333969105]dv's Cheatcodes mod[/url].
 
Press the Ctrl+] (Left control + right bracket) key to enable and disable the cheats.  Once enabled, use the Shift + <some key> to execute a cheat.
 
See the [font=Courier New]Cheat Keys[/font] section for the list of cheats.
 
[b][size=4]Mod Differences[/size][/b] 
 
This mod has a couple of differences from dv's:
[list]
[*]Does not require overwriting the game's original files.  This makes the mod more likely to be compatible with other mods.
[*]Uses a hotkey instead of the game's "magic text" to activate.
[*]Can be toggled on and off.
[/list]
 
[b][size=5]Steam Workshop[/size][/b] 
 
For Steam Users, subscribing to this mod does not install the mod.
Follow [font=Courier New]Installation section[/font] instructions below to install.
 
[b][size=5]Compatibility[/size][/b] 
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[*]Safe to add and remove from existing saves.
[/list]
 
[b][size=5]Cheat Keys[/size][/b] 
 
This is the list of cheat keys that are available.
[font=Courier New]+------------------------------------+----------------+
| Description                        | Key            |
|====================================+================|
| Make Fire                          | Shift + G      |
|------------------------------------+----------------|
| Extinguish Fire                    | Shift + E      |
|------------------------------------+----------------|
| Jump To Closest Unvisited Poi      | Shift + H      |
|------------------------------------+----------------|
| Jump To Closest Unvisited Shop     | Shift + J      |
|------------------------------------+----------------|
| Jump To Closest Enemy              | Shift + K      |
|------------------------------------+----------------|
| Give Resources                     | Shift + L      |
|------------------------------------+----------------|
| Kill Enemies                       | Shift + O      |
|------------------------------------+----------------|
| Delete Savegame And Settings       | Shift + Delete |
|------------------------------------+----------------|
| Add Fate                           | Shift + Insert |
|------------------------------------+----------------|
| Advance Main Quest                 | Shift + F      |
|------------------------------------+----------------|
| Unlock Sectors                     | Shift + S      |
|------------------------------------+----------------|
| Unlock Ships                       | Shift + I      |
|------------------------------------+----------------|
| Speed Up                           | Shift + N      |
|------------------------------------+----------------|
| Make Ship And Crew Almost Immortal | Shift + B      |
|------------------------------------+----------------|
| Make All Modules Craftable         | Shift + R      |
+------------------------------------+----------------+
[/font]
 
[b][size=4]Cheats that Do Not Work[/size][/b] 
 
Technical note:  There are some cheats that do not work because I was unable to find the prefab for ShowMutexes and onKeypressSpawnUiPrefab.
 
If anyone has a suggestion as to where they can be found, please let me know.
[font=Courier New]+---------------------+---------------+
| Description         | Key           |
|=====================+===============|
| Unlock All Mutexes  | Shift + Home  |
|---------------------+---------------|
| Zoom Pixel Perfect  | Shift + P     |
|---------------------+---------------|
| Mini Profiler       | Shift + F11   |
|---------------------+---------------|
| Hide Mutexes        | Shift + U     |
|---------------------+---------------|
| Unlock Perks        | Shift + P     |
|---------------------+---------------|
| Spawn Intview Enemy | Shift + V     |
|---------------------+---------------|
| Toggle Own Ship AI  | Shift + M     |
|---------------------+---------------|
| Unlock Some Perks   | Shift + Comma |
+---------------------+---------------+
[/font]
 
[b][size=5]Configuration[/size][/b] 
 
The configuration file will be created on the first game run and can be found at [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\EnableCheat.cfg[/font].  The changes will take effect the next time the game is run.
[font=Courier New]+-----------------+--------------+--------------------------------+
| Name            | Default      | Description                    |
|=================+==============+================================|
| EnableCheatKeys | Left Ctrl +  | The key to enable the binding. |
+-----------------+--------------+--------------------------------+
[/font]
 
[b][size=5]Support[/size][/b] 
 
If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!
 
[b][size=5]Installation[/size][/b] 
 
This section covers how to install the BepInEx mod loader and the mod itself.
 
[b][size=4]BepInEx Setup[/size][/b] 
 
If BepInEx has already been installed, skip to the [font=Courier New]Mod Install[/font] section.
[list]
[*]Download BepInEx from [url=https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip]https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip[/url]
[*]Extract of the BepInEx zip file into the game's directory:
[font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/font]
[*]Move all of the files in the new [font=Courier New]BepInEx_win_x64_5.4.23.2[/font] folder to the game's root directory.
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
[*]If the install was successful, there will now be a [font=Courier New]<Game Directory>/BepInEx/plugins[/font] directory.
[/list]
 
[b][size=4]Mod Install[/size][/b] 
[list]
[*]Download the EnableCheat.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from [url=https://github.com/NBKRedSpy/STTE-EnableCheat/releases/]https://github.com/NBKRedSpy/STTE-EnableCheat/releases/[/url]
[/list]
[*]Extract the contents of the zip file into the [font=Courier New]<Game Dir>/BepInEx/plugins[/font] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]
 
[b][size=5]Uninstalling[/size][/b] 
 
[b][size=4]Uninstalling This Mod Only[/size][/b] 
 
This method removes this mod, but keeps the BepInEx mod loader and any other mods.
 
Delete the directory [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\EnableCheat[/font].
 
[b][size=4]Uninstall the Mod and BepInEx[/size][/b] 
 
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.
 
Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]
 
[b][size=5]Change Log[/size][/b] 
 
[b][size=4]1.0.0[/size][/b] 
[list]
[*]Release
[/list]
 
[b][size=5]Source Code[/size][/b] 
 
Source code is available on GitHub at [url=https://github.com/NBKRedSpy/STTE-EnableCheat]https://github.com/NBKRedSpy/STTE-EnableCheat[/url]
