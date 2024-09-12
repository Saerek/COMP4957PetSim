using UnityEngine;

public class Pet : MonoBehaviour
{
    // Basic pet stats
    public string petName = "Fluffy";    // The name of the pet
    public int level = 1;                // Starting level of the pet
    public int health = 100;             // Health of the pet
    public int attackPower = 10;         // Attack power of the pet
    public int speed = 5;                // Speed of the pet

    // Method to increase stats when training the pet
    public void Train()
    {
        level++;               // Increase the pet's level
        health += 10;          // Add 10 to health each time the pet is trained
        attackPower += 2;      // Add 2 to attack power with each training
        speed += 1;            // Add 1 to speed with each training

        // Log the updated stats to the console for debugging
        Debug.Log(petName + " trained! New stats: Health=" + health + ", AttackPower=" + attackPower + ", Speed=" + speed);
    }

    // Method to display pet stats
    public string GetStats()
    {
        // Return a formatted string displaying the current stats
        return $"Pet: {petName}\nLevel: {level}\nHealth: {health}\nAttack Power: {attackPower}\nSpeed: {speed}";
    }
}
