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
            int[] nextIndex = new int[nums.Length]; // Stores the next element index for each element.
            for (int i = 0; i < nums.Length; i++)
            {
                nextIndex[i] = -1; // Initially, no next element for any element.
            }

            // Build the nextIndex array based on the given array.
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0 && nums[i] < nums.Length)
                {
                    nextIndex[i] = nums[i];
                }
            }

            // Find the longest chain using Floyd's cycle-finding algorithm.
            int slow = 0, fast = 0;
            while (nextIndex[fast] != -1 && nextIndex[nextIndex[fast]] != -1)
            {
                slow = nextIndex[slow];
                fast = nextIndex[nextIndex[fast]];
                if (slow == fast)
                {
                    // Cycle detected, calculate its length.
                    int cycleLength = 1;
                    do
                    {
                        if (nextIndex[fast] != -1)
                        {
                            fast = nextIndex[fast];
                            cycleLength++;
                        }
                    } while (fast != slow);

                    return cycleLength;
                }
            }

            // No cycle found, return the longest consecutive sequence.
            int maxLength = 1;
            int currentLength = 1;
            for (int i = 0; i < nextIndex.Length; i++)
            {
                if (nextIndex[i] == i + 1)
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }
            return Math.Max(maxLength, currentLength);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get input values from textboxes
            int multiplier = int.Parse(txtMultiplier.Text);
            int seed = int.Parse(txtSeed.Text);
            int modulus = int.Parse(txtModulus.Text);
            int increment = int.Parse(txtIncrement.Text);
            int iterations = int.Parse(txtIterations.Text);
            int[] result = new int[] { };
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
