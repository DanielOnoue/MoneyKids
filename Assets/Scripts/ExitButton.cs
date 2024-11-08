using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitApplication()
    {
        Debug.Log("Entrou no QuitApplication()");
        Application.Quit();
    }
}