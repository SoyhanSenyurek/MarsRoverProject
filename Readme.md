<b>Mars Rover</b>

A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth.

A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

<b>Input:</b>
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.

The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.

The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.

Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

<b>Output:</b>
The output for each rover should be its final co-ordinates and heading.

<b>Input and Output</b>

Test Input:
5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM

Expected Output:
1 3 N
5 1 E


<b>General logic of the program:</b>

The user is expected to select a rectangle on a Mars.
After selecting this rectangle, the current position of the person going to Mars and the path to explore is determined.
If the road L is selected, it is turned 90 degrees to the left, if R is selected 90 degrees to the right, if M is selected, it is provided to go 1 step forward.
The compass was used to turn left and right. Rotations were performed by using N, W, S, E in the compass.
In order to go 1 step forward, the x and y coordinates are decreased or increased according to the direction.

If looking to the N side y is increased by 1. </br>
If looking to the W side x is reduced by 1. </br>
If looking to the S side y is reduced by 1. </br>
If looking at the E side x is increased by 1. </br>
