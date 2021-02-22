using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadUser : MonoBehaviour
{
    private string testtest = "";
    private continueGame continueGame/* = new continueGame()*/;
    private User global = new User();
    private ZyphumScript globalBoi;

    // Start is called before the first frame update
    private void Awake()
    {
        string[] userNamesToDisplay = new string[3];

        for (int i = 0; i < 3; i++)
        {
            string userNameRead = "";
            userNamesToDisplay[i] = userNameRead;
        }
    }

    public bool checkIfUserValid(string fileName)
    {
        // Returns true or false upon checking user data
        // Reads XML
        // Return True = there is a unique name in NAME of the user xml
        // Return False = there is "new" for NAME in the user xml
        Serializer sz = new Serializer("Users/" + fileName + ".xml");
        sz.DeserializeUser(out global);

        if (global.Name == "new")
            return false;
        else
            return true;
    }

    // Variables used for the text field START
    private InputField inputUsername;

    private string usernameTitle;

    // this will be used to update the global username
    private string userInputedName = "new";

    // Variables used for the text field END
    public void GetUsernameInput()
    {
        inputUsername = transform.Find("UserInputField").GetComponent<InputField>();

        if (inputUsername.text != "new" && (inputUsername.text != null && inputUsername.text.Length < 16))
        {
            userInputedName = inputUsername.text;
            Debug.Log("VALID USERNAME ENTERED");
            Debug.Log("Username: " + userInputedName);
            //userInputedName = inputUsername.text;
            // is there a way to do this?
            // continueGame.gameContinue();
            // Unity just spits out this error:
            // NullReferenceException: Object reference not set to an instance of an object loadUser.GetUsernameInput()

            global.Name = userInputedName;
            ISaveNewUserNames(0);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else
        {
            usernameTitle = "Enter valid username (16 char)";
            transform.Find("titleBackground").Find("titleBackgroundText").GetComponent<UnityEngine.UI.Text>().text = usernameTitle;

            Debug.LogWarning("An invalid username was entered. Can not be 'new', whitespace, or null.");
            Debug.LogWarning("Invalid Username: " + userInputedName);
        }
    }

    public void OpenWindow(string fileName)
    {
        bool userCheck = checkIfUserValid(fileName);
        if (userCheck == false)
        {
            Debug.Log("YAY");
            global.Name = userInputedName;
            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser = global;
        }
        else
        {
            // Loads the user IF there is a player in that spot
            global.Name = userInputedName; // BUT I NEED TO READ THE FILE, GET THE NAME
            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser = global;
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }

    public void UpdateSaveSlotName(int whichButton)
    {
        // I need to update the user on the load of the game. Maybe on Awake() ??

        // Use IN to update the text on the button effected
        // IN: userInputedName
        // NEED: Button variable for text
        // NEED: Button variable for text
        // OUT: write username to button
    }

    public void ISaveNewUserNames(int whichFile)
    {
        User toSaveMe = new User();
        toSaveMe.Name = userInputedName;

        string fileName = whichFile.ToString();

        Serializer sz = new Serializer("Users/" + fileName + ".xml");
        Debug.LogWarning("LOCAL:  " + toSaveMe.Name.ToString());
        Debug.LogWarning("GLOBAL: " + userInputedName);
        Debug.Log(fileName);
        sz.SerializeUser(toSaveMe);
    }

    public void ThisBSIsStupid(string fileName)
    {
        bool userValidation = checkIfUserValid(fileName);
        if (userValidation == true)
            Debug.Log("USER VALID");
        else
        {
            Debug.Log("USER NEEDS TO BE CREATED");
            GetUsernameInput();
            Debug.Log(testtest);
        }
    }
}