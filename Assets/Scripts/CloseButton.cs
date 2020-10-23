using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnMouseUp()
    {
        Debug.Log("App Quit");
        Application.Quit();
    }
}
