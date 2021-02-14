# Program Organization

You should have your context, container, and component (c4model.com) diagrams in this section, along with a description and explanation of each diagram and a table that relates each block to one or more user stories.

See Code Complete, Chapter 3 and https://c4model.com/

### System Diagram:
In this diagram, the player of the game will interact with the Unity engine to play the game. THe Unity engine will be able to access game scripts and assets from the audio, graphics, and game systems. The game system will have access to both the audio and graphics systems if any assets need to be modified. 
<img src="Pictures/High-Level Architecture/System Diagram (3).png">

### Container Diagram:
The game system will be run under a client-side desktop application, comprised of C# code.
<img src="Pictures/High-Level Architecture/Conatiner Diagram.png">

### Component Diagram:
The game component will be able to use every other component to allow it to keep track of the current game state. The management component will be able to use the item and playable character components in order to create a functional market for the player. The battle system will utilize the playable character and non-playable character components to generate battles for the player to fight in. The playable character component will have access to the item component to allow the player to equip items to customize their gladiators.
<img src="Pictures/High-Level Architecture/Component Diagram.png">

### User Story Table:
| Component | User Story ID(s) |
|----------------|---------------|
| Game Component | 007, 008, 024, 027 |
| Management Component | 011, 012, 016 |
| Battle Component | 019, 020, 021, 026, 029, 030, 031, 032 |
| Playable Character Component | 015, 017, 018 |
| Non-Playable Character Component | 022 |
| Item Component | 013 |

# Code Design

You should have your UML Class diagram and any other useful UML diagrams in this section. Each diagram should be accompanied by a brief description explaining what the elements are and why they are in the diagram. For your class diagram, you must also include a table that relates each class to one or more user stories.

See Code Complete, Chapter 3 and https://c4model.com/

We need the GladiatorCharacter class to manage each gladiator. This class contains the gladiators' health, stamina, class, etc...
A ton of variables from the GladiatorCharacter class will be used in the DamageControl class to calculate how much damage the gladiator will deal/will be dealt
The movement class is needed to control the movement of the characters. The amount of sprint energy a character has will be determined by its stamina
The PauseControl class is simply there to pause the game.
OptionsMenu will manage everything in the options menu. This includes but is not limited to: adjusting the difficulty, resolution, and volume of the game.
ManagementStats will keep track of everything during the management phase. The includes but is not limited to: currency and skillpoints
The skill class will manage the gladiators' abilities. 
The weapon class is there to create weapon objects. The class will control the name, damage type, damage, and cost of the weapon
The SceneLoader class is there to switch between scenes.
<img src="Pictures/Class-Diagram/ClassDiagram.png">

<img src="Pictures/Class-Diagram/UserStoryTable.png">



# Data Design

If you are using a database, you should have a basic Entity Relationship Diagram (ERD) in this section. This diagram should describe the tables in your database and their relationship to one another (especially primary/foreign keys), including the columns within each table.

See Code Complete, Chapter 3

# Business Rules

There are no specific business rules that apply to our project.

# User Interface Design
### Start Screen:
Allows the user to start a new game, go to the options screen, or Quit.
If the user has a save file, they will be able to load it aswell.
<img src="Pictures/UI/StartMenu.png">

### Options Menu:
Allows the user to tweak options of the game including resolution, volume, and difficulty
<img src="Pictures/UI/Options.png">

### Main Menu:
Contains links to View gladiators, Buy Gladiators, and Shop
Links to up to three different fights to choose from.
<img src="Pictures/UI/Main-Scene.png">

### Pre-Battle:
This screen shows you stats about the gladiator you choose to fight this battle with and the opponent gladiator. It also shows who is favored to win with a ballence of power bar. The reward for the fight is increased if you are the underdog. The user can choose to change the gladiator for this fight before accepting the duel or backing out.
<img src="Pictures/UI/Pre-Battle.png">

### View Gladiators:
This screen links to the Skills and Shop screens.
This screen lets you view details about your gladiators. The arrows cycle through list of your gladiators.
On the left, you are shown basic statistics about your gladiators, and in parenthesis see what stats are coming from items.
On the right, you are shown the players inventory, orginized by tabs of item types.
In the center, you are given slot onto which you can drag appropitems to equip them. 
<img src="Pictures/UI/View-Gladiator.png">

### Buy Gladiators:
This screen lets you cycle through a pool of new gladiators for sale and buy ones to add them to your collection
<img src="Pictures/UI/Purchase-Gladiator.png">

### Shop:
This screen lets you buy and sell items to and from a general shop
Player items are on the right and the shops items are on the left.
Dragging an item from the shop to your inventory subtracts its price from your gold and adds it to your inventory,
Dragging an item from the your inventory to the shop adds its price to your gold and removes it from your inventory,
<img src="Pictures/UI/Shop.png">

### Skills:
The arrows allow you to cycle through the skills menu for each of your owned gladiators
The skills menu has two trees of skills, one general for all gladiators, and a second unlocked when selecting a class
When clicking on a skill tree node, the box in the center is filled with its description and the user can purchase it if they have a skill point to spend. Highlighted nodes are already bought.
<img src="Pictures/UI/Skills.png">

### Battle:
The user is shown their health in the middle left of the screen and their stamina, which is used to execute abilities, in the middle right of the screen. 4 circles on the bottom middle show the gladiators unlocked activated abilities keyed to 1 ,2 ,3 , and 4 respectivly;
<img src="Pictures/UI/In-Battle.png">

### Pause Menu:
The user has access to a pause menu at any time. This allows them to pause the game, save and load, adjust options, and quit the game.
<img src="Pictures/UI/Pause-Menu.png">

### Navigation Map:
This diagram shows how the user is able to navigate between scenes. The previous scene is kept track of, and the back button common to many scenes takes the user to that scene
<img src="Pictures/UI/Navigation Map.PNG">

### User Story Chart:
This chart shows which user stories are related to which screens
<img src="Pictures/UI/User story link chart.PNG">

# Resource Management

Resource management will primarily be handled by Unity. The game will likely be single-threaded, but regardless this is all handled by Unity.

# Security

- No sensitive information will be stored or accessed, therefore the security risk is much lower design-level. Progress will be stored and saved locally on machines, but efforts will be taken to ensure no file pointers are left open.
- As far as code-level goes, all commits will be peer reviewed for any code vulnerabilities such as buffer overflows, null pointer dereferences, etc. Using Visual Studio for the coding portion also aids in this effort as it provides a basic static analysis and can catch some of the mentioned vulnerabilities before they make it into a commit.

# Performance

Because this is a game, performance is a big aspect of the project. Efforts will be made to keep the game objects simple and not complex, meaning model geometry will be very simple and the number of vertices will be likely very low on most objects as we are using primarily pixel art. Unity offers classes such as OnDemandRendering that may be used to help improve CPU performance if necessary. The frame rate can also be capped at 60 FPS in specific scenes such as the main menu and options screens to decrease power usage.

# Scalability

As far as scalability is concerned, the system will be pretty static and growth and scalability is not expected to be a concern.

# Interoperability

Data or resources will not be shared with any other software or hardware.

# Internationalization/Localization

Because we are using Unity, which builds on Visual Studio for the code portion, it is possible to allow volunteers to translate strings, however this is outside the scope of our project and will not be implemented.

# Input/Output

The primary I/O concern for the project will be reading and writing to the save file. Textures and game objects are primarily handled by Unity, and we can safeguard against any errors with those by checking to make sure the game objects or textures are not null. Any I/O errors with the save file will be detected at the file level when it comes time to read it. If the save file contains data that is not expected, the user will be informed of a corrupt save file and will be prompted to delete the save file.

# Error Processing

- Error processing will be mixed. As mentioned in the I/O section, if the save file contains data that is not expected, the user will be informed of a corrupt save file and will be prompted to delete the save file, thus I/O error processing will be detective. Graphical error processing will be corrective as we will attempt to reload any textures or game objects with issues.
- Error detection will be active as we will be implementing unit tests. We will calculate expected movement (x and y positions) and compare it with the actual position of the user for example.
- The error propagation will wait until all processing is complete and notify users of errors after attempting to correct them.
- The error messages will follow a straightforward format. The user will not receive complex errors such as "Null object detected", instead they will be informed about the issue, so the error message for a texture that fails to load and ends up null will read "Unable to load texture successfully, please restart the game".
- Most of the errors will be handled at the point of detection.
- Each class will be responsible for validating its own data. Classes such as the save file will be prepared for any unexpected data.
- We will be using Unity's built-in exception-handling when necessary.

# Fault Tolerance

We expect fault tolerance will be most relevant with any graphics. The system will try to correct these by reloading textures or game objects, but if it is an important game object, the system will quit and inform the user they should restart their game. In the case of texture issues, the game can continue to operate. Any issues detected with unit testing will be conveyed to the user and depending on the severity will either be discarded or require the user to restart the game.

# Architectural Feasibility

We believe the system is technically feasible and that there are no areas that could render the project unworkable.

# Overengineering

Any overengineering issues will be resolved with explicit user stories. Assets will likely be pre-made content for most aspects, so no assets should be overengineered.

# Build-vs-Buy Decisions

We will not be using any third-party libraries outside of what is already provided by Unity.

# Reuse

Preexisting software will not be used.

# Change Strategy

Because Unity is new for all of us, our user stories may be changed to fit within what is within the scope of Unity projects. If any overly ambitious user stories are provided, we will scale them down accordingly. We may create classes in advanced based on our class diagram, which are to be implemented later, unless the corresponding user story or stories need to be changed.
