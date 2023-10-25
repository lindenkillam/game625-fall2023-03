using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoRedo : Command
{
    GameManager gm;

    public override void Redo()
    {
        if(currentIndex < saveStates.Count - 1)
        {
            ++currentIndex;
            Vector3 savePosition = new Vector3(saveStates[currentIndex].getPlayerX(),
                saveStates[currentIndex].getPlayerY(), 0);
            gm.player.transform.position = savePosition;
        }
    }
    public override void Undo()
    {
        if (currentIndex > 0)
        {
            --currentIndex;
            Vector3 savePosition = new Vector3(saveStates[currentIndex].getPlayerX(),
                saveStates[currentIndex].getPlayerY(), 0);
            gm.player.transform.position = savePosition;
        }
    }
}
