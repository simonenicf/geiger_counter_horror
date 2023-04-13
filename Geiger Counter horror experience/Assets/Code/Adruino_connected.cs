using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Adruino_connected : MonoBehaviour
{
    public SerialController serialController;
    public TMP_Text arduinoTXT;
    private bool goes_off = false;
    private bool hi;
    public Main_Part mainPart;
    private string myMessage;
    private bool chaos = false;
    private IEnumerator our_coruitine;

    public bool Goes_off
    {
        get { return goes_off; }
    }

    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Press A or Z to execute some actions");
    }

    // Executed each frame
    void Update()
    {
        if (!chaos)
        {
            myMessage = mainPart.A;
        }
        //---------------------------------------------------------------------
        // Send data
        //---------------------------------------------------------------------

        // If you press one of these keys send it to the serial device. A
        // sample serial device that accepts this input is given in the README.
        if (myMessage == "A")
        {
            chaos = !chaos;
            myMessage = "B";
            our_coruitine = Change(0.5f);
            StartCoroutine(Change(0.5f));
            Debug.Log("Sending A");
            serialController.SendSerialMessage("A");
        }

        //---------------------------------------------------------------------
        // Receive data
        //---------------------------------------------------------------------

        string message = serialController.ReadSerialMessage();

        if (message == null)
            return;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
        {
            Debug.Log("Connection established");
            arduinoTXT.text = "Arduino: Connected";
        }
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
        {
            Debug.Log("Connection attempt failed or disconnection detected");
            arduinoTXT.text = "Arduino: Not connected";
        }
        else
            Debug.Log("Message arrived: " + message);

        if (message == "Go")
        {
            goes_off = true;
        }
        else
        {
            goes_off = false;
        }

        
    }

    private IEnumerator Change(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 0.5f );
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 1f);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 1.5f);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 2f);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 2.5f);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 3f);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 3.5f);
            serialController.SendSerialMessage("A");
            yield return new WaitForSeconds(waitTime + 3.5f);
            serialController.SendSerialMessage("A");
            yield break;
        }
    }
}

