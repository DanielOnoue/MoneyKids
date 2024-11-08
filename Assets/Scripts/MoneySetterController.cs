using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneySetterController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    MoneyController moneyController;

    // Start is called before the first frame update
    void Start()
    {
        moneyController = GameObject.FindGameObjectWithTag("Money").GetComponent<MoneyController>();
        moneyText.text = moneyController.moneyObj.Value.ToString();
    }
}
