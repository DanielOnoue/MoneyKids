using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    public Money moneyObj;

    // Start is called before the first frame update
    void Awake()
    {
        moneyObj = new Money();
        moneyObj.SetValue(150);
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
