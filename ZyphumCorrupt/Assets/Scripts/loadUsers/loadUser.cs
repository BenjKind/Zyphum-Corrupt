using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadUser : MonoBehaviour
{
    private string testtest = "";
    private continueGame continueGame = new continueGame();

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

    private UnityEngine.UI.Text displayEnterValidUser;

    private string userInputedName = "new";
    /*private Button submitUsername;
    private Button cancelUsername;*/

    // Variables used for the text field END
    public void GetUsernameInput()
    {
        // Upon running, Awake() START
        /*submitUsername = transform.Find("SubmitUsername").GetComponent<Button>();
        cancelUsername = transform.Find("CancelUsername").GetComponent<Button>();*/
        inputUsername = transform.Find("UserInputField").GetComponent<InputField>();
        displayEnterValidUser = transform.Find("enterValidUsername").GetComponent<UnityEngine.UI.Text>();
        // Upon running, Awake() END

        userInputedName = inputUsername.text;
        if (userInputedName != "new" || userInputedName == null || userInputedName.Length > 16)
        {
            userInputedName = inputUsername.text;
            continueGame.gameContinue();
        }
        else
            displayEnterValidUser.SetActive(true);
        displayEnterValidUser();

        Debug.Log("Username: " + userInputedName);
    }

    public void displayEnterValidUser()
    {
        gameObject.SetActive(true);
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