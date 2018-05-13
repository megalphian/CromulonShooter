# CromulonShooter

[image1]:./manual/pic1.png
[image2]: ./manual/pic2.png
[image3]: ./manual/pic3.png

Need I say more Rick and Morty Fans! Play as Rick and shoot Cromulons to a different dimension!

Built in Unity using C#
Requires MacOS

# To Launch

1) Download the Zip file or clone the repository
2) Run the "Cromulon Shooter.app"

# To Play

MOUSE - AIM

LEFT CLICK - FIRE PROJECTILE

# Rules

- You start the game with 100 points of health and unlimited projectiles
- To defeat a Cromulon, shoot a projectile to hit it. If you do so, you get 10 points
- If you miss a Cromulon and it manages to reach you, you lose 10 points of health
- Upon losing all your health, the game ends. You will still be able to enjoy the fascinating gameplay, but you won't gain any points

# Source Build

For Mac: Download repository and create a project in Unity. Use the "Assets/Scenes/MainScene.unity" Scene to load the game environment

# Lessons learnt

#### Unity and its components (eg. GameObjects, Colliders, Events, UI, etc.)
This is my first run at scripting in the Unity Engine and my first game built from a scratch. I learnt a lot about different game building mechanics and how they interact.
#### C# and the Unity Engine library
This is also my first C# application. The purely object oriented nature of the language is something that took a while to get used to but eventually get the hang of.
#### Design patterns in Unity
This is a rather simple game but I ensured that the connections between different game elements aren't tightly coupled. The UI acts as an *observer* to the Cromulons and the Player to handle the scoring and the health bar, while getters and setters are used throughout to eliminate using any public variables (unlike the ones in the Unity tutorials). The "SerializeField" element was however used to take advantage of Unity Inspector's power to modularize the gameObjects.
#### Memory management in games
The instances of the Cromulons are destroyed upon being shot by the player or upon attacking the player. The bullets are destroyed after a specified time to avoid accumulating in the screen. Upon testing with Unity's profiler, memory usage doesn't increase over time, and is maintained at a constant level. 

# Current Issue

Camera control is not perfect. When tilting all the way up or down, camera does flip. Currently working on a fix for that.

Working on some automated unit tests for components like the spawner

# Screenshots

![image1]

![image2]

![image3]

