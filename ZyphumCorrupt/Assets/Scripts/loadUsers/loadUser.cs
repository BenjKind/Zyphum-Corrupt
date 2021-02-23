using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class loadUser : MonoBehaviour
{
    private int globalFileName;
    private User global;

    // Start is called before the first frame update
    private void Awake()
    {
        initialGlobalUserName();
        Debug.LogWarning("GLOBAL: " + userInputedName);
        string[] userNamesToDisplay = new string[3];
        Serializer sz;
        User user;

        for (int i = 0; i < 3; i++)
        {
            sz = new Serializer("Users/" + i + ".xml");
            user = new User();
            sz.DeserializeUser(out user);
            userNamesToDisplay[i] = user.Name.ToString();
        }

        for (int j = 0; j <= 2; j++)
        {
            Debug.Log("TESTTEST - " + j);
            Debug.Log(userNamesToDisplay[j]);
            GameObject.Find("user" + j).GetComponentInChildren<Text>().text = userNamesToDisplay[j];
        }
    }

    public bool checkIfUserValid(int fileName)
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
        inputUsername = transform.Find("UsernameInputWindow").Find("UserInputField").GetComponent<InputField>();

        if (inputUsername.text != "new" && (inputUsername.text != null && inputUsername.text.Length < 16))
        {
            userInputedName = inputUsername.text;
            Debug.Log("VALID USERNAME ENTERED");
            Debug.Log("Username: " + userInputedName);

            global.Name = userInputedName;
            ISaveNewUserNames(globalFileName);
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

    public void initialGlobalUserName()
    {
        Serializer sz = new Serializer("Users/lastUser.xml");
        User user = new User();
        sz.DeserializeUser(out user);
        global = user;
        userInputedName = user.Name.ToString();
        setFileName(Int32.Parse(user.Name));
    }

    public void OpenWindow()
    {
        bool userCheck = checkIfUserValid(globalFileName);
        if (userCheck == false)
        {
            Serializer ser = new Serializer("Users/" + globalFileName.ToString() + ".xml");
            User temp = new User();
            ser.DeserializeUser(out temp);

            global.Name = temp.Name;

            User temper = new User();
            temper.Name = globalFileName.ToString();

            Serializer sz = new Serializer("Users/lastUser.xml");
            sz.SerializeUser(temper);
            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser = global;
            //SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else
        {
            // Loads the user IF there is a player in that spot
            global.Name = userInputedName;
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }

    public void ISaveNewUserNames(int whichFile)
    {
        User toSaveMe = new User();
        toSaveMe.Name = userInputedName;

        string fileName = whichFile.ToString();

        Serializer sz = new Serializer("Users/" + fileName + ".xml");
        Debug.LogWarning("LOCAL:  " + toSaveMe.Name.ToString());
        Debug.LogWarning("GLOBAL: " + userInputedName);
        sz.SerializeUser(toSaveMe);
    }

    public void setFileName(int temp)
    {
        globalFileName = temp;
    }
}