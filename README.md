# Readme City_Project
This project contains programming scripts and assets for a gamified virtual city VR environment. 

The scene was developed for the 2023/24 study "In Rod we Trust - The evaluation of virtual Rod and Frame Test as a cybersickness screening instrument" by J. Josupeit.

To download and test the application files, go to [Application_City](https://github.com/JudiJ/Application_City)

Download the zip-file in this project to get the original Unity scene (Unity v2019.1.11f1), programming scripts and custom created assets.

## The Application
Virtual city setting allowing for free exploration. Glowing semi-circular checkpoints can be collected for gamification.

### Functions
- menu with text bar to insert a participant number
- dark waiting room while the menu is open, before the virtual city is displayed
- glowing checkpoints collected when virtually walked into
- option to reset main camera to starting position with or without displaying the waiting room again
- end the application by right clicking the mouse or closing the window with the cursor 
- each play can be recorded
- data saved automatically in separately created folder

This VR city environment is programmed for the HTC Vive controllers. While the application should work with different hardware, other devices may have limited functionality. Oculus devices do not have controller bindings, but should have full visuals.

## Scene and Custom Scripts
The "City.unity" file with the original Unity scene can be found in the folder [My Scenes](https://github.com/JudiJ/City_Project/tree/main/Assets/MyScenes).

The C#-code for the custom-designed assets is saved in the folder [My Scripts](https://github.com/JudiJ/City_Project/tree/main/Assets/MyScripts). The custom scripts include:
- "Checkpoint.cs" and "m_Checkpoint.cs" for 11 collectable checkpoints (global settings and single objects)
- "Clear_Flags.cs" for masking the skybox in the dark waiting room
- "Dark.cs" for creating a waiting room with the object "Drum.obj" where the VR city is invisible to the participant before start of recording
- "Drum.obj" as a dark cylindrical object to be set around the character controller as a waiting room
- "Menu.cs" for a text bar to insert the participant number before start of recording
- "Output.cs" as a saving script for the recorded data
- "VRController.cs" for virtual transportation in VR with the controllers 

### Project Layout
The main folder [Assets](https://github.com/JudiJ/City_Project/tree/main/Assets) contains all assets and custom objects used in and built for the City application:
-	“EasyRoads3D Assets” contains prefabricated street objects and materials, such as guard rails
-	“MyScenes” contains the “City.unity” file
-	“MyScripts” contains the C#-code for the custom assets created with Blender v2.90
-	“NatureManufactureAssets – Trials Not Full Resolution” contains prefab packs, shaders and textures for nature in the scene
-	“SteamVR” contains the SteamVR Plugin (v2.3.2) with the pregenerated scripts, materials, textures, models, prefabs, and additional plugin files 
-	“SteamVR_Input” contains the SteamVR code for action set classes 
-	“Tree_Textures” contains png-files with textures	
-	“Winridge City Assets” contains the licenses for the implemented assets, scripts for the skybox, arrays, shaders and terrains, free prefabs from the NatureManufacture Assets, volume profiles for the town, the script for the flying camera, and static prefab objects.
The skybox was set to move counter to the participants head movements

The main folder [Packages](https://github.com/JudiJ/City_Project/tree/main/Packages) contains the file “manifest.json”.

The main folder [ProjectSettings](https://github.com/JudiJ/City_Project/tree/main/ProjectSettings) includes all settings and manager files for this project.

## Supplementary
Each file is complemented with a meta-file.

Unity game engine version v2019.1.11f1. Steam VR Assets (version 2.3.2) game objects from the Winridge City Asset. Custom assets created with Blender (version 2.90). 

The application was originally run with a Windows 10 (64 bit), NVIDIA GeForce RTX 2070 GPU and Intel Core i7-9700K processor.

## License
Shield: [![CC BY 4.0][cc-by-shield]][cc-by]

This work is licensed under a
[Creative Commons Attribution 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-image]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg
