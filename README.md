## Introduction and Opening Remarks
[Editor on GitHub](https://github.com/DereferenceMyPointer/Game-Dev/edit/master/README.md)

Hello universe,  
My writing this marks the beginning of my journey through github. I'm creating this mostly for the purpose of documenting and describing my deeper journey into the world of game development, at the moment specifically with Unity3d and C#. To fire things off, I've included all of the scripts currently in use by the platformer I'm working on. Here you should find most of the assets I've developed and some light commentary on the direction of the project. From this point onward, it's to the future and far beyond.

- M.G.


### Devlog 06/17/2020: Introduction
[Video Log](https://www.youtube.com/watch?v=ti4bAH1zd3Q)  

I've been meaning to upload and document my work somewhere for some time now, but it was only recently that I came across github pages. While I've used github in the past, I never actually created a dedicated board for my projects. But now it's here, and hopefully you're here to follow this journey or just to find some useful information. This devlog might be a bit long due to the fact that I have two weeks or so of development time behind the project already. I'll start from the beginning and describe what this project is and how I'm approaching it.

Previously, the majority of my time in unity was spent working on 3D games because those were what I had played over the years. The titles I adored were huge AAA games with unbelievable scale, however, and building an entire game in that spirit (think Destiny) was a daunting task, especially when I was just starting out with Unity, C#, and 3D modeling. After being introduced to some fantastic 2D games, I realized that it wasn't really the 3D aspect of the games that fueled what I liked about them so much. I realized I could capture the senses of exploration, wonder, and world in a 2D medium that would dramatically increase development rate at the cost of just learning a few simple skills. There are other projects I started before this for the purpose of just introducing myself to how to do these things. For perspective, before last month, I'd never touched graphic design or art software at all. I'm learning this from the ground up.

All of this brings me to what I'm working on now, which I'm planning to make into a metroidvania style game with world development and an emphasis on exploration and discovery. The art really works together with the programming here, and I wanted to capture a particular solemn but hopeful style while at the same time making a smooth product. So I developed the movement of the player character before starting anything else. Responsiveness, reasonable cooldown timers, and especially forgiveness in gameplay were things I especially wanted to implement. The main "innovation" I've made (if you can even call it that) is to add a universal movement forgiveness feature allows every input a short window before or after it is made to still go off. For example, I set the universal forgiveness to 0.2 seconds. This means that, if you press jump 0.2 seconds before hitting the ground, you'll still jump when you actually touch it. It also means that, if you fall off a ledge, you have a 0.2 second window after doing so where you're still able to jump. On top of this, every ability has the forgiveness too: if you press shoot within the forgiveness window before the cooldown ends, you'll shoot immediately when the cooldown is over. These are mostly there to help immersion. You wouldn't feel very immersed if instead of paying attention to the world around you you had to worry about pressing jump the instant you hit the ground or the instant before you hit the edge of a ledge.

The art style is still something of a work in progress. I still have to learn how to properly create backgrounds that create a good parallax effect. But the direction is something I'm very happy with. Moving forward, I intend to implement interactables, an inventory, and especially a script for the camera that follows the boundaries of whatever room you happen to be in. In the meantime, I'll sign off with a few images from my path to digital artwork.




### Markdown

Markdown is a lightweight and easy-to-use syntax for styling your writing. It includes conventions for

```markdown
Syntax highlighted code block

# Header 1
## Header 2
### Header 3

- Bulleted
- List

1. Numbered
2. List

**Bold** and _Italic_ and `Code` text

[Link](url) and ![Image](src)
```

For more details see [GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).

### Jekyll Themes

Your Pages site will use the layout and styles from the Jekyll theme you have selected in your [repository settings](https://github.com/DereferenceMyPointer/Game-Dev/settings). The name of this theme is saved in the Jekyll `_config.yml` configuration file.

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://help.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.
