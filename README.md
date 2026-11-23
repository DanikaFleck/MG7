# MG7
## Devlog

Danika Fleck

TreeOfBirds script:
I defined a float component for the interaction distance, a player component to actually be able to get the distance between the player and the birds, and an array of bird objects. Since these are all components, they can be tuned in the inspector. Within Update() I have a for loop that itterates through the birds array and checks if each bird is within that interact distance. I used the Distance method to calculate the distance between the position of the bird at index i and the player's position. If the distance is smaller than the interaction distance the bird at index i is set to active. At first my else statement disabled the birds if they weren't within the distance, but after watching the sample project, I realized that's not what the professor wanted so I just commented it out.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
