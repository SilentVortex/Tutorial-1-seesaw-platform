# How to make a seesaw platform.

Today we are going to make a seesaw platform within unity 2D, the version I will be using for this is 2022.3.46f1.

First off you want to make an object that you can use as a player, I will use a capsule for this.
You can find them by right clicking on the hierarchy and then going to 2D object, then sprites, then clicking on capsule.

![alt text](image.png)

Now that we have our capsule we need to add some components to it, first we want to add a rigid body 2D to it and a capsule collider 2D so that it can interact with other objects. Your capsule in the inspector should now look like this. You can use auto mass to automatically set the weight of your object depending on its size.

![alt text](image-1.png)

Now we need something to act as our platform, I'm going to go back to the 2D objects as seen before and choose square this time. Once that's done you can scale it to the length of the platform you want and then make sure to add a rigid body 2D and box collider 2D, so that it can interact with other objects as well.

The rigid body 2D's we added means that they can interact with colliders, while the capsule collider and box collider means that they can interact with the rigid body 2D's. By doing this we have given both objects the ability to interact with each other.

The final part of this tutorial is to add a hinge joint 2D component to your Platform, and then you want to enable 'Use Motor' and then 'Use Limits'. If you set the motor speed and maximum motor force to 1 you can then use the angle limits below to set your angle limits for the amount of tilt, you want to have each way. The lower angle represents how far left and the upper angle represents how far right it can go. 

This method requires no scripting as it uses the gravity used by unity to make the platform tilt depending on where the player is.