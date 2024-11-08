using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExpenseController : MonoBehaviour
{
    [SerializeField]Button nextButton;
    MoneyController moneyController;
    [SerializeField]TextMeshProUGUI moneyText;
    [SerializeField] Button expenseButton;
    // Start is called before the first frame update
    void Start()
    {
        moneyController = GameObject.FindGameObjectWithTag("Money").GetComponent<MoneyController>();
    }
    
    public void Expense1()
    {
        float newValue = moneyController.moneyObj.Value - 10;
        if (newValue < 0)
        {
            GameOver();
        }
        float value = (float)Math.Round(newValue, 0, MidpointRounding.AwayFromZero);
        moneyController.moneyObj.SetValue(value);
        moneyText.text = value.ToString();
        nextButton.interactable = true;
        expenseButton.interactable = false;
    }

    public void Expense2()
    {
        float newValue = moneyController.moneyObj.Value - 20;
        if (newValue < 0)
        {
            GameOver();
        }
        float value = (float)Math.Round(newValue, 0, MidpointRounding.AwayFromZero);
        moneyController.moneyObj.SetValue(value);
        moneyText.text = value.ToString();
        nextButton.interactable = true;
        expenseButton.interactable = false;
    }

    public void Expense3()
    {
        float newValue = moneyController.moneyObj.Value - 40;
        if (newValue < 0)
        {
            GameOver();
        }
        float value = (float)Math.Round(newValue, 0, MidpointRounding.AwayFromZero);
        moneyController.moneyObj.SetValue(value);
        moneyText.text = value.ToString();
        nextButton.interactable = true;
        expenseButton.interactable = false;
    }

    public void Expense4()
    {
        float newValue = moneyController.moneyObj.Value - 70;
        if (newValue < 0)
        {
            GameOver();
        }
        float value = (float)Math.Round(newValue, 0, MidpointRounding.AwayFromZero);
        moneyController.moneyObj.SetValue(value);
        moneyText.text = value.ToString();
        nextButton.interactable = true;
        expenseButton.interactable = false;
    }

    public void Expense5()
    {
        float newValue = moneyController.moneyObj.Value - 100;
        if (newValue < 0)
        {
            GameOver();
        }
        float value = (float)Math.Round(newValue, 0, MidpointRounding.AwayFromZero);
        moneyController.moneyObj.SetValue(value);
        moneyText.text = value.ToString();
        nextButton.interactable = true;
        expenseButton.interactable = false;
    }

    private void GameOver()
    {
        //Criar lógica para ir ao GameOverScene
        SceneManager.LoadScene(9);
    }
}
