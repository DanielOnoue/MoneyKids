using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonController : MonoBehaviour
{
    MoneyController moneyController;
    // Start is called before the first frame update
    public void StartGame()
    {
        if (moneyController != null)
        {
            Destroy(moneyController.gameObject);
        }
        SceneManager.LoadScene(15);
    }

    private void Start()
    {
        moneyController = GameObject.FindGameObjectWithTag("Money")?.GetComponent<MoneyController>();
    }
}
