using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tree
{
    private string color;
    private int height;

    public Tree(int height)
    {
        this.color = "green";
        this.height = height;
    }

    public string getColor()
    {
        return color;
    }

    public int getHeight()
    {
        return height;
    }
}