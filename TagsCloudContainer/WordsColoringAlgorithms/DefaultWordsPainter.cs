using System;
using System.Collections.Generic;
using System.Drawing;

namespace TagsCloudContainer.WordsColoringAlgorithms
{
    public class DefaultWordsPainter : IWordsPainter
    {
        public Color[] GetColorsSequence(Dictionary<string, int> frequencyDictionary, string startColor)
        {
            var color = Color.FromName(startColor);
            if (!color.IsKnownColor)
                throw new ArgumentException("Unknown brush color");
            var wordsCount = frequencyDictionary.Count;
            var colors = new Color[wordsCount];
            for (var i = 0; i < wordsCount; i++)
                colors[i] = color;
            return colors;
        }
    }
}