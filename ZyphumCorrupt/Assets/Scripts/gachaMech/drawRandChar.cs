using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class drawRandChar : MonoBehaviour
{
    private int countOfChars = 0;
    private string[] namesOfChars;
    private string[] files = Directory.GetFiles("Characters/", "*.xml");

    // Start is called before the first frame update
    private void Start()
    {
        // Counts how many files there are to set in randomizer
        countOfChars = Directory.GetFiles("Characters/", "*.xml", SearchOption.AllDirectories).Length;
    }

    // This is the onClick event for pulling a character
    public void DrawCharCard()
    {
        string chosenChar = "";
        namesOfChars = new string[countOfChars + 1];

        // Start of getting char names from file paths

        for (int i = 0; i < countOfChars; i++)
        {
            namesOfChars[i] = new FileInfo(files[i]).Name;
        }

        // End of getting char names from file paths

        // Start RNG Logic

        int random = Random.Range(0, countOfChars);
        chosenChar = namesOfChars[random];

        // End RNG Logic

        Debug.Log("Characters found: " + countOfChars);
        Debug.Log(random);
        Debug.Log(chosenChar);
    }
}