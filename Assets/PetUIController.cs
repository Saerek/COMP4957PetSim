using UnityEngine;
using UnityEngine.UI;

public class PetUIController : MonoBehaviour
{
public Pet pet;                  // Reference to the player's pet
    public OpponentPet opponentPet;  // Reference to the opponent pet
    public Text petStatsText;        // Text UI element to display the player's pet stats
    public Text battleResultText;    // Text UI element to display battle results
    public Text opponentStatsText;

    void Start()
    {
        UpdatePetStats();
        UpdateOpponentStats();
        ClearBattleResults();
    }

// Method to update the UI with the pet's current stats
    public void UpdatePetStats()
    {
        if (pet != null)
        {
            petStatsText.text = pet.GetStats(); // Update the player's pet stats
        }
    }

    public void UpdateOpponentStats()
    {
        if (opponentPet != null){
            opponentStatsText.text = opponentPet.GetStats();
        }
    }

// This method is called when the player presses the "Train" button
    public void OnTrainButtonPressed()
    {
        if (pet != null)
        {
            pet.Train();   // Call the Train method from the Pet class
            UpdatePetStats(); // Update the UI with the new stats after training
        }
    }

    // This method is called when the player presses the "Battle" button
    public void OnBattleButtonPressed()
    {
        if (pet != null && opponentPet != null)
        {
            string result = Battle(); // Call the battle method to determine the result
            battleResultText.text = result; // Display the result in the UI
        }
    }

// Method to clear the battle result text
    public void ClearBattleResults()
    {
        if (battleResultText != null)
        {
            battleResultText.text = ""; // Clear the battle result text
        }
    }


    // Method to handle the battle logic
    private string Battle()
    {
        // Compare stats (e.g., health, attackPower, speed) to determine the winner
        int playerScore = (pet.health + pet.attackPower + pet.speed);
        int opponentScore = (opponentPet.health + opponentPet.attackPower + opponentPet.speed);

        if (playerScore > opponentScore)
        {
            return "You won the battle!";
        }
        else if (playerScore < opponentScore)
        {
            return "You lost the battle!";
        }
        else
        {
            return "The battle is a draw!";
        }
    }
}