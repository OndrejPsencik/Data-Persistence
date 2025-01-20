using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public static GameState Instance { get; private set; }
    public string PlayerName { get; set; }

    public string BestPlayerName { get; set; }
    public int BestScore { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("BestPlayerName", BestPlayerName);
        PlayerPrefs.SetInt("BestScore", BestScore);
    }

    public void LoadData()
    {
        BestPlayerName = PlayerPrefs.GetString("BestPlayerName", null);
        BestScore = PlayerPrefs.GetInt("BestScore", 0);
    }
}
