using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExDragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listSursa.Items.Add("Item 1");
            listSursa.Items.Add("Item 2");
            listSursa.Items.Add("Item 3");
        }

        private void listSursa_DragDrop(object sender, DragEventArgs e)
        {

            string item = (string)e.Data.GetData(DataFormats.StringFormat);
            listSursa.Items.Add(item);
            listDestinatie.Items.Remove(item);
        }

        private void listDestinatie_DragDrop(object sender, DragEventArgs e)
        {
            string item = (string)e.Data.GetData(DataFormats.StringFormat);
            listDestinatie.Items.Add(item);
            listSursa.Items.Remove(item);

        }

        private void listSursa_MouseDown(object sender, MouseEventArgs e)
        {
            if (listSursa.SelectedItems == null) return;
            else
            listSursa.DoDragDrop(listSursa.SelectedItem, DragDropEffects.Move);

        }

        private void listDestinatie_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void listDestinatie_MouseDown(object sender, MouseEventArgs e)
        {
            if (listDestinatie.SelectedItems == null) return;
            else
                listDestinatie.DoDragDrop(listDestinatie.SelectedItem, DragDropEffects.Move);

        }

        private void listSursa_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }
    }
}
