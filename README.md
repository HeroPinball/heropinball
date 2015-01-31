# heropinball
A fight against the machine!
Design Document
Hero Pinball
Alex Murphy-White, Hunter Oka, A.J. Ryan

Mission Statement
Elevator pitch: Hero Pinball is a desktop fantasy themed 2D arcade style platformer, that takes place inside of a pinball machine.  Like if Link from Link’s Awakening was trapped in a pinball machine.

Hero Pinball is a desktop fantasy themed 2D arcade style platformer, that takes place inside of a pinball machine. Hero Pinball aims to provide fast paced action gameplay ideal for short pick-up-and-play sessions. High score tracking and challenging levels keep players coming back for more. 
The hero Leroy, shrunk to the size of a ball, is trapped inside of a monster pinball machine. Players must master navigation through the dynamic environment to reach the top of the machine, and defeat the boss that lives there. A key gameplay element is physics simulation, with the player hero realistically interacting with the pinball machine environment, bouncing off of surfaces and obstacles. 


Objective Goals

Create an exciting 2D action game using Unity
Create a game whose gameplay utilizes Unity physics simulation
Create engaging scoring features to add replay value and to promote competition
Create unique pinball tables with authentic medieval design
Create engaging combat along with fast-paced action
Create large bosses as guardians of each pinball table

Thematic Element

Chibi medieval design from original Final Fantasy concept art.

Boss monsters designed like the Beholder from Dungeons and Dragons.

Unique character design like in Dragon Quest VIII.


Art style top-down in a medieval setting like in Zelda: Minish Cap.

Resource Library

Software:
Engine: 
Unity
-Code in C#
-Visual Studio (Windows)
-VSExpress (Windows)
Graphics:
Adobe Photoshop
Adobe Illustrator
Sound:
Logic Pro
Version Control:
Bitbucket

Required Art:
	Menu Screen
	Pause Screen
	Backgrounds
	Pinball Features:
			Flippers
			Bumpers
				-Round bumpers
				-Triangle Bumpers	
			Tubes
Platforms
				-One sided platforms
			Launcher
			Spikes
				-Spiked Bumpers
	Character
		-Character Animations
			-Movement
			-Attacking
			-Death
			-Victory
Enemies
	-Boss
		•Boss Eye
		•Boss Eye socket
		•Boss Projectiles
	Small Enemies
-Small Enemy Animations
		•Movement
		•Death
	
Pickups
	-Treasure
	-Health restore
GUI
	-Health Bar
	-Score
Application icon

Required Sounds:
	Character Sounds
	Enemy Sounds
	Environment Sounds
	Music

Game Screens:
	Start screen
		-Play
		-Instructions
		-High Scores
	Game screen
		-Pause
	Pause screen
	Instructions Screen
		-back to start
	High Score Screen
		-back to start



Design Elements

Fonts: 
Title: Dubstep Dungeons
http://www.fontspace.com/darrell-flood/dubstep-dungeons
Score: Agency FB
http://fontsgeek.com/fonts/Agency-FB-Regular

Color Schemes:
	Main Character- Red
	Enemy color schemes depends on the level
		Thunder Table- Yellow
		Ice Table- Light blue
		Fire Table- Orange

1.  Type of game
	Action platformer in pinball environment
	Physics simulation

2. Gameplay
	Moving the Player Character
-While standing, player can move right and left, and jump slightly
		-While in midair, limited player-influenced control for movement
		-Pinball objects will influence movement more than the player
		
	Health, Damage, Lives
		-Player can take 6 hits (6 hit points) before losing a life
		-Player will take hits from contacting small enemies, boss projectiles, or spikes
		-Player will have 3 lives total
		-Boss 1 will have 8 hit points, Boss 2 10 hit points, Boss 3 12 hit points
		-Player’s sword will do 1 damage, killing small enemies instantly
		-Health powerups will be on each table
Enemy behaviour 
	-Bosses will have 3 hittable areas, each will open shortly to be attacked
	-Bosses will have projectile attacks to defend themselves
	-Bosses will be at the top of each table
	-Small enemies will drop from the top of the level
	-Small enemies will hone in towards the Player
Beginning the Level
	-Player will launch into the bottom of the table
	-Score will be the sum of all previously beaten table scores
	-Player will have health refilled
	-Bonus jackpot will be reset
Beating the Level
	-Boss will explode
	-Bonus score will be applied to total score
Level progression
Player will advance through 3 levels, after which the first level will repeat. Levels will continue to repeat in sequence until all of the players lives are used up. After each set of 3 levels, the damage dealt by enemies and the environment will increase by 1, and the strength of flippers and bumpers will increase. 
Levels
	-Thunder table
	-Ice table
	-Fire table
(All tables use the same basic assets recolored/repurposed for each theme)
Scoring
	-Bonus will start at 10000 points and will go down 50 points every 5 seconds
	-Player collision with bumpers will award 10 points
	-Small enemy kills will award 100 points
	-Boss kill points: Boss 1=1000 points, Boss 2=2000 points, Boss 3=3000 points
	-Treasure on the map will award 250 points
	-Extra balls awarded at 20000 and 50000 points total
	- The users all time top scores are recorded
Camera Movement
	-Camera will always track the player
	-Camera will zoom out slightly as player velocity increases
	-Optionally a full table view can be selected
	Pausing
		The game can be paused by pressing P, or by clicking the pause button in the 
lower right corner. While paused, the camera mode can be changed. Bonus 
points do not decrease while paused. 

3.  Character List:
	Player Character - Leroy
		Leroy is a traveling warrior, always on the lookout for his next meal. 
		Character Movement - 
Left/Right and Jump while standing
Limited Left/Right movement in midair
		Character Attacks - Sword swing
		Character Health - 6 hit points
	
Enemy Characters
		-Small Enemy - Elemental Creep
			Movement - Moves slightly towards the player.
Creep is affected by gravity and environment
			
		-Boss - Elemental Pinbeast
			•3 eye sockets
• Eyeball appears in a socket
• If you hit the eyeball, moves to another socket
• Hit the eyeball enough times to win
	
4.  Environment List
	Flippers
		-Flippers activate automatically when touched
		-Flippers hit the player in a different direction depending on where they were 
 contacted
	Bumpers
		-Bumpers bounce players and creeps away at the same angle they were     
 contacted. 
		-Round bumpers are circular
		-Triangle Bumpers are right triangles			
	Tubes
		-Tubes move players from one side to the other when the player contacts one 
end. 
-One-way tubes only move the player when they contact the entrance. 
Platforms
-Platforms provide a place for players and enemies to stand. They can be at any angle
		-One sided platforms allow the player to move through from below, but not from 
above.
	Launcher
-The launcher provides a strong vertical force when contacted. The player begins each level on top of a launcher.
	Spikes
		-Spikes deal 1 point of damage to the player when contacted
		-Spiked Bumpers behave like bumpers but deal a point of damage

5. Pickups
-Pickups begin the game on each level. When contacted they disappear and provide their effect. Pickup are not affected by gravity.
	Treasure
		-Awards 250 points
	Health restore
		-Restores 2 hit points to the player

6.  Controls Schemes

Keyboard
 	-Arrow keys control character movement
	-A to swing sword
	-S to jump
	-P opens the menu
Xbox 360
	-Left stick or D-Pad control character movement
	-A jumps
	-X or B swings sword
	-Start opens the menu

7.  Story
	The evil wizard Ghaskel has just finished his ultimate trap, the pinbeast! Designed to swallow adventurers whole, and never let them escape from the bouncy hell inside its stomach. Needing to test the invention, Ghaskel lures our poor young hero Leroy with the smell of tasty meat. Entranced by meaty goodness, Leroy doesn't notice until it is too late! Swallowed by a pinbeast, Leroy must now battle for his freedom.  Destroy the pinbeast, and make the world safer for adventurers everywhere!



8.  Wireframes



9. Wishlist:
Wishlist ideas will be implemented if time allows
Sword upgrades
Powerups
More enemy types
360 Controller Support
Full table view
Wall Kicks
Online Leaderboards

User Experience

Intended user experience:
The intended user of Hero Pinball is someone looking for a short, fast paced game session, perfect for a lunch break or killing time for 30 minutes. 

Hero Pinball users enjoy the easy to understand but  satisfying and exciting game mechanics, the short time commitment required to play,  and the challenge of attaining a new high score.

Keeping user interest is done through high score tracking, and the increasing challenge as gameplay progresses.

User experience map:
After double clicking on  the Hero Pinball application icon, Hero Pinball is launched. The Start screen presents three options, Play, Instructions and High Scores. Play begins the main game at level 1. Instructions presents how to play. High scores shows the top 10 scores of previous games. 


