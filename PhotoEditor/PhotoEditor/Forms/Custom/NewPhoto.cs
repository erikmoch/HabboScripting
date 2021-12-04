using PhotoEditor.Editor.Modules;
using PhotoEditor.Editor.Photo.Camera;
using PhotoEditor.Editor.Photo.Camera.Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class NewPhoto : Form
    {
        private Form1 _MainFrm;
        public NewPhoto(Form1 MainFrm)
        {
            _MainFrm = MainFrm;
            InitializeComponent();
        }
        private void NewPhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;
            e.Cancel = true;
            Hide();
        }
        private void chk_transparent_CheckedChanged(object sender, EventArgs e)
        {
            btn_insert_colorselect.Enabled = !chk_transparent.Checked;
            nud_insert_updatecolor.Enabled = !chk_transparent.Checked;
        }

        private void btn_insert_colorselect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cod_input.ShowDialog() != DialogResult.OK)
                    return;
                nud_insert_updatecolor.Value = ColorConverterTools.ColorToAccess(cod_input.Color);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("An error occurred: {0}", ex.Message), true);
            }
        }

        private void NewPhoto_Activated(object sender, EventArgs e)
        {
        }

        private void sKoreButton1_Click(object sender, EventArgs e)
        {
            HPhoto photo = new HPhoto();
            Plane plane = new Plane();
            if (!chk_transparent.Checked)
            {
                plane.CornerPoints.Add(new Point(320, 320));
                plane.CornerPoints.Add(new Point(0, 320));
                plane.CornerPoints.Add(new Point(320, 0));
                plane.CornerPoints.Add(new Point(0, 0));
            }
            else
            {
                plane.CornerPoints.Add(new Point(0, 0));
                plane.CornerPoints.Add(new Point(0, 0));
                plane.CornerPoints.Add(new Point(0, 0));
                plane.CornerPoints.Add(new Point(0, 0));
            }
            plane.Color = (int)nud_insert_updatecolor.Value;
            photo.Planes.Add(plane);
            photo.Planes.Add(new Plane()
            {
                CornerPoints = {
          new Point(0, 0),
          new Point(0, 0),
          new Point(0, 0),
          new Point(0, 0)
        }
            });
            photo.RoomId = (int)nud_roomid.Value;
            photo.Zoom = chk_zoom.Checked ? 2 : 0;
            _MainFrm.SetJsonSourcePhoto(photo, chk_custom_status.Checked, chk_custom_timestamp.Checked, chk_custom_checksum.Checked, (long)nud_custom_status.Value, (long)nud_custom_timestamp.Value, (long)nud_custom_checksum.Value);
            Hide();
        }

        private void NewPhoto_Load(object sender, EventArgs e)
        {
            TopMost = _MainFrm.alwayOnTopToolStripMenuItem.Checked;
        }
    }
}
