# Program Organization

You should have your context, container, and component (c4model.com) diagrams in this section, along with a description and explanation of each diagram and a table that relates each block to one or more user stories.

See Code Complete, Chapter 3 and https://c4model.com/

# Code Design

You should have your UML Class diagram and any other useful UML diagrams in this section. Each diagram should be accompanied by a brief description explaining what the elements are and why they are in the diagram. For your class diagram, you must also include a table that relates each class to one or more user stories.

See Code Complete, Chapter 3 and https://c4model.com/

# Data Design

If you are using a database, you should have a basic Entity Relationship Diagram (ERD) in this section. This diagram should describe the tables in your database and their relationship to one another (especially primary/foreign keys), including the columns within each table.

See Code Complete, Chapter 3

# Business Rules

There are no specific business rules that apply to our project.

# User Interface Design

You should have one or more user interface screens in this section. Each screen should be accompanied by an explaination of the screens purpose and how the user will interact with it. You should relate each screen to one another as the user transitions through the states of your application. You should also have a table that relates each window or component to the support using stories.

See Code Complete, Chapter 3

# Resource Management

See Code Complete, Chapter 3

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