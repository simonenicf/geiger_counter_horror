using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class How_to : MonoBehaviour
{
    public Button go_menu;
    
    // Start is called before the first frame update
    void Start()
    {
        go_menu.onClick.AddListener(Go_to_main);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Go_to_main()
    {
        SceneManager.LoadScene (sceneBuildIndex:0);
    }
}
