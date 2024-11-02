using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PieGraph
{
    
    public partial class PieChartControl : UserControl
    {
        private const int FixedDiameter = 400; // Set a fixed diameter for the pie chart

        
        public PieChartControl()
        {
            InitializeComponent(); 
        }

        // List to hold the values for the pie chart
        public List<float> Values { get; set; } = new List<float>();
        // List to hold the corresponding labels for the pie chart slices
        public List<string> Labels { get; set; } = new List<string>();

        // Expanded 15 color palette for pie chart slices
        private List<Color> sliceColors = new List<Color>
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow,
            Color.Purple,
            Color.Orange,
            Color.Cyan,
            Color.Magenta,
            Color.Brown,
            Color.LightBlue,
            Color.LightGreen,
            Color.DarkOrange,
            Color.LightCoral,
            Color.Gold,
            Color.Salmon
        };

        // Override the OnPaint method to draw the pie chart
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Call the base class method

            // Check if there are no values or if the number of labels doesn't match the values
            if (Values.Count == 0 || Values.Count != Labels.Count)
                return; 

            float total = Values.Sum(); // Calculate the total value of all slices
            if (total == 0)
                return; 

            // Position the pie chart at the top center of the control
            Rectangle pieRectangle = new Rectangle((Width - FixedDiameter) / 2, 10, FixedDiameter, FixedDiameter);
            float startAngle = 0; // Starting angle for pie slice drawing

            // Loop through each value to draw pie slices
            for (int i = 0; i < Values.Count; i++)
            {
                // Calculate the angle to sweep based on the value
                float sweepAngle = (Values[i] / total) * 360;
                using (Brush brush = new SolidBrush(GetColor(i))) // Get a brush for the slice color
                {
                    e.Graphics.FillPie(brush, pieRectangle, startAngle, sweepAngle); // Draw the pie slice
                }
                startAngle += sweepAngle; // Update the starting angle for the next slice
            }

            // Adjust the Y position for the legend and draw it
            DrawLegend(e.Graphics, Height - 150); // Move the legend up from the bottom
        }

        // Method to get the color for a specific slice based on its index
        private Color GetColor(int index)
        {
            return sliceColors[index % sliceColors.Count]; // Cycle through the color palette
        }

        // Method to draw the legend for the pie chart
        private void DrawLegend(Graphics graphics, int legendY)
        {
            int legendX = Width - 500; // Starting X position for the legend
            int legendBoxSize = 15; // Size of the color boxes in the legend
            int spacing = 5; // Spacing between legend items
            int itemsPerColumn = 5; // Number of items per column in the legend
            int columnWidth = 120;   // Width allocated for each column

            // Loop through each value to draw the legend items
            for (int i = 0; i < Values.Count; i++)
            {
                // Calculate the current column based on the index
                int column = i / itemsPerColumn;

                // Adjust X position for each column
                int adjustedLegendX = legendX + (column * columnWidth);

                // Draw the color box for the legend item
                using (Brush brush = new SolidBrush(GetColor(i)))
                {
                    graphics.FillRectangle(brush, adjustedLegendX, legendY + (i % itemsPerColumn) * (legendBoxSize + spacing), legendBoxSize, legendBoxSize);
                }

                // Draw the label next to the color box
                using (Font font = new Font("Arial", 10))
                {
                    graphics.DrawString(Labels[i], font, Brushes.Black, adjustedLegendX + legendBoxSize + spacing, legendY + (i % itemsPerColumn) * (legendBoxSize + spacing));
                }
            }
        }
    }
}
