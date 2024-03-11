# SinglePlayerMultipleObjects

An example project showing how to send input message to multiple components with the new Unity input system.

## The issue

When using the new Unity input system and the `PlayerInput` component, it is not possible to forward input messages to multiple objects. This is a common use case when you want to have a single player controller sending inputs to multiple game objects.

The scene `SinglePlayerMultiplePlayerInputs` shows a simple example of this issue. Two separate input actions control the green and red balls with the left and right sticks on the gamepad or the `WASD` and arrow keys on the keyboard. A third object listens for the `P` key or the start button on the gamepad to pause the game. The red ball, green ball, and UI canvas all have `PlayerInput` components, but only one of them will receive input from the input system.

The problem is that the `PlayerInput` component is designed to be used with a single player, so when you have multiple `PlayerInput` components in the scene, each is assigned a user and mapped to an available controller.

## The solution

The scene `SinglePlayerSingleInput` shows one way to solve this problem. It has a single empty `Input` object with the `PlayerInput` component on it. It takes this input and sends it onto to each of the game objects that requires it.
