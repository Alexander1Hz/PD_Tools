using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageGeneratorWithUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int width, height;

            if (int.TryParse(txtWidth.Text, out width) && int.TryParse(txtHeight.Text, out height))
            {
                // 使用 SaveFileDialog 让用户选择保存路径和文件名
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Bitmap files (*.bmp)|*.bmp",
                    DefaultExt = "bmp",
                    AddExtension = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取用户选择的路径
                    string filePath = saveFileDialog.FileName;

                    // 调用图像生成逻辑
                    GenerateImage(width, height, "WhiteOddColumn", Color.White, Color.Black, filePath);
                    GenerateImage(width, height, "BlackOddColumn", Color.Black, Color.White, filePath.Replace(".bmp","_BlackOddColumn.bmp"));
                    GenerateImage(width, height, "RedOddColumn", Color.Red, Color.Black, filePath.Replace(".bmp", "_RedOddColumn.bmp"));
                    GenerateImage(width, height, "BlueOddColumn", Color.Blue, Color.Black, filePath.Replace(".bmp", "_BlueOddColumn.bmp"));

                    MessageBox.Show("Images generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid width and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateImage(int width, int height, string name, Color oddColor, Color evenColor, string fileName)
        {
            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x % 2 == 0)
                    {
                        bitmap.SetPixel(x, y, evenColor);
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, oddColor);
                    }
                }
            }

            bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

       

        
    }
}
