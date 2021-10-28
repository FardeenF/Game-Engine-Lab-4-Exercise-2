Lab 4 Exercise 2

Introduction:
I created my first scene with a player and an enemy. Should the player touch the enemy they will be destroyed and an audio clip will play.
The logic and behind the collision and my player's movement was created in a PlayerController script.

Singleton Pattern:
I created a script called EnemyManager which was a singleton script, attached to an empty game object. It tracked the amount of enemies the player had defeated.
I created the singleton script by first creating an instance with a get and private set method.
Then I made a public int called value that would be used to track the number of enemies defeated.
In the Awake function I check if the instance is equal to null. I it is then I equate the Instance to THIS and call the DontDestroyOnLoad function for the game object.
If the instance is equal to anything else I call the Destroy function on the game object.
My PlayerController script is also involved in the singleton pattern with regards to getting the variable information and outputting it.
In this script I create a public Text variable called valueText that will be used to output the Singleton value we stored.
Inside the Update function I am constantly updating the valueText and equating it to the EnemyManager's instance value that we have.
In the collision check that I make with the enemies I call the EnemyManager script's instance to add 1 to the value from that script.
Out in the Unity hierarchy, I make sure to drag the appropriate Text called EnemyCounter from my Canvas to attach to my PlayerController script as the valueText.

Observer Pattern:
The observer patter also involves two scripts.
The first was the DestroyEnemyPlay which holds all the functions to get the audio source of my audio clip and play my audio clip.
This script was attached to my audio source game object.
The second script involves my PlayerController script which also handles my player's movement and collision with enemies.
In the script I create a public static Action variable called enemyDestroyed.
Inside the collision check I make with the enemies I have an observer region created.
In that region I invoke enemyDestroyed to play the audio clip from DestroyEnemyPlay.

