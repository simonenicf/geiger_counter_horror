using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Code : MonoBehaviour
{
    public Button start_game, how_To_Play, exit_Game;
    
    // Start is called before the first frame update
    void Start()
    {
        start_game.onClick.AddListener(Load_Game);
        how_To_Play.onClick.AddListener(Explain_Game);
        exit_Game.onClick.AddListener(Quit_Game);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Load_Game()
    {
        SceneManager.LoadScene (sceneBuildIndex:4);
    }

    void Explain_Game()
    {
        SceneManager.LoadScene (sceneBuildIndex:2);
    }

    void Quit_Game()
    {
        Application.Quit();
    }
}
