﻿using System;
using System.Drawing;

namespace TagsCloudVisualization
{
    public static class ColorPallete
    {
        private static Color[] colors = new[]
        {
            Color.FromArgb(131, 176, 219),
            Color.FromArgb(131, 219, 161),
            Color.FromArgb(189, 219, 131),
            Color.FromArgb(249, 221, 82),
            Color.FromArgb(249, 184, 82),
            Color.FromArgb(239, 128, 76),
            Color.FromArgb(232, 99, 37),
            Color.FromArgb(237, 75, 97),
            Color.FromArgb(186, 39, 107),
            Color.FromArgb(122, 22, 175),
            Color.FromArgb(64, 57, 198)
        };
        private static Random random = new Random();

        public static Color GetColor()
        {
            return colors[random.Next(0, colors.Length)];
        }
    }
}
