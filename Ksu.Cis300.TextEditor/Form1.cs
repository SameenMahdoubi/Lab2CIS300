/* Form1.cs
 * Author: Max Maus 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// Constructs a GUI for a program that allows one to open, edit, and save text files.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructs the GUI
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// Open a file of user's choice
        private void UxOpenButton_Click(object sender, EventArgs e)
        {
            if (uxOpenFile.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFile.FileName; // // Process the file. //
                MessageBox.Show("Cannot open file" + fn);

            }
        }

        /// <summary>
        /// Saves a file of user's choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxSaveAsButton_Click(object sender, EventArgs e)
        {
            if (uxSaveFile.ShowDialog() == DialogResult.OK)
            {
                string fn = uxSaveFile.FileName; // // Process the file. // 
                MessageBox.Show("Cannot save file" + fn);
            }
        }
    }
    }
