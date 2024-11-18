using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private TMP_InputField FirstTermIField;
    [SerializeField] private TMP_InputField SecondTermIField;

    private int result = 0;

    public void onClickSumm()
    {
        if (int.TryParse(FirstTermIField.text, out int FirstTerm) &&
             (int.TryParse(SecondTermIField.text, out int SecondTerm)))
        {
            int result = FirstTerm + SecondTerm;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Error";
        }
    }
    public void onClickSubtract()
    {
        if (int.TryParse(FirstTermIField.text, out int FirstTerm) &&
            (int.TryParse(SecondTermIField.text, out int SecondTerm)))
        {
            int result = FirstTerm - SecondTerm;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Error";
        }

    }
    public void onClickDivide()
    {
        if (int.TryParse(FirstTermIField.text, out int FirstTerm) &&
            (int.TryParse(SecondTermIField.text, out int SecondTerm)))
        {
            int result = FirstTerm / SecondTerm;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Error";
        }
    }
    public void onClickMultiplicate()
    {
        if (int.TryParse(FirstTermIField.text, out int FirstTerm) &&
            (int.TryParse(SecondTermIField.text, out int SecondTerm)))
        {
            int result = FirstTerm * SecondTerm;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Error";
        }
    }
}