using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageGeneratorWithUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int width, height;

            if (int.TryParse(txtWidth.Text, out width) && int.TryParse(txtHeight.Text, out height))
            {
                // 使用 FolderBrowserDialog 让用户选择保存目录
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
                {
                    Description = "选择保存图像的目录"
                };

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取用户选择的目录
                    string saveDirectory = folderBrowserDialog.SelectedPath;

                    // 设定图片命名逻辑
                    string name1 = $"列_奇白偶黑_{width}x{height}";
                    string name2 = $"列_奇黑偶白_{width}x{height}";
                    string name3 = $"列_奇红偶黑_{width}x{height}";
                    string name4 = $"列_奇黑偶红_{width}x{height}";
                    string name5 = $"列_奇绿偶黑_{width}x{height}";
                    string name6 = $"列_奇黑偶绿_{width}x{height}";
                    string name7 = $"列_奇蓝偶黑_{width}x{height}";
                    string name8 = $"列_奇黑偶蓝_{width}x{height}";


                    // 调用图像生成逻辑
                    GenerateImage(width, height, name1, Color.White, Color.Black, Path.Combine(saveDirectory, $"{name1}.bmp"));
                    GenerateImage(width, height, name2, Color.Black, Color.White, Path.Combine(saveDirectory, $"{name2}.bmp"));
                    GenerateImage(width, height, name3, Color.Red,   Color.Black, Path.Combine(saveDirectory, $"{name3}.bmp"));
                    GenerateImage(width, height, name4, Color.Black, Color.Red,   Path.Combine(saveDirectory, $"{name4}.bmp"));
                    GenerateImage(width, height, name5, Color.Green, Color.Black, Path.Combine(saveDirectory, $"{name5}.bmp"));
                    GenerateImage(width, height, name6, Color.Black, Color.Green, Path.Combine(saveDirectory, $"{name6}.bmp"));
                    GenerateImage(width, height, name7, Color.Blue,  Color.Black, Path.Combine(saveDirectory, $"{name7}.bmp"));
                    GenerateImage(width, height, name8, Color.Black, Color.Blue,  Path.Combine(saveDirectory, $"{name8}.bmp"));

                    MessageBox.Show("图片生成成功！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请输入有效的分辨率！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        bitmap.SetPixel(x, y, oddColor);
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, evenColor);
                    }
                }
            }

            bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void 电压设定ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
