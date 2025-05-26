# DOTS-Learning
### Q: What is DOTS?
A: Unity DOTS (Data Oriented Technology Stack) is a system that Unity provides to harness the power of multithreading. 

We all know that Unity is a single threaded game engine means all of the processing of all the different systems that Unity engine provides, run on one and only one thread which is kind of waste of resources as almost all of the devices today has multiple cores and multiple threads running on them to be able to improve the performace of applications. To resolve this single-threaded problem of Unity, the DOTS system was introduced.

In this repository, we will try to unlock the powers of DOTS in Unity and will try to implement different projects along the way. 

### Setup:
To set up DOTS in Unity, we'd need the following steps:
- Make sure the Unity version is 2022 LTS or later
- Make sure the Universal RP package is imported
	- URP profile is created and referenced in the Quality section in ProjectSettings
	- Use the URP lit materials for the objects you have in your scene
- Make sure that the following packages are also imported
	- Entities
	- Entities Graphics
	- Mathematics
