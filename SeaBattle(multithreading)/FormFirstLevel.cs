using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeaBattle_multithreading_
{
    public partial class FormFirstLevel : Form
    {
        Bitmap up = new Bitmap("up1.png");
        Bitmap  down, right, left;
        public int height = 4;
        public int width = 4;
        public int[,] field;
        public int[,] end;
        public int stepIndex = 0;
        
        public FormFirstLevel()
        {

            InitializeComponent();
        }
        private void LoadLevel()
        {
            StreamReader file1 = new StreamReader("field.txt");
            StreamReader file2 = new StreamReader("EndGame.txt");
            for (int i = 0; i < height; i++)
            {
                string[] s1 = file1.ReadLine().Split();
                string[] s2 = file2.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = int.Parse(s1[j]);
                    end[i, j] = int.Parse(s2[j]);
                }
            }
            file1.Close();
            file2.Close();
        }
        public void GridField()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (field[i, j] == 1)
                        dataGridViewField.Rows[i].Cells[j].Style.BackColor = Color.Fuchsia;

                    else if (field[i, j] == 2)
                        dataGridViewField.Rows[i].Cells[j].Style.BackColor = Color.Black;

                    else  dataGridViewField.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
        private void FormFirstLevel_Load(object sender, EventArgs e)
        {
            field = new int[height, width];
            end = new int[height, width];
            dataGridViewField.Rows.Add(height);
            dataGridViewMove.Rows.Add(4);
            pictureBoxA.BackColor = Color.Fuchsia;
            pictureBoxB.BackColor = Color.Black;
            LoadLevel();
            dataGridViewMove.ClearSelection();
            dataGridViewField.ClearSelection();
            dataGridViewMove.Rows[0].Cells[0].Selected = false;
            dataGridViewField.Enabled = false;
            GridField();

            
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
                var button = (Button)sender;
                dataGridViewMove.CurrentCell.Value = button.Image;
            
        }

       
      
//        public bool TryStep(Image StepShip, int y, int x, int[,] tempField)
//        {
//            switch (StepShip)
//            {
//                case dataGridViewMove.CurrentCell.Value == buttonUp.Image:
//                    if (y - 1 < 0) return true;
//                    else  tempField[y - 1, x] = field[y, x];
//                    break;
//                case "v":
//                    if (y + 1 > height - 1) return true;
//                    else  tempField[y + 1, x] = field[y, x];
//                    break;
//                case ">":
//                    if (x + 1 > width - 1)  return true;
//                    else  tempField[y, x + 1] = field[y, x];
//                    break;
//                case "<":
//                    if (x - 1 < 0)  return true;
//                    else  tempField[y, x - 1] = field[y, x];
//                    break;
//            }
//            return false;
//        }
//        public bool CheckWin()
//        {
//            for (int i = 0; i < height; i++)
//            {
//                for (int j = 0; j < width; j++)
//                {
//                    if (field[i, j] != end[i, j])
//                    {
//                        GridField();
//                        return false;
//                    }
//                }
//            }
//            return true;
//        }

//        private void buttonToRun_Click(object sender, EventArgs e)
//        {
//            bool lose = false;
//            for (int i = 1; i < stepIndex; i++)
//            {
//                lose = false;
//                var stepYellow = (Image)dataGridViewMove.Rows[i].Cells[0].Value ;
//                var stepBlack = (Image)dataGridViewMove.Rows[i].Cells[1].Value;
//                var tempField = new int[height, width];
//                for (int y = 0; y < height; y++)
//                {
//                    for (int x = 0; x < width; x++)
//                    {
//                        if (field[y, x] == 1)
//                            lose = TryStep(stepYellow, y, x, tempField);
//                        else if (field[y, x] == 2)
//                            lose = TryStep(stepBlack, y, x, tempField);

//                        if (lose)
//                            goto finish;

//                    }
//                }
//                field = tempField;
//                GridField();
//            }

//            finish:
//            if (!lose && CheckWin()) MessageBox.Show("Поздравляю, вы выиграли!");
//            else MessageBox.Show("Вы проиграли");
//        }
   }
}
