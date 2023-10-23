using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    private float playerX;
    private float playerY;

    public SaveState(float x, float y)
    {
        this.playerX = x;
        this.playerY = y;
    }
}