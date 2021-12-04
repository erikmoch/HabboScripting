using PhotoEditor.Editor.BitmapTools;
using PhotoEditor.Editor.Modules;
using PhotoEditor.Editor.Photo.Camera.Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace PhotoEditor
{

        public partial class DrawPhoto : Form
        {
            private Form1 _MainFrm;
            public int X = 0;
            public int Y = 0;
            private Color[,] Colorarray = new Color[16, 16];
            private List<Color[,]> Colorarraylist = new List<Color[,]>();
            private List<PictureBox> pictureBoxControls = new List<PictureBox>();

            public DrawPhoto(Form1 MainFrm)
            {
                _MainFrm = MainFrm;
                InitializeComponent();
            }
            private void DrawPhoto_Load(object sender, EventArgs e)
            {
                TopMost = _MainFrm.alwayOnTopToolStripMenuItem.Checked;
            }

            private void DrawPhoto_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (e.CloseReason != CloseReason.UserClosing)
                    return;
                e.Cancel = true;
                Hide();
            }
            private List<string> DirSearch(string sDir)
            {
                var stringList = new List<string>();
                try
                {
                    foreach (var file in Directory.GetFiles(sDir))
                        stringList.Add(Path.GetFileNameWithoutExtension(file));
                    foreach (var directory in Directory.GetDirectories(sDir))
                        stringList.AddRange(DirSearch(directory));
                }
                catch (Exception ex)
                {
                    var num = (int)MessageBox.Show(ex.Message);
                }
                return stringList;
            }
            private void bgw_combobox_DoWork(object sender, DoWorkEventArgs e)
            {
                cbo_insert.Invoke(new MethodInvoker(delegate ()
                {
                    cbo_insert.DataSource = new BindingSource(DirSearch(_MainFrm.drawDir), null);
                    cbo_insert.SelectedIndex = 0;
                    cbo_insert.Enabled = true;
                }));
                btn_insert.Invoke(new MethodInvoker(delegate () { btn_insert.Enabled = true; }));
                foreach (var pictureBoxControl in pictureBoxControls)
                {
                    var t = pictureBoxControl;
                    t.Invoke(new MethodInvoker(delegate () { t.Enabled = true; }));
                }
                Console.WriteLine("Sprite names loaded", false);
            }

            private void DrawPhoto_Shown(object sender, EventArgs e)
            {
                for (var index1 = 0; index1 < 16; ++index1)
                {
                    for (var index2 = 0; index2 < 16; ++index2)
                    {
                        var pictureBox1 = new PictureBox();
                        pictureBox1.Size = new Size(20, 20);
                        pictureBox1.Location = new Point(index1 * 20, index2 * 20);
                        pictureBox1.Visible = true;
                        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                        pictureBox1.Name = string.Format("pib_{0}_{1}", index1, index2);
                        var pictureBox2 = pictureBox1;
                        pictureBox2.Click += new EventHandler(pib_Click);
                        pictureBox2.MouseHover += new EventHandler(pib_MouseOver);
                        pictureBox2.Show();
                        pictureBoxControls.Add(pictureBox2);
                        pan_drawing.Controls.Add((Control)pictureBox2);
                        pan_drawing.Visible = true;
                        pan_drawing.Show();
                    }
                }
                Console.WriteLine("Loading sprite names, please wait...");
                bgw_combobox.RunWorkerAsync();
            }
            private void pib_MouseOver(object sender, EventArgs e)
            {
                if (!chk_mouseover.Checked) return;
                var pictureBox1 = (PictureBox)sender;
                var strArray = pictureBox1.Name.Substring(4, pictureBox1.Name.Length - 4).Split('_');
                var index1 = int.Parse(strArray[0]);
                var index2 = int.Parse(strArray[1]);
                if (rad_paint.Checked)
                {
                    if (File.Exists(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text)))
                    {
                        var pictureBox2 = pictureBox1;
                        var sourceBitmap = new Bitmap(Image.FromFile(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text), true));
                        var color = cod_input.Color;
                        int b = (int)color.B;
                        color = cod_input.Color;
                        var g = (int)color.G;
                        var r = (int)cod_input.Color.R;
                        var bitmap = sourceBitmap.ColorBalance((byte)b, (byte)g, (byte)r);
                        pictureBox2.Image = bitmap;
                    }
                    else
                        Console.WriteLine(string.Format("Missing Sprites - Assets: {0}", cbo_insert.Text));
                    Colorarray[index2, index1] = cod_input.Color;
                }
                else
                {
                    pictureBox1.Image = null;
                    Colorarray[index2, index1] = Color.Transparent;
                }
            }

            private void pib_Click(object sender, EventArgs e)
            {
                var pictureBox1 = (PictureBox)sender;
                var strArray = pictureBox1.Name.Substring(4, pictureBox1.Name.Length - 4).Split('_');
                var index1 = int.Parse(strArray[0]);
                var index2 = int.Parse(strArray[1]);
                if (rad_paint.Checked)
                {
                    if (File.Exists(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text)))
                    {
                        var pictureBox2 = pictureBox1;
                        var sourceBitmap = new Bitmap(Image.FromFile(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text), true));
                        var color = cod_input.Color;
                        var b = color.B;
                        color = cod_input.Color;
                        var g = color.G;
                        color = cod_input.Color;
                        var r = color.R;
                        var bitmap = sourceBitmap.ColorBalance(b, g, r);
                        pictureBox2.Image = bitmap;
                    }
                    else
                        Console.WriteLine(string.Format("Missing Sprites - Assets: {0}", cbo_insert.Text), false);
                    Colorarray[index2, index1] = cod_input.Color;
                }
                else
                {
                    pictureBox1.Image = null;
                    Colorarray[index2, index1] = Color.Transparent;
                }
            }

            private void btn_insert_colorselect_Click(object sender, EventArgs e)
            {

                try
                {
                    var num = (int)cod_input.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("An error occurred: {0}", ex.Message), true);
                }
            }

            private void btn_clear_Click(object sender, EventArgs e)
            {
                foreach (var pictureBoxControl in pictureBoxControls)
                    pictureBoxControl.Image = null;
                Colorarray = new Color[16, 16];
            }

            private void sKoreButton2_Click(object sender, EventArgs e)
            {
                try
                {
                    if (cod_input2.ShowDialog() != DialogResult.OK)
                        return;
                    foreach (var pictureBoxControl in pictureBoxControls)
                    {
                        if (File.Exists(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text)))
                        {
                            var pictureBox = pictureBoxControl;
                            var sourceBitmap = new Bitmap(Image.FromFile(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text)));
                            var color = cod_input2.Color;
                            var b = color.B;
                            color = cod_input2.Color;
                            var g = color.G;
                            color = cod_input2.Color;
                            var r = color.R;
                            var bitmap = sourceBitmap.ColorBalance(b, g, r);
                            pictureBox.Image = bitmap;
                        }
                        else
                            Console.WriteLine(string.Format("Missing Sprites - Assets: {0}", cbo_insert.Text));
                    }
                    for (var index1 = 0; index1 < 16; ++index1)
                    {
                        for (var index2 = 0; index2 < 16; ++index2)
                            Colorarray[index1, index2] = cod_input2.Color;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("An error occurred: {0}", ex.Message));
                }
            }

            private void sKoreButton3_Click(object sender, EventArgs e)
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png, *.bmp, *.jpg, *.jpeg, *.gif, *.ico)|*.png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                foreach (var pictureBoxControl in pictureBoxControls)
                    pictureBoxControl.Image = null;
                lsv_image.Items.Clear();
                Colorarraylist.Clear();
                using (var stream = openFileDialog.OpenFile())
                {
                    var bitmap = new Bitmap(stream);
                    var num1 = Math.Ceiling(bitmap.Height / 16.0);
                    var num2 = Math.Ceiling(bitmap.Width / 16.0);
                    for (var index1 = 0; index1 < num1; ++index1)
                    {
                        for (var index2 = 0; index2 < num2; ++index2)
                        {
                            var colorArray = new Color[16, 16];
                            for (var index3 = 0; index3 < 16; ++index3)
                            {
                                for (var index4 = 0; index4 < 16; ++index4)
                                {
                                    if (index1 * 16 + index4 < bitmap.Height && index2 * 16 + index3 < bitmap.Width)
                                    {
                                        var color1 = new Color();
                                        color1 = bitmap.GetPixel(index2 * 16 + index3, index1 * 16 + index4);
                                        if ((!chk_ignore.Checked || ColorConverterTools.ColorToAccess(color1) != (int)nud_updatecolor.Value) && color1.A != 0)
                                        {
                                            var color3 = ColorConverterTools.AccessToColor(394758);
                                            if (color1 == Color.Black)
                                                color1 = color3;
                                            if (color1.A == 0)
                                                color1 = Color.Transparent;
                                            colorArray[index4, index3] = color1;
                                        }
                                    }
                                }
                            }
                            var items = new string[2];
                            var index5 = 0;
                            var num3 = index2 + 1;
                            var str1 = num3.ToString();
                            items[index5] = str1;
                            var index6 = 1;
                            num3 = index1 + 1;
                            var str2 = num3.ToString();
                            items[index6] = str2;
                            lsv_image.Items.Add(new ListViewItem(items));
                            Colorarraylist.Add(colorArray);
                        }
                    }
                }
                lbl_amount.Text = lsv_image.Items.Count.ToString();
            }

            private void nud_updatecolor_ValueChanged(object sender, EventArgs e)
            {

            }

            private void sKoreButton1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (cod_input.ShowDialog() != DialogResult.OK)
                        return;
                    nud_updatecolor.Value = ColorConverterTools.ColorToAccess(cod_input.Color);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("An error occurred: {0}", ex.Message));
                }
            }

            private void lsv_image_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lsv_image.SelectedItems.Count <= 0)
                    return;
                foreach (var pictureBoxControl in pictureBoxControls)
                    pictureBoxControl.Image = (Image)null;
                var colorArray = Colorarraylist[lsv_image.Items.IndexOf(lsv_image.SelectedItems[0])];
                for (var index1 = 0; index1 < 16; ++index1)
                {
                    for (var index2 = 0; index2 < 16; ++index2)
                    {
                        if (colorArray[index1, index2].A != (byte)0)
                        {
                            var pictureBox = new PictureBox();
                            foreach (PictureBox control in (ArrangedElementCollection)pan_drawing.Controls)
                            {
                                if (control.Name == string.Format("pib_{0}_{1}", index2, index1))
                                    pictureBox = control;
                            }
                            if (File.Exists(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text)))
                                pictureBox.Image = new Bitmap(Image.FromFile(string.Format("{0}{1}.png", _MainFrm.drawDir, cbo_insert.Text), true)).ColorBalance(colorArray[index1, index2].B, colorArray[index1, index2].G, colorArray[index1, index2].R);
                            else
                                Console.WriteLine(string.Format("Missing Sprites - Assets: {0}", cbo_insert.Text));
                        }
                    }
                }
                Colorarray = colorArray;
            }

            private void sKoreButton4_Click(object sender, EventArgs e)
            {
                drawOnPhoto(true);
            }

            private void sKoreButton5_Click(object sender, EventArgs e)
            {
                drawOnPhoto(false);
            }

            private void sKoreButton6_Click(object sender, EventArgs e)
            {
                X = 0;
                Y = 0;
                nud_x.Value = decimal.Zero;
                nud_y.Value = decimal.Zero;
                btn_save.Enabled = false;
                btn_remove.Enabled = false;
            }
            private void drawOnPhoto(bool insert)
            {
                if (_MainFrm.currentPhoto == null)
                    return;
                var source = new List<Sprite>();
                var myPen = new Pen(Color.Black, 1f);
                X = (int)nud_x.Value;
                Y = (int)nud_y.Value;
                for (var index1 = 1; index1 <= 16; ++index1)
                {
                    for (var index2 = 1; index2 <= 16; ++index2)
                    {
                        if (Colorarray[index1 - 1, index2 - 1].A != 0)
                        {
                            var sprite = new Sprite()
                            {
                                Color = ColorConverterTools.ColorToAccess(Colorarray[index1 - 1, index2 - 1]),
                                Name = cbo_insert.Text,
                                X = (index2 - 1) * 20 + X,
                                Y = (index1 - 1) * 20 + Y,
                                Z = (int)nud_z.Value
                            };
                            if (insert)
                                source.Add(sprite);
                            else
                                _MainFrm.currentPhoto.Sprites.Add(sprite);
                        }
                    }
                }
                if (insert)
                {
                    btn_remove.Enabled = true;
                    btn_save.Enabled = true;
                }
                else
                {
                    _MainFrm.SetJsonSourcePhoto(_MainFrm.currentPhoto, false, false, false, 0L, 0L, 0L);
                    btn_remove.Enabled = false;
                    btn_save.Enabled = false;
                }
            }
        }
    }

