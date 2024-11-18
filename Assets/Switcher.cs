using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum CanvasState
    {
        Calculator,
        Comparison
    }
    [SerializeField] private Canvas calculatorCanvas;
    [SerializeField] private Canvas comparisonCanvas;

    private CanvasState currentState;

    private void Start()
    {
        SetState(CanvasState.Calculator);
    }
    public void SetState(CanvasState newState)
    {
        currentState = newState;
        calculatorCanvas.enabled = (currentState == CanvasState.Calculator);
        comparisonCanvas.enabled = (currentState == CanvasState.Comparison);
    }
    public void SwitchToCalculator()
    {
        SetState(CanvasState.Calculator);
    }
    public void SwitchToComparison()
    {
        SetState(CanvasState.Comparison);
    }
}
