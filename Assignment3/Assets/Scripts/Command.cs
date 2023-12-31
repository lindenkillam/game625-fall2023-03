using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public static List<SaveState> saveStates = new List<SaveState>();
    public static int currentIndex;

    public abstract void Redo();
    public abstract void Undo();
}