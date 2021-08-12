using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxArr.Text != "")
            {


                //string numbers = textBoxArr.Text;
                //int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();
                string[] names = textBoxArr.Text.Split(' ');
                
                BubbleSort(names);
                textBoxArr.Text = string.Join(" ", names);
            }
            else
            {
                MessageBox.Show("Error. Enter numbers:");
                textBoxArr.Focus();
            }
        }
       

        static void Swap<T>(T[] arr, int from, int to)
        {
            T temp = arr[from];
            arr[from] = arr[to];
            arr[to] = temp;
        }

        static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        static void BubbleSort<T>(T[] arr)where T:IComparable
        {
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (Less(arr[i + 1], arr[i])) //(arr[i] > arr[i + 1])
                    {
                        //temp = arr[i + 1];
                        //arr[i + 1] = arr[i];
                        //arr[i] = temp;
                        Swap(arr, i + 1, i);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
