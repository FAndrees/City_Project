# Readme City_Project
This project contains programming scripts and assets for a gamified VR environment.
 
The scene was developed for the 2023/24 study "In Rod we Trust - The evaluation of virtual Rod and Frame Test as a cybersickness screening instrument" by J. Josupeit.
 
To download and test the built application, go to [App_City](https://github.com/JudiJ/App_City)
 
Download the zip folder to get the original Unity scene (requires Unity v2019.1.11f1), the corresponding scripts and the (custom) prefabs used for the VR application.
 
## The Application
Users can freely explore a virtual city environment by giving input on an HTC Vive controller trackpad. Glowing green circles (checkpoints) can be "collected" when the character controller (the Steam VR Camera Rig's parent game object) collides with their mesh. 
 
### Functions
- participant's code can be inserted in a text bar in the menu before the start, data of each session will be logged automatically after confirmation (ENTER Numpad)
  - automatic log:
     - the system time ("yy/MM/dd HH:mm:ss:fffff")
     - the number of collected checkpoints
     - whether the city (even number) or the waiting room (odd number) is displayed
     - the input on the x- and   y-axis of the controller
     - the position and rotation of the virtual camera in global Unity coordinates
- grey cylinder attached to the camera rig  waiting room [enabled and disabled by pressing 0 on the numpad]
- collectible checkpoints will change their material on "trigger enter" and will be destroyed on "trigger exit"
- option to reset the main camera to the starting position with  [enabled by pressing 0 on the numpad] or without displaying the waiting room again [enabled by pressing escape]
- Magic Carpet Locomotion: Longitudinal acceleration is activated by the HTC Vive trackpad input (Vector3 forward), lateral acceleration or orientation is realized through the orientation of the character controller (Steam VR camera)
- The skybox counterrotates to the rotation of the main camera
 
Key bindings are programmed for HTC Vive controllers. To ensure compatibility with other devices, check the key bindings in Steam VR.
 
## Scene and Custom Scripts
The "City.unity" file with the original Unity scene can be found in the folder [MyScenes](https://github.com/FAndrees/City_Project_2/tree/main/Assets/MyScenes).
 
The C#-code can be found in the folder [MyScripts](https://github.com/FAndrees/City_Project_2/tree/main/Assets/MyScripts). The custom scripts include:
- "Checkpoint.cs" changes the material of the checkpoint on "trigger enter" and destroys it on "trigger exit"
- "m_Checkpoint.cs" creates a single logic for each of the checkpoints (depreciated) (Checkpoints use the tag "Checkpoint")
- "Dark.cs" attaches a cylinder ("Drum.obj") to the Steam VR main camera when the application is loaded, can be dis/enabled by pressing 0 on the numpad
- "Clear_Flags.cs" masks the skybox when the cylinder is displayed
- “Menu.cs” deactivates the input field (enter on the numpad)
- "VRController.cs" enables the magic carpet locomotion, height and terrain handling. As it requires only a boolean input variable in the current version (m_MovePress.state) other input devices are easily implementable if desired 
- "Output.cs" contains the logging routine and works in editor. Stored in [City_Data](https://github.com/FAndrees/City_Project_2/tree/main/City_Data) folder with the built application (adjust the path according to your own needs)
 
Additionally, custom material is included in [MyScripts](https://github.com/FAndrees/City_Project_2/tree/main/Assets/MyScripts):
- "Material0.mat" default material for the Checkpoint
- "Material1.mat" material for the Checkpoint on "trigger enter"
- "Material2.mat" material for the Checkpoint on "trigger exit"
- “NewMaterial.mat” material for the "Drum.obj" and “prefab_building1”
 
Custom prefabs:
- "Drum.obj" presents a cylindrical mesh collider made with Blender (version 2.90)
  - keep the differences of the coordinate systems in mind: Blender right handed z-up <- -> Unity left-handed y-up
 
### Project Layout
The main folder [Assets](https://github.com/FAndrees/City_Project_2/tree/main/Assets) contains:
- "Do not shoot Aliens/Game assets" with prefab png-files for the checkpoints
- “EasyRoads3D Assets” with street objects and materials, such as guard rails
- “MyScenes” with the “City.unity” file
- “MyScripts” with the C#-code for the custom assets created with Blender v2.90
- “NatureManufactureAssets – Trials Not Full Resolution” with prefabs for the background of the scene
- “SteamVR” with assests from the SteamVR Plugin (v2.3.2).
- “SteamVR_Input” with action set classes from the SteamVR Plugin.
- “Tree_Textures” with textures  for the background of the scene
- “Winridge City Assets” with the prefabs for buildings and other decor used for the city scene [the scene itself is a derivative of the Winridge City Demo Scene]
 
In the other main folders, [ProjectSettings](https://github.com/FAndrees/City_Project_2/tree/main/ProjectSettings) and [SteamVR custom bindings](https://github.com/FAndrees/City_Project_2/tree/main/SteamVR_SteamVR_city/1) are shared for this project.
 
## Supplementary
Each file is complemented with the respective meta-file.
 
To open the scene in the editor, Unity game engine version v2019.1.11f1. is required.
 
The application was originally run with a Windows 10 (64 bit), NVIDIA GeForce RTX 2070 GPU and Intel Core i7-9700K processor.

## License
Shield: [![CC BY 4.0][cc-by-shield]][cc-by]
 
This work is licensed under a
[Creative Commons Attribution 4.0 International License][cc-by].
 
[![CC BY 4.0][cc-by-image]][cc-by]
 
[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg
