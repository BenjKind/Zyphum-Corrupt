using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class drawRand : MonoBehaviour
{
    private int countOfFiles = 0;
    private string[] namesOfFiles;
    private string[] files;

    // Start is called before the first frame update
    private void Start()
    {
        // GET FILE NAME FROM BUTTON TEXT
        string fileInput = gameObject.GetComponentInChildren<Text>().text;
        Debug.Log(fileInput);
        fileInput += '/';
        files = Directory.GetFiles(fileInput, "*.xml");
        CountFilesInputed(fileInput);
    }

    // Logic of getting the count of files
    public void CountFilesInputed(string input)
    {
        countOfFiles = Directory.GetFiles(input, "*.xml", SearchOption.AllDirectories).Length;
    }

    // This is the onClick event for pulling a character
    public void DrawCharCard()
    {
        string chosenCard = "";
        namesOfFiles = new string[countOfFiles + 1];

        // Start of getting file names from file paths

        for (int i = 0; i < countOfFiles; i++)
        {
            namesOfFiles[i] = new FileInfo(files[i]).Name;
        }

        // End of getting file names from file paths

        // Start RNG Logic

        int random = Random.Range(0, countOfFiles);
        chosenCard = namesOfFiles[random];

        // End RNG Logic

        Debug.Log("Files found: " + countOfFiles);
        Debug.Log(random);
        Debug.Log(chosenCard);
    }
}