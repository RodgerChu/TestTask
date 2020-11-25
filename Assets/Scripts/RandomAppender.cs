using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomAppender
{
    public void AppendToArray(GameObject[] source, GameObject[] additional)
    {
        var nullIndexes = GetNullElementsIndexes(source);

        if (nullIndexes.Length == 0)
            return;

        var random = new System.Random();
        random.Shuffle(nullIndexes);
        random.Shuffle(additional);

        int i = 0, j = 0;

        while (i < nullIndexes.Length && j < additional.Length)
        {
            var nullIndex = nullIndexes[i];
            var newElement = additional[j];

            source[nullIndex] = newElement;

            i++;
            j++;
        }
    }

    private int[] GetNullElementsIndexes(GameObject[] objects)
    {
        var indexes = new List<int>();
        
        for (int i = 0; i < objects.Length; i++)
        {
            var obj = objects[i];

            if (obj == null)
            {
                indexes.Add(i);
            }
        }

        return indexes.ToArray();
    }
}
