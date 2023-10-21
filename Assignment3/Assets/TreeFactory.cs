using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeFactory
{
    private static Dictionary<int, Tree> treeDictionary;

    public TreeFactory()
    {
        treeDictionary = new Dictionary<int, Tree>();
    }

    public Tree getTree(int height)
    {
        if (height < 1)  return null;

        if (treeDictionary.ContainsKey(height))
        {
            return treeDictionary[height];
        }

        Tree tree = new Tree(height);
        treeDictionary.Add(height, tree);

        return tree;
    }
}


