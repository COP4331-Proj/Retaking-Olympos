# Manual Test

This is a manual test for the "A user shall be able to double click an item to equip it" requirement. (RID 70)

| Number | Steps to Reproduce | Expected Behavior |
|--------|--------------------|-------------------|
|      1 | Launch the game | The game should open and display the title screen. |
|      2 | Hit the start button to begin a game | The main scene should be displayed. |
|      3 | Hit the view gladiators button to go to the view gladiators scene| The view gladiators scene should be displayed. |
|      4 | Double left click an item in the player's inventory that is of a matching type to the currently viewed gladiator| The item shall be equipped on the current gladiator|
|      5 | Double left click an item in the player's inventory that is of a different type to the currently viewed gladiator| The item shall not be equipped on the current gladiator|
|      5 | Double left click an item in the player's inventory that is of a matching type to the currently viewed gladiator but is already equipped| The item shall remain in the player's inventory as that slot is already filled|