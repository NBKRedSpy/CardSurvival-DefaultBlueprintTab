# Default Blueprint Tab
The base game always selects the left most sub tab.

This mod makes the blueprint screen's Research Sub Tab "sticky".  If the research sub tab was previously selected, it will remain so when selecting a new top level tab.

Useful when searching through tabs to select the next item to research.

The mod can be set to always select the research tab even when the blueprint window is opened.  This was the default mode for version 1.0.0.

# Settings 
|Name|Default|Description|
|--|--|--|
|AlwaysStartWithResearchTab|false|If true, will always change the sub tab to Research on top tab click.  Otherwise, will only keep the research sub tab open if the previous tab had the Research sub tab open.|

## "Always Start With Research Tab" Note
Setting the AlwaysStartWithResearchTab to true can make it more difficult to make batch blueprints.  

For example: A user wishes to make multiple Jungle Salads in a row.  With this option disabled, the tab with the Jungle Salad will be opened when the user re-opens the blueprint screen.  Otherwise when reopening the blueprints screen, the research sub tab will be shown, requiring the user to click the tab with the desired recipe each time.

# Changing the Configuration
All options are contained in the config file which is located at ```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx\config\DefaultBlueprintTab.cfg```.

The .cfg file will not exist until the mod is installed and then the game is run.

To reset the config, delete the config file.  A new config will be created the next time the game is run.

# Installation 
This mod requires the BepInEx mod loader.

## BepInEx Setup
If BepInEx has already been installed, skip this section.

Download BepInEx from https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x64_5.4.21.0.zip

* Extract the contents of the BepInEx zip file into the game's directory:
```<Steam Directory>\steamapps\common\Card Survival Tropical Island```

    __Important__:  The .zip file *must* be extracted to the root folder of the game.  If BepInEx was extracted correctly, the following directory will exist: ```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx```.  This is a common install issue.

* Run the game.  Once the main menu is shown, exit the game.
    
* In the BepInEx folder, there will now be a "plugins" directory.

## Mod Setup
* Download the DefaultBluePrintTab.zip.  
    * If on Nexumods.com, download from the Files tab.
    * Otherwise, download from https://github.com/NBKRedSpy/CardSurvival-DefaultBlueprintTab/releases/

* Extract the contents of the zip file into the ```BepInEx/plugins``` folder.

* Run the Game.  The mod will now be enabled.

# Uninstalling

## Uninstall
This resets the game to an unmodded state.

Delete the BepInEx folder from the game's directory
```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx```

## Uninstalling This Mod Only

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the ```DefaultBluePrintTab.dll``` from the ```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx\plugins``` directory.
# Compatibility
Safe to add and remove from existing saves.

# Change Log

## 1.1.0
* Changed to only select the Research Sub Tab if it was previously selected.  Makes creating batch recipes easier.
* Added AlwaysStartWithResearchTab option.