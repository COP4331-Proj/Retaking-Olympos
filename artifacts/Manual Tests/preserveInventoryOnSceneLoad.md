# Manual Test

This is a manual test for the "A gladiators equipment will be preserved through scene loads" requirement.

| Number | Steps to Reproduce | Expected Behavior |
|--------|--------------------|-------------------|
|      1 | Launch the game | The game should open and display the title screen. |
|      2 | Hit the start button to begin a game | The main scene should be displayed. |
|      3 | Click the view gladiators button| The view gladiator scene should be displayed to the user. |
|      4 | Click and drag and item from the inventory| The item should become semi transparent and follow the mouse |
|      5 | Drag the item onto a correct slot | The item should shown equipped in the slot, be removed from the players inventory, and the stats of the gladiator should update |
|      6 | Click the back button to return to the main scene and then go back to the view gladiators scene | The state of the players inventory will be preserved |

