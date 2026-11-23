
using System.Runtime.CompilerServices;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
// Note to grader: I'm going to start commenting on my code so I can reference my own code for help later on :)


public class TreeOfBirds : MonoBehaviour // MonoBehaviour allows class to become a component
{
    [SerializeField] private Bird[] Birds; // SerializedField -> tunable, Bird[] -> Array of bird objects
    [SerializeField] private float InteractDist; // Tunable interaction distance
    [SerializeField] private Player _player; // Player component so we can access the players position

    // Main loop to check interaction distance
    private void Update()
    {
        
        for (int i = 0 ; i < Birds.Length ; i++) // For the ammount of birds in the bird array
        {
            if (Vector3.Distance(Birds[i].transform.position, _player.transform.position) <= InteractDist) // Distance between position of bird at index i and player component position
            {
                Birds[i].gameObject.SetActive(true);
                
            } else
            {
                //Birds[i].gameObject.SetActive(false);
            }
            
        }
    }




}
