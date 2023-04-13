using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Part : MonoBehaviour
{
    public TMP_Text game_txt;
    public TMP_Text next_txt;
    public TMP_Text well_done;
    private IEnumerator this_Coroutine;
    private IEnumerator My_Coroutine;
    
    public GameObject button;
    public Button myButton;

    public Adruino_connected adruinoConnect;
    private bool magnet_is_close;
    private bool start = true;
    private bool notClearScreen = true;

    private string a;

    public string A
    {
        get { return a; }
    }

    // Start is called before the first frame update
    void Start()
    {
        myButton.onClick.AddListener(Clear_screen);
    }

    // Update is called once per frame
    void Update()
    {
        magnet_is_close = adruinoConnect.Goes_off;
        if (start == true)
        {
            Start_Sim();
            start = !start;
        }

        if (magnet_is_close == true && notClearScreen)
        {
            well_done.text = "Well done<br>Now you understand how this works.<br>Lets try this again";
            button.SetActive(true);
        }

        if (!notClearScreen)
        {
            game_txt.text =
                "Now we will do this again. <br>Its the same as before nothing can go wrong";
            this_Coroutine = Pause(5);
            StartCoroutine(this_Coroutine);
            My_Coroutine = Fix(10);
            StartCoroutine(My_Coroutine);
        }
    }

    void Start_Sim()
    {
        game_txt.text =
            "Now lets start. <br>You have a object(magnet) in front of you. <br>You want to know if this is radioactive.";
        this_Coroutine = Next_text(1, "Now use the device given to check the object(magnet)<br>Go!");
        StartCoroutine(this_Coroutine);
    }
    
    private IEnumerator Next_text(float waitTime, string myString)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            next_txt.text = myString;
            
        }
    }

    private IEnumerator Pause(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            a = "A";
            next_txt.text =
                "What happened.....<br>This shouldn't happen....<br>I will fix this";
            yield break;
        }
    }
    
    private IEnumerator Fix(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            well_done.text =
                "Welp, that could have gone better.<br>I will end the simulation for now<br>We will hopefully have fixed this issue in the next version...<br>Press the button to go back to the main menu";
            button.SetActive(true);
            yield break;
        }
    }

    private IEnumerator ThisWillHelp(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
        yield break;
    }

    
    private void Clear_screen()
    {
        if(notClearScreen)
        {
            game_txt.text = "";
            StopCoroutine(this_Coroutine);
            next_txt.text = "";
            well_done.text = "";
            notClearScreen = !notClearScreen;
            button.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
    
}
