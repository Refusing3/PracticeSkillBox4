using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

public class ComparisonScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private TMP_InputField FirstTermIField;
    [SerializeField] private TMP_InputField SecondTermIField;

    private int result = 0;

    public void onClickCompare()
    {
        if (int.TryParse(FirstTermIField.text, out int FirstTerm) &&
             (int.TryParse(SecondTermIField.text, out int SecondTerm)))
        {
            if (FirstTerm > SecondTerm)
                resultText.text = $"{FirstTerm} Greater than {SecondTerm}";
            else if (FirstTerm < SecondTerm)
                resultText.text = $"{FirstTerm} Lesser than {SecondTerm}";
            else resultText.text = $"{FirstTerm} Equal to {SecondTerm}";
        }
        else
        {
            resultText.text = "Error";
        }
    }
}