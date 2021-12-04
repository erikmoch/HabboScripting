using System;
using System.Windows.Forms;
using ZTn.Json.JsonTreeView;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using ZTn.Json.JsonTreeView.Linq;
using PhotoEditor.Editor.Photo.Camera;
using PhotoEditor.Editor.Photo.Camera.Layers;
using PhotoEditor.Editor.Modules;
using Newtonsoft.Json.Linq;
using Tangine;
using Sulakore.Modules;
using Sulakore.Communication;
using Sulakore.Protocol;

namespace PhotoEditor
{
    [Author("The Last Airbender")]
    [Module("Photo Editor", "")]
    public partial class Form1 : ExtensionForm
    {
        public HPhoto currentPhoto { get; set; }
        public bool chk_generate_zindex = true;
        public bool chk_generate_status = true;
        public bool chk_generate_timestamp = true;
        public bool chk_generate_checksum = true;
        public int photopreviewHeader = 1595;
        public int roomthumbnailHeader = 2967;
        public string drawDir;
        private System.Timers.Timer jsonValidationTimer;
        public NewPhoto Cnewphoto;
        public DrawPhoto Cdrawphoto;
        private JTokenRoot JsonEditorItem => (jsonTreeView.Nodes.Count != 0) ? new JTokenRoot(((JTokenTreeNode)jsonTreeView.Nodes[0]).JTokenTag) : null;
        public Form1()
        {
            InitializeComponent();
            currentPhoto = null;
            Cnewphoto = new NewPhoto(this);
            Cdrawphoto = new DrawPhoto(this);
            drawDir = string.Format("draw\\");
            InitializeHash();
        }
        private void InitializeHash()
        {
            photopreviewHeader = (int)Out.CameraRoomPicture;
            roomthumbnailHeader = (int)Out.CameraRoomThumbnail;
        }
        [OutDataCapture("CameraRoomPicture")]
        private void GetHabboCamera(DataInterceptedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                txt_compressed.Text = e.Packet.ToString();
                currentPhoto = HPhoto.Create(CompressDecompress.Decompress(this, e.Packet.ToString()));
                SetJsonSourcePhoto(currentPhoto, false, false, false, 0L, 0L, 0L);
            });
        }
        [OutDataCapture("CameraRoomThumbnail")]
        private void GetRoomThumb(DataInterceptedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                txt_compressed.Text = e.Packet.ToString();
                currentPhoto = HPhoto.Create(CompressDecompress.Decompress(this, e.Packet.ToString()));
                SetJsonSourcePhoto(currentPhoto, false, false, false, 0L, 0L, 0L);
            });
        }

        public byte[] GetPacketData(string input)
        {
            return HMessage.ToBytes(input);
        }
        private async void sKoreButton1_Click(object sender, EventArgs e)
        {
            if(txt_compressed.Text != null)
            await Connection.SendToServerAsync(GetPacketData(txt_compressed.Text));
        }
        public double FindMaxValue<T>(List<T> list, Converter<T, double> projection)
        {
            if (list.Count == 0) return 0.0;
            var num1 = double.MinValue;
            foreach (var input in list)
            {
                double num2 = projection(input);
                if (num2 > num1)
                    num1 = num2;
            }
            return num1;
        }

        public double FindMinValue<T>(List<T> list, Converter<T, double> projection)
        {
            if (list.Count == 0) return 0.0;
            var num1 = double.MaxValue;
            foreach (T input in list)
            {
                var num2 = projection(input);
                if (num2 < num1)
                    num1 = num2;
            }
            return num1;
        }

        public int RoundOff(double i, int nearestNumber)
        {
            return (int)Math.Round(i / nearestNumber) * nearestNumber;
        }

        public int RoundUp(double toRound, int nearestNumber)
        {
            return (int)(nearestNumber - toRound % nearestNumber + toRound);
        }

        public int RoundDown(double toRound, int nearestNumber)
        {
            return (int)(toRound - toRound % nearestNumber);
        }

        public void SetJsonSourceString(string json)
        {
            try
            {
                SetJsonSourceStream(new MemoryStream(Encoding.GetEncoding(1252).GetBytes(json)));
            }
            catch { }
        }
        public void SetJsonSourcePhoto(HPhoto photo, bool customstatus = false, bool customtimestamp = false, bool customchecksum = false, long status = 0, long timestamp = 0, long checksum = 0)
        {
            try
            {
                if (chk_generate_zindex)
                {
                    var num1 = 0.0;
                    var maxValue1 = FindMaxValue(photo.Sprites, x => x.Z);
                    var list = new List<Plane>(photo.Planes);
                    if (photo.Planes.Count == 1)
                    {
                        list.RemoveAt(list.Count - 1);
                        var maxValue2 = FindMaxValue(list, x => x.Z);
                        num1 = Math.Max(maxValue1, maxValue2);
                        photo.Planes[0].Z = 0.0;
                    }
                    else if (photo.Planes.Count > 1)
                    {
                        list.RemoveAt(0);
                        list.RemoveAt(0);
                        var maxValue2 = FindMaxValue(list, x => x.Z);
                        var num2 = Math.Max(maxValue1, maxValue2);
                        photo.Planes[0].Z = (photo.Planes.Count - 1) * 2.31743 + photo.Sprites.Count * 1.776104 + num2;
                        photo.Planes[1].Z = num2;
                    }
                }
                var timestampChecksum = photo.getSetStatusTimestampChecksum(chk_generate_status, chk_generate_checksum, chk_generate_checksum, customstatus, customtimestamp, customchecksum, status, timestamp, checksum);
                if (chk_generate_status)
                    photo.Status = timestampChecksum[0];
                if (chk_generate_timestamp)
                    photo.Timestamp = timestampChecksum[1];
                if (chk_generate_checksum)
                    photo.Checksum = timestampChecksum[2];
                SetJsonSourceStream(new MemoryStream(Encoding.GetEncoding(1252).GetBytes(photo.ToJson())));
            }
            catch { }
        }
        public void drawPhoto()
        {
            var myPen = new Pen(Color.Black, 1f);
            var source1 = new List<Plane>();
            var source2 = new List<Sprite>();
            var source3 = new List<Filter>();
            foreach (var plane in currentPhoto.Planes)
                source1.Add(plane);
            foreach (var sprite in currentPhoto.Sprites)
                source2.Add(sprite);
            foreach (var filter in currentPhoto.Filters)
                source3.Add(filter);
        }
        public void SetJsonSourceStream(Stream stream)
        {
            if (stream == null) return;
            JTokenRoot jtokenRoot;
            try
            {
                jtokenRoot = new JTokenRoot(stream);
            }
            catch
            {
                return;
            }
            jsonTreeView.Nodes.Clear();
            jsonTreeView.Nodes.Add(JsonTreeNodeFactory.Create(jtokenRoot.JTokenValue));
            jsonTreeView.Nodes.Cast<TreeNode>().ForEach(n => n.Expand());
            jsonTreeView.SelectedNode = jsonTreeView.Nodes[0];
            var json = ((jsonTreeView.Nodes[0] as JTokenTreeNode).JTokenTag).ToString();
            jsonValueTextBox.Text = json;
            try
            {
                currentPhoto = HPhoto.Create(json);
                drawPhoto();
            }
            catch { }
        }
        private void generateInvisiblePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetJsonSourcePhoto(new HPhoto()
            {
                Planes = { new Plane() { CornerPoints = {  new Point(0, 0),   new Point(0, 0),new Point(0, 0),new Point(0, 0)
            }},
          new Plane()
          {CornerPoints = {
              new Point(0, 0),
              new Point(0, 0),
              new Point(0, 0),
              new Point(0, 0)
            }}}}, false, false, false, 0L, 0L, 0L);
        }

        private void habboJsonPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cnewphoto.Show();
            Cnewphoto.BringToFront();
        }

        private void txt_compressed_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txt_compressed.Text.Length.ToString();
            label2.Text = txt_compressed.Text.Length > 9250 ? "Corrupted" : string.Empty;
        }

        private void sKoreButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPhoto == null) return;
                txt_compressed.Text = CompressDecompress.Compress(this, currentPhoto.ToJson());
            }
            catch { }
        }

        private void sKoreButton1_Click_1(object sender, EventArgs e)
        {
            if (txt_compressed.Text.Length <= 0) return;
            SetJsonSourceString(CompressDecompress.Decompress(this, txt_compressed.Text));
        }

        private void sKoreButton4_Click(object sender, EventArgs e)
        {
            try
            {
                currentPhoto = jsonTreeView.Nodes.Count > 0
                    ? HPhoto.Create(((jsonTreeView.Nodes[0] as JTokenTreeNode).JTokenTag).ToString())
                    : HPhoto.Create(jsonValueTextBox.Text);
                SetJsonSourcePhoto(currentPhoto, false, false, false, 0L, 0L, 0L);
            }
            catch
            {
            }
        }
        private void drawInPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cdrawphoto.Show();
            Cdrawphoto.BringToFront();
        }

        private void alwayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = alwayOnTopToolStripMenuItem.Checked;
        }

        private void jsonTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            JsonTreeView_AfterSelectImplementation((dynamic)e.Node, e);
        }

        private void jsonTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            jsonTreeView.SelectedNode = e.Node;
        }
        private void JsonTreeView_AfterSelectImplementation(TreeNode node, TreeViewEventArgs e)
        {
            jsonValueTextBox.ReadOnly = true;
        }

        private void JsonTreeView_AfterSelectImplementation(JTokenTreeNode node, TreeViewEventArgs e)
        {
            if (jsonValueTextBox.Focused) return;
            jsonValueTextBox.Text = node.JTokenTag.ToString();
        }
        private void JsonTreeView_AfterSelectImplementation(JValueTreeNode node, TreeViewEventArgs e)
        {
            if (node.JValueTag.Type != JTokenType.String)
                jsonValueTextBox.Text = string.Format("{0}", node.JValueTag);
            else
               jsonValueTextBox.Text = string.Format("\"{0}\"", node.JValueTag);
        }

        private void jsonValueTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectedNode = jsonTreeView.SelectedNode as IJsonTreeNode;
            if (selectedNode != null)
            StartValidationTimer(selectedNode);
        }

        private void jsonValueTextBox_Enter(object sender, EventArgs e)
        {
            jsonValueTextBox.TextChanged += new EventHandler(jsonValueTextBox_TextChanged);
        }

        private void jsonValueTextBox_Leave(object sender, EventArgs e)
        {
            jsonValueTextBox.TextChanged -= new EventHandler(jsonValueTextBox_TextChanged);
        }

        private void jsonTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            var jsonTreeNode = e.Node as IJsonTreeNode;
            if (jsonTreeNode != null)
                jsonTreeNode.AfterCollapse();
        }

        private void jsonTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            var jsonTreeNode = e.Node as IJsonTreeNode;
            if (jsonTreeNode != null)
                jsonTreeNode.AfterExpand();
        }

        private void StartValidationTimer(IJsonTreeNode node)
        {
            jsonValidationTimer?.Stop();
            jsonValidationTimer = new System.Timers.Timer(250.0);
            jsonValidationTimer.Elapsed += ((o, args) =>
            {
                jsonValidationTimer.Stop();
                jsonTreeView.Invoke(new Action<IJsonTreeNode>(JsonValidationTimerHandler), node);
            });
            jsonValidationTimer.Start();
        }

        private void JsonValidationTimerHandler(IJsonTreeNode node)
        {
            jsonTreeView.BeginUpdate();
            try
            {
                jsonTreeView.SelectedNode = node.AfterJsonTextChange(jsonValueTextBox.Text);
            }
            catch { }
            jsonTreeView.EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sKoreButton3_Click(object sender, EventArgs e)
        {
            var x = new OpenFileDialog();
            x.CheckFileExists = true;
            x.CheckPathExists = true;
            x.Filter = "Text files (*.json, *.txt)|*.json; *.txt";
            if(x.ShowDialog() == DialogResult.OK)
            {
                var w = new StreamReader(x.FileName);
                SetJsonSourceString(w.ReadToEnd());
            }
        }

        private void fixSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonTreeView.SelectedNode == null) return;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
