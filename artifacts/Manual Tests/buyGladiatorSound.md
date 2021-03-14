# Manual Test

This is a manual test for the "A user shall hear an audio sound when buying a gladiator" requirement.
(Also tests "A gladiator available for purchase will be removed from the store when bought" and "A user shall be able to buy a gladiator on the buy gladiator shop screen only if they have enough gold for it", but those are tested in the automatic tests, the manual test it just to check that audio is correctly played)

| Number | Steps to Reproduce | Expected Behavior |
|--------|--------------------|-------------------|
|      1 | Launch the game | The game should open and display the title screen. |
|      2 | Hit the start button to begin a game | The main scene should be displayed. |
|      3 | Hit the buy gladiator button to go to the buy gladiator scene| The buy gladiator scene should be displayed. |
|      4 | Ensure that you have more gold than the gladiator's cost and click the purchase gladiator button| The gladiator shall be removed from the shops inventory, added to your inventory, and a sound shall be played|