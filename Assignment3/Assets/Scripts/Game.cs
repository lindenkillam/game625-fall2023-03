using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    private List<Tree> trees;
    private List<TreePosition> treePositions;
    //private GameObject createdTree;

    private TreeFactory treeFactory;

    public Game()
    {
        this.trees = new List<Tree>();
        this.treePositions = new List<TreePosition>();

        this.treeFactory = new TreeFactory();
    }

    public void addTree(int x, int y, int height)
    {
        // This function will be called each time you want to add a tree to the scene :^)
        Tree tree = treeFactory.getTree(height);

        if (tree == null) return;

        trees.Add(tree);
        treePositions.Add(new TreePosition(x, y));

        int treeId = trees.Count - 1;
        this.renderTree(treeId);     
    }

    private void renderTree(int id)
    {
        //createdTree = UnityEngine.Object.Instantiate(trees[id], treePositions[id], Quaternion.identity);
    }
}

