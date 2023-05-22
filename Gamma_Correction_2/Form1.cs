using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamma_Library;

namespace Gamma_Correction_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Algorithm gamma;

        private void btnOFD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Изображкние (*.png;*.jpg)|*.png;*.jpg",
                Title = "Выберите изображение"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            else
                inputPicture.Image = new Bitmap(ofd.FileName);
            progressBar1.Value = 0;
            outputPicture.Image = null;
        }
        public void Progress(double percentage)
        {
            progressBar1.Value += (int)Math.Floor(percentage);
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (inputPicture.Image != null)
            {
                SortedList<string, object> par = new SortedList<string, object>();
                par.Add("Image", inputPicture.Image);
                par.Add("Gamma", (float)numGamma.Value);
                gamma = new Algorithm();
                gamma.init(par);

                progressBar1.Value = 0;
                progressBar1.Maximum = inputPicture.Image.Height;
                ProgressDelegate progressBar = Progress;

                gamma.startHandle(progressBar);
                outputPicture.Image = gamma.Result;
            }
            else
            {
                MessageBox.Show("Для начала выбирите изображение. Сделать это можно, нажав кнопку \"Открыть изображение\"",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOFD.Focus();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            inputPicture.Width = Size.Width / 2;
        }
    }
}
