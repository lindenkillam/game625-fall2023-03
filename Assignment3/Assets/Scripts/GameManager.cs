using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Command.saveStates.Add(new SaveState(0, 0));
        Command.currentIndex = 0;
    }
}
