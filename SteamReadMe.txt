[h1]Reinforced Point Defense[/h1]


Allows point defense weapons to be mounted on Weapon Core slots.  By default, the game only allows point defense weapons to be placed in Hybrid and Weapon slots, but oddly not the highest weapon slot upgrade.

[h1]Steam Workshop[/h1]

Steam Users: Subscribing to this mod does not install the mod.

Follow the instructions in the Installation section.

[h1]Compatibility[/h1]
[list]
[*]If the mod is removed, existing saves will keep any PD modules mounted, but will not allow the user reinstall them.
[*]Safe to add and remove from existing saves.
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[/list]

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
[*]Download the ReinforcedPointDefense.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from https://github.com/NBKRedSpy/STTE-ReinforcedPointDefense/releases/
[/list]
[*]Extract the contents of the zip file into the [i]<Game Dir>/BepInEx/plugins[/i] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]

[h1]Uninstalling[/h1]

[h2]Uninstalling This Mod Only[/h2]

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the directory [i]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\ReinforcedPointDefense[/i].

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

Source code is available on GitHub at https://github.com/NBKRedSpy/STTE-ReinforcedPointDefense
