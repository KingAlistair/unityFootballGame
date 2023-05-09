# UnityFootballGame - C# Mandatory II
C# mandatory II. by Fernanda Cunha Bacelar and Daniel Szabo.
![235305636-ad2a034a-27ab-4a9f-b58c-39a0fc788cc5](https://user-images.githubusercontent.com/60754393/236006994-22cc635b-203b-419a-8127-aa5af86cf9c3.jpg)

## The assignment

Your assignment is to provide a simple football game inside Unity. There is a certain minimum to meet, and a few additional topics that you should at least make an attempt to implement. If you are confident working in Unity, you may continue to add features into the game as explained below.

You must provide a 3D game, that provide multiple levels with increasing difficulties through-out.

 Main Scene provides a menu to select each individual level as well as exiting the application gracefully, both inside and outside of the editor.

Each level contains a football pitch, on which you operate. It may have additional graphics and features (such as tribute stands etc), but only the playing field is required. The task is to dribble the ball from your own goal line and into the opponents goal.

The ball must be operated by physics, i.e. by adding impulse force to a RigidBody.
The player may move the ball by pushing it (colliding with) and/or kicking it (Keypress).
The player must be operated by a character controller, and can move freely in all directions using arrow keys.
Player variables (e.g. speed, traction etc) is configurable through the editor, and may vary on the individual levels
The main camera should follow the ball at all times, not the player
You should play a sound when each level starts (e.g. the referees whistle)
You should play a sound when the ball reach the goal (e.g. a cheering crowd)
In the top of the screen, you must display the time since game start, i.e. a running timer.
At any time, you can press ESC and abandon the current level and return to main menu
Make sure the pitch is bound, so the player cannot run outside the pitch
 

## The mandatory levels

First level is just a practise level, trying to get the ball into the goal, and the pitch could be smaller if necessary. If the ball is outside the pitch, you die and restart the level


Second level should contain one or more adversaries on the pitch. If the ball touches the adversary, you die, and restart the level. One of the adversaries could be a goal keeper. Adversaries should be modelled from a prefab

 

Third level should contain moving adversaries. Although this have not been covered in lectures, it is demonstrated in the accompanying course book, chapters 18 and 19. Especially a goal keeper is a good candidate to move in a configurable way


## Features to attempt (See how to work on these later)


### The Story line

 
As is common in many games, you cannot enter a level without having completed the previous level. Initially only the first level is available, once that is completed, the next level is made available. You should update the main menu, so only the available levels can be played (e.g. disable the play buttons on levels that are not completed yet). You do not need to store the state, but rather keep it in memory and let it reset each time you restart the game.

 

### The Streaker


In some leagues, you have the occasional streaker, i.e. a person that enters the pitch and run across it, usually to provoke or promote a political statement. Very random, a streaker can appear and run across the centre line and then disappear again.


### The Multiplayer game


Instead of having just a single player, you can add multiple players to your team on advancing levels. You would then have an ‘active’ player, that operates by the key presses, and having a key to switch between your players (use S as the trigger key). The active player should be visibly unique on the pitch (e.g. have a marker over his head or something). 

 
### The multi-camera angle

 

Place more than one camera near the ball so it can be seen from different angles. Only one camera should be active at any time (which is the way to switch between them). Implement a key trigger (Use C as the trigger key) to toggle between the active cameras. At least one of the cameras should follow the player/active player 

### The Time-Limit and record tables

 
You should introduce a standard time to complete the level, and then present a count-down instead of a running clock. Before expiring, the clock should provide visible and audible clues, i.e. changing font colours, playing a warning sound. Do this when a configurable percentage of the time is left, e.g. 10%. The time taken to complete a level should be stored in memory together with the current time, and this information will be presented on the main menu, so you can see when someone broke the fastest record. If a level has not been completed, no information should be shown

 
### Optional features

You may add as many optional features as you want, if you feel confident about your skills, but please make sure you have made the mandatory levels as well, just for reference.

## How to work

You should store your Unity project in a git repository. A master branch should exist with the final solution. The branch should be able to build and run without any problems. You should complete the mandatory parts first and make sure they are committed. Then create a branch for each of the optional features, and make an attempt at solving them. If the solution works, then merge the solution into the master branch (use git merge --no-ff to keep the branch history). If the optional solution does not work, leave the branch in the repository.

Note that Unity use a lot of intermediate files, so make sure to provide a suitable git ignore file to exclude the unnecessary git files. That goes for any IDE files as well. They do not belong inside a git repository. 

The repository should have an explanatory README.md, which should explain what works and additional information I may need.
 
Similar to the last assignment usages of stack overflow and chat got should be recorded in a LINKS.md and a chat subdirectory


## Marking
 
The project will be marked as either approved or not approved. However, in order to provide some further motivation I will judge the solution within a few distinct categories

Best gameplay experience 
Best user experience (graphics, sounds etc)
Most original game idea (does not need to work, just the idea)
 

If there is anything you want to point my attention to, please make sure to write it inside the README file. I will come up with a price to the winners of all categories
 

## Practicalities

You can solve the problem in groups up to 3 people, however, it is not necessarily an advantage being in a group.

The solution should be a git repository, either as a link to a GitHub repository or as a git bundle attached to the response.

git bundle create xxx.bundle --all

Use your name(s) as the filename, to make it easier for me.

On the plan for this assignment, you can find additional resources and repositories that may be helpful when completing this assignment.

If you need help and cannot find solutions on the internet, feel free to write on Fronter, so anyone of your class mates may offer their help. I’m sure there are a few that can help with your problem
