using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartScreenController : MonoBehaviour
{
    public void StartGame()
    {
        // get value of input field
        string inputFieldValue = GameObject.Find("InputField").GetComponent<TMP_InputField>().text;
        GameState.Instance.PlayerName = inputFieldValue;

        GameState.Instance.GoToMainScene();
    }
}
