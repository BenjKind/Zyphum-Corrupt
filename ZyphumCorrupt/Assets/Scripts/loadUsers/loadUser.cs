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
            userInputedName = inputUsername.text;
            // is there a way to do this?
            // continueGame.gameContinue();
            // Unity just spits out this error:
            // NullReferenceException: Object reference not set to an instance of an object loadUser.GetUsernameInput()

            // ENABLE ME WHEN NO LONGER DEBUGGING
            global.Name = userInputedName;
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
        }
    }

    public void ISaveNewUserNames(int whichFile)
    {
        User user = new User();
        user.Name = userInputedName;

        string fileName = "user" + whichFile.ToString();

        Serializer sz = new Serializer("Users/" + fileName + ".xml");
        sz.SerializeUser(user);
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