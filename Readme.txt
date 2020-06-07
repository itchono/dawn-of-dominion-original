"Dawn of Dominion" - Mingde Yin's Grade 10 ICS MAGNUS OPUS
ICS2O-02 2016 - 2017 
Mr. Hudson

By Mingde Yin

Music from Cloud Imperium Games and Riot Games
Current Build: 1.0 Release Candidate 2 (FINAL)
2017/06/11

Gliese 581g has supported life for over 1.8 billion years. However, resource deprivation 
and rising tensions between the planet's 5 remaining races threatens the survival of its inhabitants.
You have the chance to change it all, and show that unity is superior to isolation. Bring a new dawn to the planet,
a dawn of dominion.

Description of Program: A turn based battleship-esque combat and strategy game.


Key Features:
   - 16 differnt units to choose from with 16 items to create over 200 possible combinations
   - A robustly programmed 7x7 battlefield with several terrain configurations to choose from
   - 10 story missions with a computer-controlled opponent
   - Multiplayer 1 on 1 combat
   - 5 races to pick from, each with a unique and powerful passive ability
   - 100% original art and animations, done from scratch
   - 7 Achievements to earn

Special Thanks:
- Kevin Zhao for inspiring some of the early sprite designs
- Spiral Knights and League of Legends for item and lore inspiration
- Discount Dollarama game "Sea Battle Combat Naval" for showing me how interesting battleship is
- Star Citizen/Squadron 42 for music and inspiration on the space theme

CHANGELOG HISTORY
If you want to see how the game build itself up bit by bit, see below...

RERELEASE 2020
 - Removed all audio
 - Removed dependancies on powerpack stuff
 - Removed dumb quest system


HOTFIX RC3
 - Allowed unlocking of all singleplayer levels (including Advanced AI)
 - Increased label size for some indicators
 - Fixed next button not working properly in cutscene
 - Fixed starting money not setting

Release 1.0/RC2 - The Actual Final Update
 - Stats and Achievements
 - Ability to change starting money in multiplayer
 - Many, many bugfixes
 - Cutscenes
 - Redone art
 - A completed singleplayer experience
 - RndBuild added back into the game as an experimental extra challenge
 - 100% less spaghetti code
 - Quality of life updates to make the game feel finished
 - Animation enable/disable
 - Tooltip visual pass

Beta 1.2/RC1 - The Finishing Touch
2017/06/05 to 2017/06/08
 - Functional Missions
 - Optimization and code review
 - Reworked Options Menu
 - Reworked Map Selection for game modes
 - Shop Fixing
 - Tutorial
 - Reworked AI
   - Move system exists in 2 varieties: Random and "Intelligent"

Beta 1.1 - The Visual Update v2
2017/06/01 to 2017/06/05
 - Quest system - want to earn a bit more cash on the side? Take on randomly generated quests for a monetary award!
 - AI rework
   - Removal of old building system
   - AI now spawns preset configurations depending on level (Not implemented in 1.1)
   - Old build AI is still in the game just because
 - Finishing work of race damages and passives
   - Removal of inter-race damage buffs/decreases - not worth implementing, and would not add much to gameplay - not fun
   - Reworked passives 
 - Mission selection
 - Stats and achievements
 - Single Player Story
   - Completely new art, all 100% original, hand done by me
 - Animated menu screen, new icon
 - Heat Signature System - speeds up game
   - Some items will be reworked in order to account for this new stat

Beta 1.0 - The Visual Update v1
2017/05/28 to 2017/05/31
 - We've hit beta!
 - Shop revamp - selling
 - AI unit placing - very buggy
 - Better map selection and race selection
 - Visual improvements all around
 - Reworked shop indicators - now show size of a unit
 - NEW: Menu splash, several units, new art (farewell, original menu screen)
 - Race Passives
   - Equanos: Communism Booster - Gain an extra 10% money each turn
   - Elementan: Mending Sap - Gain 5% of max HP on all alied units if they are damaged every turn
   - Infernus: Flaming Strikes - Damage Enemies for 5% of their max HP per turn for 2 turns afterwards
   - Prisma: Omniscient Illunimation - Upon striking an enemy unit, reveal a 3 x 3 area around them permenantly
   - Umbra: Dark Affinity - Enemy attacks have a 10% chance of missing

Alpha 1.4 - The Diversity Update
2017/05/20 to 2017/05/27
- Race selection - Does nothing at the moment
 - Damage/Race Rework
   - Damage types no longer exist; everything is now "normal damage"
   - However, the different race units have a rock paper scissors type deal with each other.
   - Equanos ---> Infernus ---> Elementan
         ^                         V
   -     |--------  Prisma <--- Umbra
   - Each has a 15% Damage increase against that type of unit
   - Beware, player race =/= unit race
   - i.e. a player can be playing as infernus, but their elementan unit is what matters for the damage matrix
- First AI iteration
   - All random moves
- Shop Revamp
   - Selling Upgrades
- Lore and story start
- Vision system
   - The enemy remains forever shrouded, that is, until you hit them, at which point you can see their stats
- Colour based HP indication
   - Don't want to tooltip over to see your unit's HP? We got a solution.
- Unit Placement Overhaul - Terrain and Bounds Verification
   - Now with 100% fewer exceptions from being outside the bounds of an array when placing units!
   - 30% more realism and immersion - tanks no longer go in water, ships no longer go on land


Alpha 1.3 - The Multiplication Update
2017/05/12 to 2017/05/20
- Beginning of multi-grid system
   - Multi-Grid units combine the AD of the entire unit when attacking
   - You have to destroy all of the parts, or just aim for the head to win
- Overhaul of stat system
   - Battleship functions:
   - GetStat, SetStat, SetTotals
       - The meat and potatoes behind damage calculation

- A rather slow phase in development, but nonetheless an important one, for adding important infrastructure.

Alpha 1.2 - The Counting Patch
2017/05/09 to 2017/05/12
- Partially working stat system
- Overhaul - number of units system

Alpha 1.1 - The CleanUpdate
2017/05/08 to 2017/05/09
- Logic overhaul from max. point system to full grid string array
- Smoother overall
- Shop system and persistence first implementation

Alpha 1.0 - The First Big Deal
2017/05/07
- Functioning base game (battleship itself)
- Unit status tracking for hit/no hit
- Back and forth actions working
- Preliminary shop system added

Pre-Alpha 1.2 - The Turn of the World
2017/05/03
- Beginning of turn persistence

Pre-Alpha 1.1.1 - The Minor Update
2017/05/03
- Beginning of turn system
- Different target generation and identification
- Beginning of transition to point coordinate system from short coordinate system

Pre-Alpha 1.1 - The Sound of Music
2017/05/02
- Dynamic audio system added
- Fixed scaling issues
- Added semblance of gameplay and placement functionality

Pre-Alpha 1.0 - The First Generation (of Arrays)
2017/05/01
 - First version
 - Array generation implemented
 - Preliminary hit logic implemented
