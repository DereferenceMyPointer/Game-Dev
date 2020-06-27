## Introduction and Opening Remarks
[Editor on GitHub](https://github.com/DereferenceMyPointer/Game-Dev/edit/master/README.md)

Hello universe,  
My writing this marks the beginning of my journey through github. I'm creating this mostly for the purpose of documenting and describing my deeper journey into the world of game development, at the moment specifically with Unity3d and C#. To fire things off, I've included all of the scripts currently in use by the platformer I'm working on. Here you should find most of the assets I've developed and some light commentary on the direction of the project. From this point onward, it's to the future and far beyond.

- M.G.

### Devlog 06/27/2020: Bonfires, Implementations, and an Introductory Boss

With the beginning of summer classes, my ability to make large amounts of progress within a few days has greatly diminished. However, I'm still working on games and other projects, so expect a few updates here and there whenever something important happens.

Probably the most impactful change I've made since the last update was streamlining the process for developing background art. I went back to the storyboard and expanded on what the location you start in actually means. Rooms in an area need to have a unifying theme and feeling, and there need to be a lot of them in order to get the point across that it's actually a location. So in order to facilitate this, I've started making reusable art assets, like boilers and brick walls for the boilerroom area, as well as trying to think more about color palette (although coloring is generally very difficult due to my moderate colorblindness). To this end, I've already added one more room and have several in the works. Expect a mostly complete redesign of the starting area within the next few weeks.

As far as mechanics that I've added, I created bonfires that the player can light which restore health and set a respawn point. I have also added a death screen animation for when you do die. In order to test this, I made a very simple boss fight. The player now has several immunity frames after taking damage, which allows for damage zones to use on OnTriggerStay script, which is less buggy. I also implemented editing the scriptable object with events; now the player will receive an additional health after talking to the NPC, and will receive a temporary version of the wall jump ability (text will pop up to notify you of this).

So, while I won't be able to work on this as much starting now, the steps I have left to take will really start making the game look more like its final form. As always, thanks for reading.

 - M.G.

### Devlog 06/22/2020: Progression, Dash, and Dialogue

In retrospect, I should probably have made an update earlier. There have almost been too many updates to succinctly communicate what I've changed in the last few days. Owing to this, I'll briefly outline what the game looks like now.

First and foremost, I fully implemented the progression system. This is done with a scriptable object, the same one that stores the player's health. This way the current state of the player will be tied to progression for the duration of a playthrough. It stores the maximum player health, the remaining player health, and the maximum possible player health. It also stores any progression point as a boolean. For example, unlocking the dash ability is done by changing the canDash variable to true. NPCs with dialogue will also have multiple stages of dialogue that can be tied to booleans in the player progression. This allows me to have NPCs give the player certain items or abilities after they've been spoken to under certain conditions. I added a singleton class that will be used by any objects to make changes to the player progression rather than attaching the player script to all of them to keep it slightly more protected.

Secondly, I added NPC dialogue. This has two components: firstly, an interactable class. This class is abstract and defines only an Interact() method. This way, I can have a player interact class that can Interact() with whatever component the object it's interacting with has that extends interactable. This does more than allow for dialogue, but currently that's all I'm using it for. The dialogue itself is broken into a single dialogue manager and Dialogue components that npcs with dialogue store in their interactable. The dialogue manager animates the dialogue window and has a public method that accepts dialogue as a parameter and displays the dialogue. I call this method in the NPC's interact script, so that when the player interact()s with the npc it will display the dialogue.

Finally, I added the ability to dash. The dash ability is pretty much the same as what you would find in something like Hollow Knight or Celeste. I find this is very important for progression because it can give you the ability to access new places. Along that vein, I added a counter for the number of dashes allowed between each jump as a way to let the player explore further with additional progression. It also just makes gameplay that much more fun and fluid. I added what is likely to be a temporary animation for the dash and made its utility dependent on the player progression item. I also added some more art assets and have begun working on backgrounds, which I plan to add parallax to with a script in orthographic mode. I also plan on expanding the camera boundary system by disabling all components of locations the player isn't in to increase efficieny and prevent background overlap.

### Devlog 06/18/2020: Quick Updates

[Video Log](https://www.youtube.com/watch?v=Jw66lYGFbW0)

This log is more of an update 1.5. Today I added a running animation and a system for camera movement. It seems to me like this system for camera movement is strong and flexible. It's based on the fact that x- and y- values remain the same at any z distance and that z-values from the camera to the environment are always the same. This lets me build boundaries for the camera motion as trigger colliders on the same plane as the character and then use the x- and y- values of the collider's boundaries to clamp the camera movement based on the FOV boundaries (which are constant for each aspect ratio).

To explain this in greater depth, it will be better to look at the updated camera movement and boundary scripts themselves. The goal here is to have just one active set of boundaries at a time, and I accomplish this by having the active boundary be a class variable for the camera script. Now, I want to be able to change the boundary depending on where the player moves. For this reason, the boundary prefab is broken into two components. One of them defines the camera movement space, while the other defines the hitbox for the player that switches the active boundary to the new one. Fundamentally, this is how it works. When the player enters the new boundary trigger, the active camera boundary is set to the new boundary. For the purposes of making faster transitions and preventing camera lag during falling transitions, I also added a separate follow speed for transitions that can snap the camera to the player more quickly when crossing into a new area. 

Closing thoughts: I might add a blackout effect to transitions so I won't have to stitch areas together as much when constructing the final layout. I also changed the player health to a scriptable object, which should mean the values it stores remain constant across a playthrough regardless of whether or not the application stops running. This tells me I should probably use a single scriptable object to track health as well as all progression, so that any script I write that wants to access progression info can access any of it if necessary.

### Devlog 06/17/2020: Introduction
[Video Log](https://www.youtube.com/watch?v=ti4bAH1zd3Q)  

I've been meaning to upload and document my work somewhere for some time now, but it was only recently that I came across github pages. While I've used github in the past, I never actually created a dedicated board for my projects. But now it's here, and hopefully you're here to follow this journey or just to find some useful information. This devlog might be a bit long due to the fact that I have two weeks or so of development time behind the project already. I'll start from the beginning and describe what this project is and how I'm approaching it.

Previously, the majority of my time in unity was spent working on 3D games because those were what I had played over the years. The titles I adored were huge AAA games with unbelievable scale, however, and building an entire game in that spirit (think Destiny) was a daunting task, especially when I was just starting out with Unity, C#, and 3D modeling. After being introduced to some fantastic 2D games, I realized that it wasn't really the 3D aspect of the games that fueled what I liked about them so much. I realized I could capture the senses of exploration, wonder, and world in a 2D medium that would dramatically increase development rate at the cost of just learning a few simple skills. There are other projects I started before this for the purpose of just introducing myself to how to do these things. For perspective, before last month, I'd never touched graphic design or art software at all. I'm learning this from the ground up.

All of this brings me to what I'm working on now, which I'm planning to make into a metroidvania style game with world development and an emphasis on exploration and discovery. The art really works together with the programming here, and I wanted to capture a particular solemn but hopeful style while at the same time making a smooth product. So I developed the movement of the player character before starting anything else. Responsiveness, reasonable cooldown timers, and especially forgiveness in gameplay were things I especially wanted to implement. The main "innovation" I've made (if you can even call it that) is to add a universal movement forgiveness feature allows every input a short window before or after it is made to still go off. For example, I set the universal forgiveness to 0.2 seconds. This means that, if you press jump 0.2 seconds before hitting the ground, you'll still jump when you actually touch it. It also means that, if you fall off a ledge, you have a 0.2 second window after doing so where you're still able to jump. On top of this, every ability has the forgiveness too: if you press shoot within the forgiveness window before the cooldown ends, you'll shoot immediately when the cooldown is over. These are mostly there to help immersion. You wouldn't feel very immersed if instead of paying attention to the world around you you had to worry about pressing jump the instant you hit the ground or the instant before you hit the edge of a ledge.

The art style is still something of a work in progress. I still have to learn how to properly create backgrounds that create a good parallax effect. But the direction is something I'm very happy with. Moving forward, I intend to implement interactables, an inventory, and especially a script for the camera that follows the boundaries of whatever room you happen to be in. In the meantime, I'll sign off with some concept art from my path to digital artwork.

[First Concept](https://github.com/DereferenceMyPointer/Game-Dev/blob/Art/Bot%20Title%20Art.png)

[Character Model](https://github.com/DereferenceMyPointer/Game-Dev/blob/Art/Flamy%20Boi.png)

[Forest](https://github.com/DereferenceMyPointer/Game-Dev/blob/Art/First%20Room.png)

[House](https://github.com/DereferenceMyPointer/Game-Dev/blob/Art/Spooky%20House.png)

[Boilerroom](https://github.com/DereferenceMyPointer/Game-Dev/blob/Art/Boilerroom.png)

- M.G.
