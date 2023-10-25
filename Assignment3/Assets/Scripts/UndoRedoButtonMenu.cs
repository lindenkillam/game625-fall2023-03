using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UndoRedoButtonMenu : MonoBehaviour
{
    GameManager gm;

    public void SaveButton()
    {
        Command.saveStates.Add(new SaveState(gm.player.transform.position.x, gm.player.transform.position.y));
        Command.currentIndex = Command.saveStates.Count - 1;
    }
}
