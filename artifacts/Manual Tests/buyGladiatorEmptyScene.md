# Manual Test

This is a manual test for the "If no gladiators are available for purchase, the purchase gladiator screen will say so" requirement.

| Number | Steps to Reproduce | Expected Behavior |
|--------|--------------------|-------------------|
|      1 | Launch the game | The game should open and display the title screen. |
|      2 | Hit the start button to begin a game | The main scene should be displayed. |
|      3 | Hit the buy gladiator button to go to the buy gladiator scene| The buy gladiator scene should be displayed. |
|      4 | Ensure that you have more gold than the gladiator's cost and click the purchase gladiator button| The gladiator shall be removed from the shops inventory, added to your inventory, and a sound shall be played|
|      5 | Continue to purchase gladiators until they are all gone| The scene now should not display any gladiator and should instead display the message "Sorry, we are all sold out!"|