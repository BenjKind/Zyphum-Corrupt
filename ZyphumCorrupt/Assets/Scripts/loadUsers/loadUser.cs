using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadUser : MonoBehaviour
{
    private string testtest = "";
    private continueGame continueGame/* = new continueGame()*/;

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

    public bool checkIfUserValid()
    {
        // Returns true or false upon checking user data
        // Reads XML
        // Return True = there is a unique name in NAME of the user xml
        // Return False = there is "new" for NAME in the user xml
        Serializer sz = new Serializer("Users/user0.xml");
        User user = new User();
        sz.DeserializeUser(out user);

        if (user.Name == "new")
            return false;
        else
            return true;
    }

    // Variables used for the text field START
    private InputField inputUsername;

    private string usernameTitle;

    private string userInputedName = "new";

    // Variables used for the text field END
    public void GetUsernameInput()
    {
        // Upon running, Awake() START
        inputUsername = transform.Find("UserInputField").GetComponent<InputField>();
        //usernameTitle = transform.Find("titleBackgroundText").GetComponent<UnityEngine.UI.Text>().text;
        // Upon running, Awake() END

        userInputedName = inputUsername.text;
        if (userInputedName != "new" && (userInputedName != null && userInputedName.Length < 16))
        {
            Debug.Log("Username: " + userInputedName);
            userInputedName = inputUsername.text;
            // is there a way to do this?
            // continueGame.gameContinue();
            // Unity just spits out this error:
            // NullReferenceException: Object reference not set to an instance of an object loadUser.GetUsernameInput()
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else
        {
            usernameTitle = "Enter valid username (16 char)";
            transform.Find("titleBackground").Find("titleBackgroundText").GetComponent<UnityEngine.UI.Text>().text = usernameTitle;

            Debug.Log("An invalid username was entered. Can not be 'new', whitespace, or null.");
            Debug.Log("Invalid Username: " + userInputedName);
        }
    }

    public void ThisBSIsStupid()
    {
        bool userValidation = checkIfUserValid();
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