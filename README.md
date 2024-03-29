## Introduction and Opening Remarks

Hello universe,  
My writing this marks the beginning of my journey through github. I'm creating this mostly for the purpose of documenting and describing my deeper journey into the world of game development, at the moment specifically with Unity3d and C#. To fire things off, I've included all of the scripts currently in use by the platformer I'm working on. Here you should find most of the assets I've developed and some light commentary on the direction of the project. From this point onward, it's to the future and far beyond.

- M.G.

### Brief comments 01/13/2022

This webpage is getting much longer than I had anticipated and the scope of my projects has spiraled out of the purview of this blog. I am most likely
going to restructure my website/blog to either make a new blog page or just to include project updates with my github releases. If I commit to a long term
project, I may make a blog for that. For now, I will just keep doing what I'm doing.

### Update o4/14/2021: Devlog?

I added a small demo and devlog video to my channel [here](https://www.youtube.com/watch?v=3Q34iJMGs-o)!

### Update 04/13/2021: Terminal and Realistic Scope

Remember how in the last update I said I was learning javascript? Well, in this update, I will say that I also started learning python. And no, I'm not just going crazy for programming languages. While I clearly like jumping around projects and starting new things a lot, there is actually a reason for this. Python is the main language used in the game Terminal by Correlation One.

Terminal is a very simple and superficially uninteresting game. The catch is, you program a bot that plays the game automatically, and then it plays against bots other people made. There is a whole ELO system behind it, and every once in a while there are tournaments with prize support. I started making bots in python in order to learn python, but my bots eventually started doing well. Really well, actually, reaching as high as tenth in the world out of more than 30,000 teams. In an extraordinary circumstance, it so happened that the west coast regional competition was also starting.

I applied to the west coast regional competition, and eventually my teammate and I both got in. This was a pretty important first step, as participants both needed a team of two or more and there were hundreds of applicants and only one hundred competitors. The top 12 each won $1,000, and while my bot ultimately landed in 19th place (out of 60), we spent the first three days of the competition at first place on the leaderboard. We unfortunately couldn't maintain this lead because the competition ended on Sunday and we had a very busy weekend.

Following this reasonable performance, we received invitations to the global championship. The global championship is a school-by-school invitation only event, where the best team from each school eventually competes for $50,000 in prizes. Starting tomorrow as of this update, the programming for the first stage of the event begins. My hopes are not incredibly high for winning this one, partially because I have a midterm on Friday and partially because I have other things I want to work on, but I'm very glad I've had the opportunity to participate in these exclusive events.

To update on the things I mentioned earlier: I wrote my three.js game engine up to having a component and animation system, and then left it there. I don't have the assets to make a full 3d game at the time, and the scope of a full 3d game is very large, especially when I have to build my engine custom to the way I want the game to be able to work. Long story short, I won't be using the game engine any time soon. Colleggt has a stage, a boss, mechanics, and health bars, which is enough for the project it is part of.

The game I'm working on right now is a part of the Colleggt parent project, the idea of which is to have several small, complete games that are all accessible from the same project. Currently, it doesn't have a name, other than the starting location ("Grisvale"). What it does have is a pixel-art oriented interface and design, a full tilemap with decorative assets, and several new systems I am very happy with. Firstly, I made an NPC dialogue system. I used scriptable objects to make easily editable dialogue trees (using my own implementation of the actual data structure) and I built a dialogue manager that allows the player to make dialogue choices for each NPC that progress where they are in the dialogue tree. I also effectively made a very easy to use player state system that uses some new data structures and hierarchies well. Currently, I have a stamina and parry-based combat system mostly complete on top of working NPC dialogue and events. I'm very excited to demo this, and I intend to upload a lot of the code and assets soon.

Every step I take gets me closer to being able to architect and code legitimately large and interesting games quickly. I believe Grisvale is a huge stride in the right direction; my implementations are getting leaner and my use of encapsulation, data structures, and algorithms is getting more accurate. I'm also finding some ways to get assets created more quickly, especially art. Like I said, I hope to have a demo going shortly. Hopefully, I'll remember to update this.

 - M.G

### Update 03/13/2021: New Languages, New Focuses, Broadened Horizons

In the interest of transparency, I will say that the main reason I haven't updated this blog since October is that I thought I had toward the end of December. Since I actually haven't, I'll say a little bit about all of the random things I've done, starting with the most recent because I remember those best.

Most recently, I started playing a game called Terminal after my school's physics department sent out an email about it. While this would be unremarkable in most cases, it ended up being significant to me because the point of the game is to program a bot that plays it. Not only that, but the most strongly encouraged language is Python. So it is thanks to Terminal that in this last week that I have learned the basics of Python and written some fairly basic but at times surprisingly effective bots.

A few weeks before this, I'd decided to try and learn some more web development so I could make an actual website to use as a portfolio. The fruits of my labor are, for the most part, my github pages main page (which you probably used to get here). While I did learn some primitive CSS and HTML to make the page look better, the real purpose of this venture was to learn webdev through javascript. I like the idea of having javascript in my toolbox because I can very quickly and easily make anything I create accessible from pretty much anywhere. Javascript also has a huge community and tons of libraries with very reasonable implementations. The ones I am currently learning are node.js, Websockets, and three.js. As such, I have finally gotten a start on client-server communication (I even made a low-level in-browser chat application that works over localhost) and on learning the ins and outs of 3d rendering (I first made a canvas-based renderer with a self-made matrix algebra library that could draw cubes and rectangular prisms, and now am starting to build a 3d game engine using webgl and three.js).

Most of my work in Unity itself has been experimenting with coding techniques. The only thing related to an in-development game I've done is add some functionality to Colleggt, a game I'll talk about later that I've put demo content of on my YouTube channel. The coding techniques I'm referring to, so far, is that I've built a procedural terrain generator using Perlin noise from a tutorial to get a grasp on how procedural generation and mesh generation work, and that I've done some testing with inverse kinematics and animation rigging. I also am currently working on a planet generator following the Sebastian Lague YouTube series with simplex noise. The idea here is that I'll be able to implement procedural generation into future games and have the ability to set up both 3d and 2d games more quickly.

The only game I've worked on directly as of late, like I mentioned, is Colleggt. The idea here is that you're a duck trying to collect eggs because you want to eat them. However, as you progress through the stages, you keep running into bosses... bosses who owned the eggs you've stolen. In order to kill the bosses, you need to drop their own eggs on them. As the game progresses, you accumulate more and more eggs, and finally you get to the egg shrine where your use of eggs will determine how the game ends. I've programmed one boss fight, health bars and damage, two regions, music that persists across scenes with a soundtrack component that plays music based on the level, and an egg collection method that works both with player settings and on a level-to-level basis.

Over winter break, I worked on scribblesong a lot. I believe I may have uploaded some demo videos. Either way, I'll explain what I did here. I made a progression system and a state machine that governs movement behaviors as well as a rendering strategy for different sections of the map. I also made enemies, attacking and damage, and added double jumping and dashing. I received a drawing tablet as a gift, and so my main focus was on developing ways to draw background and foreground art more efficiently. Most of the work was on finding a scene drawing system that would work smoothly with parallax, hitboxes, and tiling repeated components like ground.

I have a lot to work on still, and as I'm writing this I am both working on learning three.js and entering finals week. So as always, thank you for reading, and hopefully I'll remember to update this more frequently! I plan to add demo images and videos of everything I talked about in the near future.

 - M.G

### Update 10/24: Scribblesong, Repository Update, School

It's been three whole months since I last updated this page, but I stress that this doesn't mean I haven't been working. Just two months ago I was accepted into the aerospace engineering major at the UW and since then have decided I'll focus on finishing that and getting a physics minor for the next few years. Although I expect this to be a pretty significant commitment, I still expect to find time to work on games. I already have, actually, considering that the GMTK jam took place while I was enrolled in summer quarter.

Without further ado, here's the new stuff.

I added all of the assets used in Temple Gun to a new repository you can find [here](https://github.com/DereferenceMyPointer/Temple-Gun).

I started several new projects, each mostly just to test and prototype ideas. Most recently I've been doing some reading about OOP principles and game architecture, as well as learning C++. I understand much more about how to effectively architect object oriented programs now, especially in unity, and have started applying this to some basic finite state machines (think AI, player states; driving vehicles, fly mode) and generic RPG systems (think spells and inventories). My project prototyping this will likely be showcased in an upcoming log, since I only started it yesterday, but so far I have both a spell and an inventory system that do not use singletons. The player controller is also defined through an FSM, and I've used a LOT of interfaces already. For example, my player inventory extends monobehavior and implements two different interfaces. This is a pretty significant improvement from before, where interfaces hadn't even progressed beyond my java vocabulary yet. The purpose of this is encapsulating every feature as much as possible while also allowing for as much flexibility in adding features as possible. I'm sure there's even more to learn and to do better, but I am very happy with this start.

Now for the mysterious project I updated my main GitHub with: Scribblesong. This one's more of a joke project. The idea comes from Team Cherry's in-development game, Silksong, which was announced forever ago and had a gameplay demo more than a year and a half ago at Nintendo. It's in the same universe as Hollow Knight (Team Cherry's other game), which is probably my favorite game I've ever played, and you're playing as a character that acted both as a boss and as an ally in different parts of the game. But enough drooling over Team Cherry's creations. Scribblesong is a knockoff of Silksong being made entirely in MS Paint style. The plan is to have a playable version of Scribblesong release before Silksong itself, both because that's hilarious and so that people waiting for Silksong have something to do. Moreover though, this is an excuse to let me develop a metroidvania like game more quickly because I'm not bound as strongly by art quality.

I've added all the assets for Scribblesong so far [here](https://github.com/DereferenceMyPointer/ScribbleSong).
Also, here's a [Scribblesong demo video](https://github.com/DereferenceMyPointer/ScribbleSong/blob/master/Scribblesong.mp4)

As for my last project, the one with the little flame guy, I'm putting that one on pause until I feel like I have both the artistic and software development skills necessary for it to really come out well. I actually think I'm starting to get close already, with Scribblesong and my most recent side project, and I'm using Scribblesong as a metric for how well I can animate and code this type of game in a vacuum. And so, onward!

### Update 7/10 - 7/20/2020: Game Jam!
[Game Page](https://dereferencemypointer.itch.io/temple-gun)

These last two weeks have been unbelievably busy for me. Last week, I worked with a friend on a game for the the largest annual game jam currently being held, the GMTK game jam. This required me two clear out two days worth of work ahead of time and squeeze in doing an entire project for one class on Sunday. But regardless of the additional work I've put on myself, we finished a game. I did most of the programming and my friend did most of the art and animation, although I made the skull spiders and the tileset for the ice biome. It was a very intense two days, and waiting for ratings to come in was also exciting. Overall, I'm very satisfied with what we made, especially considering we finished it fifteen hours before the deadline.

### Devlog 06/27/2020: Bonfires, Implementations, and an Introductory Boss
[Video Log](https://www.youtube.com/watch?v=GzM2fIiPWGw) (finally)

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
