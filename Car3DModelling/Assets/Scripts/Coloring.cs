using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    [SerializeField] [NotNull] private List<Material> colors;
    [SerializeField] private int materialToChange;
    [SerializeField] private MeshRenderer mesh;
    private int nextColorIndex;

    private void Start()
    {
        SwitchColor();
    }

    // Update is called once per frame
    public void SwitchColor()
    {
        if (nextColorIndex >= colors.Count)
        {
            nextColorIndex = 0;
        }
        var materials = mesh.materials;
        materials[materialToChange] = colors[nextColorIndex];
        mesh.materials = materials;
        nextColorIndex++;
    }
}