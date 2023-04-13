using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Simultation_code : MonoBehaviour
{
    // text used in the game
    public TMP_Text sim_Text;
    public TMP_Text Coroutine_text;
    public TMP_Text plz_connect;
    
    private bool sim_Start = true;
    private IEnumerator my_Coroutine; // create a coroutine to have a delay
    
    public Button next_Part;
    // get access to an other script
    public SampleUserPolling_ReadWrite readAndWrite;
    // a bool that checks if the arduino is connected or not
    private bool connected;
    private int annoyed;
    
    // Start is called before the first frame update
    void Start()
    {
        next_Part.onClick.AddListener(NextPart);
    }

    // Update is called once per frame
    void Update()
    {
        connected = readAndWrite.Connected;
        if (sim_Start == true)
        {
            sim_Text.text = "Welcome To the simulation";
            sim_Text.fontSize = 70;
            my_Coroutine = Script_Write(1f);
            StartCoroutine(my_Coroutine);
            sim_Start = !sim_Start;
        }
        
    }

    void NextPart()
    {
        if (!connected)
        {
            if (annoyed >= 20)
            {
                plz_connect.text = "PleAsE MAkE sURe THe ArDUiNo 1s C0nNecTed!!!! <br><br> CONNECT IT OR I WILL END THIS SIMULATION!!!! <br> BYE!!!";
                my_Coroutine = End_game(5);
                StartCoroutine(my_Coroutine);
            }
            else if (annoyed >= 10)
            {
                plz_connect.text = "PleAsE MAkE sURe THe ArDUiNo 1s C0nNecTed!!!! <br><br> CONNECT IT OR I WILL END THIS SIMULATION!!!!";
                annoyed += 1;
            } else if (annoyed >= 5)
            {
                plz_connect.text = "PleAsE MAkE sURe THe ArDUiNo 1s C0nNecTed!!!!";
                annoyed += 1;
            }
            else
            {
                plz_connect.text = "Please make sure the Arduino is connected";
                annoyed += 1;
            }
        }
        else
        {
            SceneManager.LoadScene (sceneBuildIndex:3);
        }
    }
    
    private IEnumerator Script_Write(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Coroutine_text.text = "In this simulation you will work with a proto-type test unit. <br>This unit is created to teach people how to work with it in a save environment.";
            Coroutine_text.fontSize = 50;
        }
    }

    private IEnumerator End_game(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Application.Quit();
        }
    }


}
