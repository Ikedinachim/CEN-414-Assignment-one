using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statistics
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            numbers.Add(Convert.ToInt32(input1.Text));
            numbers.Add(Convert.ToInt32(input2.Text));
            numbers.Add(Convert.ToInt32(input3.Text));
            numbers.Add(Convert.ToInt32(input4.Text));
            numbers.Add(Convert.ToInt32(input5.Text));
            numbers.Add(Convert.ToInt32(input6.Text));
            numbers.Add(Convert.ToInt32(input7.Text));
            numbers.Add(Convert.ToInt32(input8.Text));
            numbers.Add(Convert.ToInt32(input9.Text));
            numbers.Add(Convert.ToInt32(input10.Text));

            meanText.Text = Convert.ToString(Mean(numbers));
            averageText.Text = Convert.ToString(Mean(numbers));
            varianceTxt.Text = Convert.ToString(Variance(numbers));
            SDText.Text = Convert.ToString(StandardDeviation(numbers));
            medianText.Text = Convert.ToString(median(numbers));
        }
        private double Mean(List<int> numbers)
        {
            return numbers.Average();
            
        }
        private double StandardDeviation(List<int> numbers)
        {
            var meanOfNumbers = numbers.Average();
            var squaredDifferences = new List<double>(numbers.Count);
            foreach(var number in numbers)
            {
                var difference = number - meanOfNumbers;
                var squaredDifference = Math.Pow(difference, 2);
                squaredDifferences.Add(squaredDifference);

            }
            var meanOfSquaredDifferences = squaredDifferences.Average();

            var standardDeviation = Math.Sqrt(meanOfSquaredDifferences);
            return standardDeviation;
        }
        private double Variance(List<int> numbers)
        {
            var meanOfNumbers = numbers.Average();
            var squaredDifferences = new List<double>(numbers.Count);
            foreach (var number in numbers)
            {
                var difference = number - meanOfNumbers;
                var squaredDifference = Math.Pow(difference, 2);
                squaredDifferences.Add(squaredDifference);

            }
            var variance = squaredDifferences.Average();

            return variance;
        }
        private double median(List<int> numbers)
        {
            double median;
            numbers.Sort();

            // Find out if the list is odd
            if ((numbers.Count % 2) == 0)
            {
                double midIndex = numbers.Count / 2;
                 median = (numbers[(int)(midIndex - 0.5)] +
                      numbers[(int)(midIndex + 0.5)]) / 2;
            }
            else
                median = numbers[numbers.Count / 2];
            return median;
        }
       

       


    }
}
