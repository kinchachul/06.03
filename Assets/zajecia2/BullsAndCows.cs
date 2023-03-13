using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI secretWordText;
    public TextMeshProUGUI secretWordLemghtText;
    public TextMeshProUGUI msgText;
    public TMP_InputField inputField;

    int lives = 3;
    string secretWord = "hello";
    // Start is called before the first frame update
    void Start()
    {
        secretWordText.text = "Secret word id " + secretWord + ".";
        secretWordLemghtText.text = "Secret word length " + secretWord.Length + ".";
        msgText.text = "Player has " + lives + "lives.";

        Debug.Log("Player has " + lives + "lives.");
        Debug.Log("Secret word id " + secretWord + ".");
        Debug.Log("Secret word length " + secretWord.Length + ".");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        if(lives > 0)
        { 
        if(secretWord.Length == inputField.text.Length) 
        {
                int bullsCount = 0;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == inputField.text[i])
                    {
                        bullsCount++;
                    }
                }

                int cowsCount = 0;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] != inputField.text[i] && inputField.text.Contains(secretWord[i]))
                    {
                        cowsCount++;
                    }
                }

                lives--;
                secretWordText.text = "Bulls: " + bullsCount + " cows: " + cowsCount;
                msgText.text = "Player has " + lives + " lives.";


        }
        else
        {
            lives--;
            secretWordText.text = "Wrong length";
                msgText.text = "Player has" + lives + "lives.";
        }
        inputField.text = "";   
    }
        else
        {
            secretWordText.text = "You lost";
            

        }
    }

}
