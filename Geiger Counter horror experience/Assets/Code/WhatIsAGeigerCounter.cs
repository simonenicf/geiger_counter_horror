using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WhatIsAGeigerCounter : MonoBehaviour
{
    public Button go_Next_scene;
    // Start is called before the first frame update
    void Start()
    {
        go_Next_scene.onClick.AddListener(NextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextScene()
    {
        SceneManager.LoadScene (sceneBuildIndex:1);
    }
}
