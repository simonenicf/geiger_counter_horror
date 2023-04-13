using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main_Part : MonoBehaviour
{
    public TMP_Text game_txt;
    public TMP_Text next_txt;
    public TMP_Text well_done;
    private IEnumerator this_Coroutine;

    public GameObject button;
    public Button myButton;

    public Adruino_connected adruinoConnect;
    private bool magnet_is_close;
    private bool start = true;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if (magnet_is_close == true)
        {
            well_done.text = "Well done<br>Now you understand how this works.<br>Lets try this again";
            button.SetActive(true);
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
}
