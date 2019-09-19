using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> SpriteList;
        string[] SpriteListCopy;
        Bitmap FullList;
        int w = 0;
        int h = 0;
        int x = 0;
        int y = 0;
        int row = 0;
        int wsize = 0;
        int hsize = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectDialog_Click(object sender, EventArgs e)
        {
           if (selectImages.ShowDialog() == DialogResult.OK)
            {
                SpriteList = selectImages.FileNames.ToList();
                SelectDialog.Text = "Images:" + SpriteList.Count;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            row = Decimal.ToInt32(rows.Value);
            SpriteListCopy = (string[])SpriteList.ToArray().Clone();

            if (reverseorder.Checked) { Array.Reverse(SpriteListCopy); }

            if(offset.Value > 0 & offset.Value <= SpriteListCopy.Length)
            {
                for (int i = 0; i < SpriteListCopy.Length; i++)
                {
                    int number = i + Convert.ToInt32(offset.Value);
                    if(number > SpriteListCopy.Length - 1)
                    {
                        number -= SpriteListCopy.Length;
                    }
                    var temp = SpriteListCopy[0];
                    SpriteListCopy[number] = SpriteList[i];
                }
            }

            foreach (var img in SpriteListCopy)
            {
                Image sprite = Image.FromFile(img);
                if(w < sprite.Width) { w = sprite.Width; }
                if(h < sprite.Height) { h = sprite.Height; }
            }

            w -= Convert.ToInt32(TLeft.Value + TRight.Value);
            h -= Convert.ToInt32(TTop.Value + TBottom.Value);

            if (grCol.Checked)
            {
                w++;
                h++;
            }

            if (SpriteListCopy.Length > 1)
            {
                hsize = h * row;
            } else
            {
                hsize = h;
            }

            if (SpriteListCopy.Length >= row)
            {
                float a = SpriteListCopy.Count();
                float b = row;
                double cols = Math.Ceiling(a / b);
                wsize = w * (int)cols;
            } else
            {
                wsize = w * SpriteListCopy.Length;
            }
            if (wsize > 0 & hsize > 0)
            {

                int xg = SpriteListCopy.Count() / row;
                int yg = row;

                FullList = new Bitmap(wsize, hsize);

                if (grCol.Checked)
                {
                    Graphics g = Graphics.FromImage(FullList);

                    for (int i = 1; i <= xg; i++)
                    {
                        g.DrawLine(new Pen(colorDialog2.Color, 1), new Point(w * i - 1, 0), new Point(w * i - 1, hsize));
                    }
                    for (int j = 1; j <= yg; j++)
                    {
                        g.DrawLine(new Pen(colorDialog2.Color, 1), new Point(0, h * j - 1), new Point(wsize, h * j - 1));
                    }

                }

                foreach (var img in SpriteListCopy)
                {
                    Image sprite = Image.FromFile(img);
                    using (Graphics g = Graphics.FromImage(FullList))
                    {
                        if (hmir.Checked)
                        {
                            sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }
                        if (vmir.Checked)
                        {
                            sprite.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        }

                        if (TRight.Value != 0 || TTop.Value != 0 || TLeft.Value != 0 || TBottom.Value != 0)
                        {

                        }

                        if (center.Checked)
                        {
                            int TrimXOffset = Convert.ToInt32(TLeft.Value - TRight.Value);
                            int TrimYOffset = Convert.ToInt32(TTop.Value - TBottom.Value);
                            g.DrawImage(sprite, x + ((w - sprite.Width) / 2) - TrimXOffset, y + ((h - sprite.Height) / 2) - TrimYOffset, sprite.Width, sprite.Height);
                        }
                        else if (leftbot.Checked)
                        {
                            g.DrawImage(sprite, x, y + (h - sprite.Height), sprite.Width, sprite.Height);
                        }
                        else if (righttop.Checked)
                        {
                            g.DrawImage(sprite, x + (w - sprite.Width), y, sprite.Width, sprite.Height);
                        }
                    }
                    if (x + w >= wsize)
                    {
                        x = 0;
                        y += h;
                    }
                    else { x += w; }
                }
                if (saveList.ShowDialog() == DialogResult.OK)
                {
                    string Path = saveList.FileName.ToString();
                    switch (saveList.FilterIndex.ToString())
                    {
                        case "1":
                            {
                                FullList.Save(Path, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            }
                        case "2":
                            {
                                FullList.Save(Path, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            }
                        case "3":
                            {
                                FullList.Save(Path, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                            }
                        default:
                            {
                                FullList.Save(Path);
                                break;
                            }
                    }

                }
            } else
            {
                MessageBox.Show("You can not cut more than the original image!", "Error");
            }

            w = 0;
            h = 0;
            x = 0;
            y = 0;
            row = 0;
            wsize = 0;
            hsize = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TRight.Value > 0 || TTop.Value > 0 || TLeft.Value > 0 || TBottom.Value > 0)
            {
                center.Checked = true;
                leftbot.Enabled = false;
                righttop.Enabled = false;
            } else
            {
                leftbot.Enabled = true;
                righttop.Enabled = true;
            }
        }

        string spriteList_name = "";
        Bitmap spriteList;

        private void ListSelect_Click(object sender, EventArgs e)
        {
            if (selectListToSplit.ShowDialog() == DialogResult.OK)
            {
                spriteList_name = selectListToSplit.SafeFileName;
                spriteList = new Bitmap(selectListToSplit.FileName);
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            if (splitW.Value > 0 && splitH.Value > 0)
            {
                int xCount = Convert.ToInt32(splitW.Value);
                int xSize = Convert.ToInt32(Math.Floor(spriteList.Width / splitW.Value));
                int yCount = Convert.ToInt32(splitH.Value);
                int ySize = Convert.ToInt32(Math.Floor(spriteList.Height / splitH.Value));

                int i = 0;

                folderBrowserDialog1.SelectedPath = new Regex(selectListToSplit.SafeFileName).Replace(selectListToSplit.FileName, "");
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath + "/";
                    for (int verticalCounter = 0; verticalCounter < yCount; verticalCounter++)
                    {
                        for (int horizontalCounter = 0; horizontalCounter < xCount; horizontalCounter++)
                        {
                            Bitmap bitmap = new Bitmap(xSize, ySize);
                            i++;
                            for (int y1 = 0; y1 < ySize; y1++)
                            {
                                for (int x1 = 0; x1 < xSize; x1++)
                                {
                                    bitmap.SetPixel(x1, y1, spriteList.GetPixel(horizontalCounter * xSize + x1, verticalCounter * ySize + y1));
                                }
                            }

                            if (new Regex(@".png$", RegexOptions.IgnoreCase).IsMatch(selectListToSplit.FileName))
                            {
                                string saveFileName = new Regex(@".png$", RegexOptions.IgnoreCase).Replace(selectListToSplit.SafeFileName, "");
                                bitmap.Save(path + saveFileName + "-" + i + ".png", System.Drawing.Imaging.ImageFormat.Png);
                            }
                            else if (new Regex(@".bmp$", RegexOptions.IgnoreCase).IsMatch(selectListToSplit.FileName))
                            {
                                string saveFileName = new Regex(@".bmp$", RegexOptions.IgnoreCase).Replace(selectListToSplit.SafeFileName, "");
                                bitmap.Save(path + saveFileName + "-" + i + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                            }
                            else
                            {
                                string saveFileName = new Regex(@".png$", RegexOptions.IgnoreCase).Replace(selectListToSplit.SafeFileName, "");
                                bitmap.Save(path + saveFileName + "-" + i + ".png", System.Drawing.Imaging.ImageFormat.Png);
                            }
                        }
                    }
                    MessageBox.Show("Job done! (" + i.ToString() + ")");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = colorDialog1.Color;
            pictureBox2.BackColor = colorDialog2.Color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void sheetgen_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(genW.Value);
            int h = Convert.ToInt32(genH.Value);
            int x = Convert.ToInt32(genX.Value);
            int y = Convert.ToInt32(genY.Value);

            int picw = w * x;
            int pich = h * y;

            Bitmap sheet = new Bitmap(picw, pich);

            Graphics g = Graphics.FromImage(sheet);

            for (int i = 1; i <= x; i++)
            {
                g.DrawLine(new Pen(colorDialog1.Color, 1), new Point(w * i - 1,0), new Point(w * i - 1, pich));
            }
            for (int j = 1; j <= y; j++)
            {
                g.DrawLine(new Pen(colorDialog1.Color, 1), new Point(0, h * j - 1), new Point(picw, h * j - 1));
            }
            
            if (saveGen.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveGen.FileName;
                sheet.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            pictureBox2.BackColor = colorDialog2.Color;

        }
    }
}
