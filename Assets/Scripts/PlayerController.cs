using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private string screenMessage;

    public TextMeshProUGUI textMeshPro;


    // Start is called before the first frame update
    void Start()
    {
        screenMessage = "Pulsa cualquiera de las cuatro flechas";
        textMeshPro.text = screenMessage;
    }

    // Update is called once per frame
    void Update()
    {
        ShowMessage(screenMessage, KeyCode.RightArrow);
        ShowMessage(screenMessage, KeyCode.LeftArrow);
        ShowMessage(screenMessage, KeyCode.UpArrow);
        ShowMessage(screenMessage, KeyCode.DownArrow);
        ShowMessage(screenMessage, KeyCode.Space);

    }

    public void ShowMessage(string message, KeyCode key)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            message = "Arriba";
            textMeshPro.text = message;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            message = "Derecha";
            textMeshPro.text = message;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            message = "Izquierda";
            textMeshPro.text = message;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {


            message = "Abajo";
            textMeshPro.text = message;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            message = "¡Pium!";
            textMeshPro.text = message;

        }

    }
}
