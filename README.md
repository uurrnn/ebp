# EBP

## todo

- ~~create ui button~~
- ~~create in-game mouse use~~ _think it works by default_
- ~~create click action on button~~
- ~~switch to 'editor mode' when button is clicked~~
- ~~create 'grass cube'~~
- ### basic course functionality
- ~~limit grass cube movement to a 2 unit grid so they can only be placed adjacent to each other~~
- ~~display coordinates of cube on top quad~~
- write script to generate land
- connect generate land script to editor mode button
- add serialized property to grass cube that displays its cube type e.g sand, rough, fairway. include containsHole type
- change color of the 'Top' quad of the grass cube based on its cube type
- create and adjust a friction property on cubes that change with cube type
- ### in game map editor
- create menu UI for editor with buttons for each cube type
- display editor UI only when editor mode button is toggled on
- add light border color to cubes when in editor mode to display a grid over the cubes?
- when you click a button in the menu, you can then click on a cube and change its cube type property to the corresponding button
- add ability to click and drag across multiple cubes
- ### golfing
- add a golf button
- spawn golf ball on tee cube type
- on mouse click, hit ball in direction of mouse click
- add trigger for ball going in hole
