using UnityEngine;

public class OpponentPet : MonoBehaviour
{
    // Basic opponent pet stats
    public string petName = "Wild Pet";    // The name of the opponent pet
    public int level = 10;
    public int health = 300;
    public int attackPower = 35;
    public int speed = 30;

    // Method to display the opponent's stats
    public string GetStats()
    {
        return $"Opponent: {petName}\nLevel: {level}\nHealth: {health}\nAttack Power: {attackPower}\nSpeed: {speed}";
    }
}
