using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BankController : MonoBehaviour
{
    [SerializeField] GameObject bank1Window;
    [SerializeField] GameObject bank2Window;
    [SerializeField] TMP_InputField bank1Input;
    [SerializeField] TMP_InputField bank2Input;
    MoneyController moneyController;
    [SerializeField] TextMeshProUGUI bank1AppliedText;
    [SerializeField] TextMeshProUGUI bank2AppliedText;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] int actualWeek;
    [SerializeField] Button btnApplyBank1;
    [SerializeField] Button btnApplyBank2;
    [SerializeField] Button btnClaimBank1;

    // Start is called before the first frame update
    void Start()
    {
        moneyController = GameObject.FindGameObjectWithTag("Money").GetComponent<MoneyController>();
        bank1AppliedText.text = CalculateValues().ToString();
        //bank2AppliedText.text = moneyController.moneyObj.Bank2AppliedValue.ToString();
    }

    public float CalculateValues()
    {
        float bank1AppliedMoney = moneyController.moneyObj.Bank1AppliedValue;
        float valueWithPercentage = 0;

        if (moneyController.moneyObj.Bank1WeekOfAppliance == actualWeek)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue;
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 2)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 3)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.4f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 4)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.6f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.8f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 2 && actualWeek == 3)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 2 && actualWeek == 4)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.4f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 2 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.6f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 3 && actualWeek == 4)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 3 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.4f + moneyController.moneyObj.Bank1AppliedValue;

        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 4 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;

        }
        var test = (float)Math.Round(valueWithPercentage, 0, MidpointRounding.AwayFromZero);
        return test;
    }
    public void ClaimBank1Money()
    {       
        float bank1AppliedMoney = moneyController.moneyObj.Bank1AppliedValue;
        float valueWithPercentage = 0;

        if (moneyController.moneyObj.Bank1WeekOfAppliance == actualWeek)
        {
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + bank1AppliedMoney);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 2)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 3)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.4f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 4)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.6f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 1 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.8f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 2 && actualWeek == 3)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 2 && actualWeek == 4)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.4f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 2 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.6f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 3 && actualWeek == 4)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 3 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.4f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        else if (moneyController.moneyObj.Bank1WeekOfAppliance == 4 && actualWeek == 5)
        {
            valueWithPercentage = moneyController.moneyObj.Bank1AppliedValue * 0.2f + moneyController.moneyObj.Bank1AppliedValue;
            moneyController.moneyObj.SetValue(moneyController.moneyObj.Value + valueWithPercentage);
        }
        float newValue = moneyController.moneyObj.Value;
        double value = Math.Round(newValue, 0, MidpointRounding.AwayFromZero);
        moneyText.text = value.ToString();
        bank1AppliedText.text = "0";
        btnApplyBank1.interactable = true;
        btnClaimBank1.interactable = false;
    }

    public void OpenBank1Window()
    {
        bank1Window.SetActive(true);
    }

    public void OpenBank2Window()
    {
        bank2Window.SetActive(true);
    }

    public void CloseBank1Window()
    {
        bank1Window.SetActive(false);
    }

    public void CloseBank2Window()
    {
        bank2Window.SetActive(false);
    }

    public void ApplyMoneyBank1()
    {
        var inputValue = Convert.ToInt32(bank1Input.text);
        if (inputValue <= moneyController.moneyObj.Value)
        {
            int moneyAlreadyApplied = Convert.ToInt32(bank1AppliedText.text);
            string textTemp = bank1Input.text;
            int moneyToApply = Convert.ToInt32(textTemp);
            float bank1Applied = (float)Math.Round((double)(moneyToApply + moneyAlreadyApplied), 0, MidpointRounding.AwayFromZero);
            moneyController.moneyObj.SetBank1AppliedValue(moneyToApply + moneyAlreadyApplied);
            bank1AppliedText.text = bank1Applied.ToString();
            var actualMoney = moneyController.moneyObj.Value;
            float value = (float)Math.Round((actualMoney - moneyToApply), 0, MidpointRounding.AwayFromZero);
            moneyText.text = value.ToString();
            moneyController.moneyObj.SetValue(value);
            moneyController.moneyObj.SetBank1WeekOfAppliance(actualWeek);
            btnApplyBank1.interactable = false;
            btnClaimBank1.interactable = true;
            bank1Window.SetActive(false);
        }
        else
        {
            bank1Input.text = string.Empty;
        }
    }

    public void ApplyMoneyBank2()
    {
        int moneyAlreadyApplied = Convert.ToInt32(bank2AppliedText.text);
        string textTemp = bank2Input.text;
        int moneyToApply = Convert.ToInt32(textTemp);
        moneyController.moneyObj.SetBank2AppliedValue(moneyToApply + moneyAlreadyApplied);
        bank2AppliedText.text = (moneyAlreadyApplied + moneyToApply).ToString();
        var actualMoney = moneyController.moneyObj.Value;
        moneyText.text = (actualMoney - moneyToApply).ToString();
        moneyController.moneyObj.SetValue(actualMoney - moneyToApply);
        moneyController.moneyObj.SetBank2WeekOfAppliance(actualWeek);
        btnApplyBank2.interactable = false;
        bank2Window.SetActive(false);
    }

    public void inputValueChanged()
    {
        if (bank1Input.text.Length > 0 && bank1Input.text[0] == '-')
        {
            bank1Input.text = bank1Input.text.Remove(0);
        }
    }
}
