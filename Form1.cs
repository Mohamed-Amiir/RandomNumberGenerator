using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int currentIteration = 0;
        public static int FindLongestChain(int[] nums)
        {
            List<int> seenNumbers = new List<int>();
            int cycleLengths = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                // Check if the number is already in the seenNumbers list
                if (seenNumbers.Contains(currentNumber))
                {
                    // If yes, a cycle is found, and we store its length
                    int startIndex = seenNumbers.IndexOf(currentNumber);
                    int cycleLength = i - startIndex;
                    cycleLengths = cycleLength;

                    // Clear the seenNumbers list for the next cycle
                    seenNumbers.Clear();
                    break;
                }

                // Add the current number to the seenNumbers list
                seenNumbers.Add(currentNumber);
            }
            return cycleLengths;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get input values from textboxes
            int multiplier = int.Parse(txtMultiplier.Text);
            int seed = int.Parse(txtSeed.Text);
            int modulus = int.Parse(txtModulus.Text);
            int increment = int.Parse(txtIncrement.Text);
            int iterations = int.Parse(txtIterations.Text);
            int[] result = { };
            for (int i = 0; i < iterations; i++)
            {
                seed = GenerateRandomNumber((int)seed, (int)multiplier, (int)increment, (int)modulus);
                dataGridView1.Rows.Add(seed, ++currentIteration);
                result.Append(seed);
            }
            textBox6.Text = FindLongestChain(result).ToString();
        }

        private int GenerateRandomNumber(int seed, int multiplier, int increment, int modulus)
        {
            seed = (multiplier * seed + increment) % modulus;
            return seed;
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
