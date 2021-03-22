# Manual Test

This is a manual test for requirements 73 and 74, which involve saving and loading the data in the game
scene to and from save files.

| Number | Steps to Reproduce | Expected Behavior |
|--------|--------------------|-------------------|
|      1 | Enter the game scene | There should be a player and enemy gladiator with their health/stamina bars topped off. |
|      2 | Press the escape key | The pause menu will be pulled up |
|      3 | Click the save button | The game should create 2 save files: one for each gladiator |
|      4 | Press the escape key | The player will enter the game scene again |
|      5 | Hold a and shift for 5 seconds | The player gladiator should sprint to the left and use some of its stamina |
|      6 | Wait 5 to 10 seconds| The enemy gladiator should catch up and attack the player gladiator, which should deplete some of the player's health |
|      7 | Press d and space | The player gladiator will face and attack the enemy gladiator which will deplete some of the enemy's health|
|      8 | Press the escape key | The pause menu will be pulled up |
|      9 | Click the load button | The data stored in the save files will be loaded back onto the gladiators |
|      10 | Press the escape key | The player will enter the game scene again. The gladiators' health/stamina bars and positions should be the same as it was when the save button was pressed |