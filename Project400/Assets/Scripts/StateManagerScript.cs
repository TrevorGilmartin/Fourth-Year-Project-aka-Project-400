using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnsState
{
    PlayerTurn_1,
    PlayerTurn_2,
    PlayerTurn_3,
    EnemyTurn_1,
    EnemyTurn_2,
    EnemyTurn_3,
}

public enum States
{

}

public class StateManagerScript : MonoBehaviour
{
    public static StateManagerScript instance;

    public TurnsState currentTurnState = TurnsState.PlayerTurn_1;
    // Use this for initialization
    void Start()
    {
        currentTurnState = TurnsState.PlayerTurn_1;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void ChangingTurnState()
    {
        currentTurnState = TurnsState.EnemyTurn_1;
    }
}
