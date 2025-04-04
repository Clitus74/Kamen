using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfMove : INumberOfMoves
{
    private int moves;
    private int currentMoves;
    public NumberOfMove(int move)
    {
        this.moves = move;
        this.currentMoves = move;
    }
    public float GetCurrentMove()
    {
        return currentMoves;
    }

    public float GetMove()
    {
        return moves;
    }

    public void IncreaseMove(int amount)
    {
        this.currentMoves += amount;
        //if (currentMoves > moves)
        //    currentMoves = moves;
    }

    public void ReduceeMove(int amount)
    {
        this.currentMoves -= amount;
        if (currentMoves < 0)
            currentMoves = 0;
    }

    public void SetMove(int value)
    {
        this.currentMoves = value;
    }
}
