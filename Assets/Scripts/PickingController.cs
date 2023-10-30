using System;
using TMPro;
using UnityEngine;

public class PickingController : MonoBehaviour
{
    private StateMachine _stateMachine;
    public float gameTime = 10;
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public TMP_Text timer;
    
    private Vector3 _initialPin1Position;
    private Vector3 _initialPin2Position;
    private Vector3 _initialPin3Position;
    private float _nextRenderTime;

    void Start()
    {
        _initialPin1Position = pin1.transform.position;
        _initialPin2Position = pin2.transform.position;
        _initialPin3Position = pin3.transform.position;
        _stateMachine = FindObjectOfType<StateMachine>();
    }

    private void Update()
    {
        if (_nextRenderTime < Time.time)
        {
            _nextRenderTime = Time.time + 1;
            timer.text = $"Remain \n{Math.Round(gameTime - Time.time)} Sec";
            if (Time.time > gameTime)
            {
                _stateMachine.ChangeScreen(_stateMachine.loseScreen);
            }
        }
    }

    public void Hummer()
    {
        pin1.transform.Translate(new Vector3(0, -0.1f, 0));
        pin2.transform.Translate(new Vector3(0, 0.1f, 0));
        pin3.transform.Translate(new Vector3(0, 0.1f, 0));
        CheckGameStatus();
    }

    public void PickLock()
    {
        pin1.transform.Translate(new Vector3(0, 0.1f, 0));
        pin2.transform.Translate(new Vector3(0, -0.1f, 0));
        pin3.transform.Translate(new Vector3(0, 0.1f, 0));
        CheckGameStatus();
    }

    public void Tentacle()
    {
        pin1.transform.Translate(new Vector3(0, 0.1f, 0));
        pin2.transform.Translate(new Vector3(0, 0.1f, 0));
        pin3.transform.Translate(new Vector3(0, -0.1f, 0));
        CheckGameStatus();
    }

    public void Restart()
    {
        pin1.transform.position = _initialPin1Position;
        pin2.transform.position = _initialPin2Position;
        pin3.transform.position = _initialPin3Position;
        _stateMachine.ChangeScreen(_stateMachine.gameScreen);
        gameTime += Time.time;
    }

    private void CheckGameStatus()
    {
        float yThresholdMin = 0.99f; 
        float yThresholdMax = 1.01f; 
        if (pin1.transform.position.y > yThresholdMin && pin1.transform.position.y < yThresholdMax && 
            pin2.transform.position.y > yThresholdMin && pin2.transform.position.y < yThresholdMax &&
            pin3.transform.position.y > yThresholdMin && pin3.transform.position.y < yThresholdMax)
        {
            _stateMachine.ChangeScreen(_stateMachine.winScreen);
        }
    }
}