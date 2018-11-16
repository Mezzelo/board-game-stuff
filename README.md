# board-game-stuff

![picture of what it looks like wew](https://github.com/Mezzelo/board-game-stuff/blob/master/samplePic2.png)

basically tabletop simulator lite.    
Set this up in ~2 hours so people don't have to cut out their paper games to test them.  also makes online playtesting easier

# setup/instructions

The repository itself is a Unity project you can open up and mess with.    
Click and drag to pick up and drop items.    
Right click to bring the item your mouse is hovering over to the bottom.    
Hold shift to pick up multiple items with the same tag.    
Hold control to do the same but with whatever tags.    

While holding shift or control...    
Mousewheel up/down to modify spacing between objects    
Click to move one card forward.    
Right click to move one card back.    
Space to bridge and shuffle.     
T to reverse the order of your held cards.     
R to flip card to front/back if it has the appropriate components and if you're using shift.

Escape to reset the scene.

You can set up your paper prototypes using this pretty easily.  Objects (like tokens or cards) should be under the "Interactive" gameobject in the hierarchy and use a SpriteRenderer component with the "ShaderMat" material, found under /Assets/Shader.  Use the "CardBack" component for objects with two sides you can flip between.

If you don't understand any of that check the "sample-project" branch.  it's our group's prototype lol

# acknowledgements

Uses a slightly modified version of Seyed Morteza Kamali's two-pass sprite drop-shader, cause I didn't really have time to do it myself.  https://github.com/UnityCommunity/UnityLibrary/blob/master/Assets/Shaders/2D/Sprites/SpriteDropShadow.shader    
made to ease up development for stuff.    
please don't rip my code for your final project or for profit why would you do that
