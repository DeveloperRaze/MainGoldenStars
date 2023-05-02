using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConfirmationScript : MonoBehaviour
{
    //Script attached to menu button will enable and disable canvas according to button press.

    [SerializeField] GameObject ConfirmYes;
    [SerializeField] GameObject ConfirmNo;

    [SerializeField] private Canvas ConfirmButtons;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmButtons.enabled = false;
    }

    public void ShowButtons()
    {
        ConfirmButtons.enabled = true;
    }

    public void RejectExit()
    {
        ConfirmButtons.enabled = false;
    }
}
