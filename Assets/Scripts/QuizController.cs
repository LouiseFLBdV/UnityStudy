using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class QuizController : MonoBehaviour
{
    private int points;
    public List<GameObject> questions;
    public TMP_Text textResult;
    private StateMachine _stateMachine;

    private void Awake()
    {
        _stateMachine = FindObjectOfType<StateMachine>();
    }

    public void OnAnswer(bool answer)
    {
        if (answer)
        {
            points += + 2;
        }
        RenderScene();
    }

    private void RenderScene()
    {
        questions.Remove(_stateMachine.currentScreen);
        if (questions.Count != 0)
        {
            _stateMachine.ChangeState(questions[Random.Range(0, questions.Count)]);
        }
        else
        {
            RenderPoints();
            _stateMachine.ChangeState(_stateMachine.finish);
        }
    }
    private void RenderPoints()
    {
        textResult.text = $"You have {points} / 10 Points";
    }
}