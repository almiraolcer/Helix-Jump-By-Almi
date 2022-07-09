
# Helix Jump Clone via Unity
I cloned the Helix Jump that is originally created by Voodoo. 
The reason I choose Helix Jump Game to clone is that Hyper Casual games are very trending and in high demand. Since I want to focus in a field where I can build Hyper Casual Games I find cloning as a very helpful way to practice.
I used my own logic and strategy while I am building the game for the purpose of understanding and absorb every little detail in the developing process. So, that I can build a strong foundation and educate myself more about Unity’s several tools.

# Details
Here is the logic behind the game. There is a ball and cylinder. Cylider is consists of several rings that involves safe and trap platforms. You need to get ball reach to the Finish Line by moving the cylinder using safe platforms and avoid the traps.  If ball hits the trap platform, game will over. Each time ball passes a ring you will get points. 
## I have created 3 levels:
## Level 1 : 
There are some Safe and Trap platforms. Trap platforms are in darker shade. Avoid the Trap platforms and reach to the finish line.
## Level 2 :
There are Tricky Platforms as well as safe and trap platforms. Tricky platforms fall when ball hit them once. Avoid the tricky platforms and use them wisely to reach to the finish line.
## Level 3:
There are Moving Platforms as well as Safe and Trap platforms.  You can use moving platforms as a way or you may need to avoid them if they are Moving Trap Platforms. Avoid the Trap Platforms and reach to the finish line.


The game has UI screen that shows the total point, Next Level, Retry and Exit buttons.

# Game play Screen shots



<img src="https://user-images.githubusercontent.com/83727549/178103166-18693e84-23d4-4ad1-ae19-b97b5ddea296.jpg" width="30%" height="30%"><img src="https://user-images.githubusercontent.com/83727549/178103165-8883107a-0494-41eb-bb72-407f45064cb3.jpg" width="30%" height="30%"><img src="https://user-images.githubusercontent.com/83727549/178103164-cd571cfe-4b3e-45c4-bce0-fef611055cd3.jpg" width="30%" height="30%">

# Game UI Screen shots
<img src="https://user-images.githubusercontent.com/83727549/178103170-a1e9bf09-30a7-42fe-b915-2486b79ed590.jpg" width="30%" height="30%"> <img src="https://user-images.githubusercontent.com/83727549/178103172-a8d657bd-c0a1-40b2-87c4-dc2c75715e3e.jpg" width="30%" height="30%">


## I use several concepts in my game Project to make them more efficient and get a better understanding of how they work.
## URP:
I created the project as The Universal Render Pipeline (URP)
## New input System :
![8](https://user-images.githubusercontent.com/83727549/178103184-cb499011-c6c2-4147-9748-aadcf1ce7948.jpg)

The movement of Cylinder is controlled with the new input system. Keyboard arrows are used to move the Cylinder.
## DoTween:
<img src="https://user-images.githubusercontent.com/83727549/178103176-e22bb07d-061a-4788-a44b-062d1a29f9d7.jpg" width="40%" height="60%">

I used DoTween engine and its features in Level 2 and Level 3. In Level 2 for Tricky Platforms I used DOMove. And for Level 3 , for the Moving Platforms I used DORotate.

