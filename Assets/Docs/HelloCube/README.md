# Hello Cube
This project is about rotating a cube and how we can improve performance by using different methodologies available in DOTS.

### Initial Setup
- Create scene with name "HelloCube"
- Have a main camera and directional light in it
- Create a Sub Scene with name "CubeRotation"
  - In this scene create a cube with another cube as head
    - Apply RotationSpeedAuthoring.cs script on this cube
      - Information about this script is in the script
  - Create another GameObject with name "Execute" and apply ExecuteAuthoring.cs script on it
    - More information about this is in the script


The ways to improve performance that we are going to test are as follows

### Main Thread
This will simulate the same performance we can achieve by implementing a regular gameObject with a script on it to rotate.
The framerate with this implementation is between 100 and 270. The 170 fps fluctuation is because of garbage collector once every 10-20 seconds

