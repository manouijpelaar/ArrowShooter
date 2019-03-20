using System.Collections;
using UnityEngine;

public class TargetVolgorde : MonoBehaviour
{
    public float speed;
    public Transform endPosition;
    public Animator gate;

    public TargetCollide[] targetArray;
    private int nextTarget = 0;

    public bool doorIsOpen = false;
    
    public void Start()
    {
        
    }

    // checking de volgorde van de targets
    public bool CheckTarget(TargetCollide target)
    {
        if (doorIsOpen) { return false; }

        Debug.Log("Checking Target");
        if (targetArray[nextTarget] == target)
        {
            Debug.Log("Target Correct");
            nextTarget++;

            return true;
        }

        else
        {
            //verkeerde volgorde word de list gereset
            Debug.Log("Target InCorrect Resetting");
            Reset();
            return false;
        }
    } 

    // checked het lijstje voor volgorde
    public bool CheckWin()
    {
        foreach (TargetCollide t in targetArray)
        {
            if (t.Hit == false)
            {
                return false;
            }
        }
    return true;
    }

    // checked het lijstje voor de volgorde
    public void Reset()
    {
        foreach (TargetCollide t in targetArray)
        {
            t.Reset();
        }
        nextTarget = 0;        
    }
}