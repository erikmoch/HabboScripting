using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangine;
using Sulakore;
using Sulakore.Modules;
using Sulakore.Communication;
using System.Xml;
using System.Net;
using Sulakore.Habbo;
using System.IO;
using System.Diagnostics;
using Sulakore.Protocol;
using System.Collections.Specialized;

namespace Sniper
{
    [Module("Sniper", "Habbo Market Place Bot")]
    [Author("Moh", HabboName="Airtime", Hotel= Sulakore.Habbo.HHotel.Com)]
    public partial class MainForm : ExtensionForm
    {
        public List<Furni> FurniData = new List<Furni>();
        public List<Furni> FurniToBuy = new List<Furni>();
        public List<Query> Queries = new List<Query>();
        public ushort uBuy = 0;
        public ushort uSearch = 0;
        public ushort uResponse = 0;
        public ushort uItemInfo = 0;
        public bool BotOn = false;
        List<Furni> FurniInInventory = new List<Furni>();
        public MainForm()
        {
            InitializeComponent();
            Task.Run(() => {
                FurniData = LoadFurniDataAsync();
            });
            LoadHeaders();
        }

        private void LoadHeaders()
        {
            try
            {
                uItemInfo = Game.GetMessageHeaders("1d4829715442b2eae722d5f7f7a60eea")[0];
                uBuy = Game.GetMessageHeaders("835342e716bc24747b524fce8733b013")[0];
                uSearch = Game.GetMessageHeaders("9b6d1a7221271e9702d39e9f5574341a")[0];
                uResponse = Game.GetMessageHeaders("06892f6857dcb6722dd3d72eda98f41c")[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Packet headers were not loaded correctly, bot will not work!");
            }
        }

        private List<Furni> LoadFurniDataAsync()
        {
            List<Furni> retFurni = new List<Furni>();
            var furni = new XmlDocument();
            using (var wc = new WebClient())
            {
                wc.Headers.Add("User-Agent", SKore.ChromeAgent);
                wc.Encoding = Encoding.UTF8;
                furni.LoadXml(wc.DownloadString(new Uri($"{Sulakore.Habbo.HHotel.Com.ToUrl(true)}/gamedata/furnidata_xml/1")));
            }

            var itemNodes = furni.GetElementsByTagName("furnitype");

            foreach (XmlNode item in itemNodes)
            {
                Furni Furni = new Furni();
                Furni.ID = int.Parse(item.Attributes["id"]?.InnerText);
                Furni.ShortName = item.Attributes["classname"]?.InnerText;
                Furni.Name = item["name"]?.InnerText;
                Furni.SpecialType = int.Parse(item["specialtype"]?.InnerText);
                Furni.FurniLine = item["furniline"]?.InnerText;
                Furni.BasicType = item.ParentNode.Name.ToString().ToLower().Contains("room") ? 0 : 1;
                Furni.NameTrimmed = TrimName(Furni.Name.ToLower());
                retFurni.Add(Furni);
            }

            return retFurni;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateListBox();
            
        }

        private void CbInterceptItemInfo_ToggledChanged()
        {
            if (cbInterceptItemInfo.Toggled)
            {
                Triggers.OutAttach(uItemInfo, InterceptedItemInfo);
            }
            else
            {
                Triggers.OutDetach(uItemInfo);
            }
        }

        private void InterceptedItemInfo(DataInterceptedEventArgs obj)
        {
            int type = obj.Packet.ReadInteger() -1;
            int furniid = obj.Packet.ReadInteger();
            Furni item = FurniToBuy.Find(x => x.ID == furniid && x.BasicType == type);
            if(item == null)
            {
                item = FurniData.Find(x => x.ID == furniid && x.BasicType == type);
            }
            tbFurniName.Text = item.Name;
            tbFurniID.Text = item.ID.ToString();
            tbFurniType.Text = item.BasicType == 0 ? "Floor Item" : "Wall Item";
            tbFurniMaxPrice.Text = item.MaxBuyPrice.ToString();

            //obj.IsBlocked = true;
        }

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            if(cbBotOn.Toggled)
            {
                MessageBox.Show("Please disable bot first!");
                return;
            }

            //if(lbItems.Items.Count == 20)
            //{
            //    MessageBox.Show("This test version only allows for maximum of 20 items!");
            //    return;
            //}
            int basicType = tbFurniType.Text == "Floor Item" ? 0 : 1;
            int maxBuyPrice = 0;
            try
            {
                maxBuyPrice = int.Parse(tbFurniMaxPrice.Text);
                if(maxBuyPrice < 2 || maxBuyPrice > 25250)
                {
                    throw new OverflowException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Max Buy Price must be between 2 and 25250!");
                return;
            }
            int index = FurniToBuy.FindIndex(x => x.ID == int.Parse(tbFurniID.Text) && x.BasicType == basicType);
            if (index > -1)
            {
                // edit in buy list
                FurniToBuy[index].MaxBuyPrice = maxBuyPrice;
            }
            else
            {
                index = FurniData.FindIndex(x => x.ID == int.Parse(tbFurniID.Text) && x.BasicType == basicType);
                Furni furni = FurniData[index];
                furni.MaxBuyPrice = maxBuyPrice;
                // add to buy list
                FurniToBuy.Add(furni);
            }

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbItems.Items.Clear();
            foreach(Furni furni in FurniToBuy)
            {
                lbItems.Items.Add(furni.Name);
            }
        }

        public List<char> AlphaNumerics = new List<char>()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0',
            '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        public string TrimName(string name)
        {
            string ret = string.Empty;
            foreach (char c in name)
            {
                if (AlphaNumerics.Contains(c))
                    ret = ret + c;
            }

            return ret;
        }

        private void LbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Furni item = FurniToBuy.First(x => x.Name == lbItems.SelectedItem.ToString());
            tbFurniName.Text = item.Name;
            tbFurniID.Text = item.ID.ToString();
            tbFurniType.Text = item.BasicType == 0 ? "Floor Item" : "Wall Item";
            tbFurniMaxPrice.Text = item.MaxBuyPrice.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbBotOn.Toggled = false;
            Triggers.OutDetach(uItemInfo);
            Triggers.InDetach(uResponse);
        }

        public class Query
        {
            public string Value { get; set; }
            public int Hits { get; set; }

            public int MaxPrice { get; set; }
        }

        private void CbBotOn_ToggledChanged()
        {
            if (cbBotOn.Toggled)
            {
                BotOn = true;
                Triggers.InAttach(uResponse, IncomingMpResponse);

                List<Query> Combinations = new List<Query>();

                foreach (char x in AlphaNumerics)
                {
                    foreach (char y in AlphaNumerics)
                    {
                        foreach (char z in AlphaNumerics)
                        {
                            string combo = x.ToString() + y + z;
                            List<Furni> FurniFound = FurniToBuy.FindAll(o => o.NameTrimmed.Contains(combo));
                            int hits = 0;
                            int price = 0;
                            foreach (Furni furni in FurniFound)
                            {
                                int index = FurniToBuy.FindIndex(o => o == furni);
                                FurniToBuy[index].Queries.Add(combo);
                                hits++;
                                if(furni.MaxBuyPrice > price)
                                {
                                    price = furni.MaxBuyPrice;
                                }
                            }
                            Combinations.Add(new Query { Value = combo, Hits = hits, MaxPrice = price });
                        }
                    }
                }

                foreach (Furni furni in FurniToBuy)
                {
                    Query highest = new Query { Hits = 0, MaxPrice = 0 };
                    bool AddToList = true;
                    foreach (string query in furni.Queries)
                    {
                        if (Queries.Count(x => x.Value == query) > 0)
                        {
                            AddToList = false;
                            break;
                        }
                        else if (Combinations.Find(x => x.Value == query).Hits > highest.Hits)
                        {
                            highest = Combinations.Find(x => x.Value == query);
                        }
                    }
                    if (Queries.Count(x => x.Value == highest.Value) == 0 && AddToList)
                    {
                        Queries.Add(highest);
                    }
                }

                string text = string.Empty;

                foreach(Query q in Queries.OrderBy(x=> x.Hits))
                {
                    text += q.Value + "->" +  q.Hits + "->" + q.MaxPrice + Environment.NewLine;
                }
                //MessageBox.Show(text);
                monoFlat_ThemeContainer1.Text = string.Format("Sniper -> {0} Furni -> {1} Search Queries", FurniToBuy.Count, Queries.Count);
                DoMpSearch();
            }
            else
            {
                BotOn = false;
                Triggers.InDetach(uResponse);
            }
        }

        public async void BuyFromMp(int SaleId)
        {
            await Connection.SendToServerAsync(uBuy, SaleId);
        }
        private async Task DoMpSearch()
        {
            while (BotOn)
            {
                foreach (Query q in Queries)
                {
                    if (!BotOn)
                        goto exit;
                    await Task.Delay(500);
                    await Connection.SendToServerAsync(uSearch, -1, -1, q.Value, 1);
                }
            }
        exit:;
        }

        private async void IncomingMpResponse(DataInterceptedEventArgs e)
        {
            DoCheck(e);
            e.IsBlocked = true;
        }

        private Task DoCheck(DataInterceptedEventArgs e)
        {
            var results = HMarketplaceOffer.Parse(e.Packet);

            foreach (var item in results)
            {
                int index = FurniToBuy.FindIndex(x => x.ID == item.TypeId && x.BasicType == item.ItemType && x.MaxBuyPrice >= item.SalePrice);
                if (index > -1)
                {
                    BuyFromMp(item.SaleId);
                    lbPurchased.Invoke((MethodInvoker)(() => lbPurchased.Items.Add(item.SalePrice + "c -> " + FurniToBuy[index].Name)));
                    string text = "[" + DateTime.Now.ToString() + "] - " + FurniToBuy[index].Name + " -> " + item.SalePrice + "c!" + Environment.NewLine;
                    File.AppendAllText("Purchases.txt", text);
                }
            }
            return null;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBotOn.Toggled)
                {
                    MessageBox.Show("Please disable bot before importing!");
                    return;
                }
                OpenFileDialog ofd = new OpenFileDialog();

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    foreach(string line in lines)
                    {
                        if (line.Contains(","))
                        {
                            string[] parts = line.Split(',');
                            int furniId = int.Parse(parts[0]);
                            int basicType = int.Parse(parts[1]);
                            int price = int.Parse(parts[2]);
                            Furni Furni = FurniData.Find(x => x.ID == furniId && x.BasicType == basicType);
                            int index = FurniToBuy.FindIndex(x => x.ID == furniId && x.BasicType == basicType);
                            if (index > -1)
                            {
                                FurniToBuy[index].MaxBuyPrice = price;
                            }
                            else
                            {
                                Furni.MaxBuyPrice = price;
                                FurniToBuy.Add(Furni);
                            }
                        }
                    }
                    MessageBox.Show("Set " + FurniToBuy.Count + " furni to buy");
                    UpdateListBox();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string allText = string.Empty;
                foreach(Furni f in FurniToBuy)
                {
                    string text = f.ID + "," + f.BasicType + "," + f.MaxBuyPrice + Environment.NewLine;
                    allText += text;
                }
                File.WriteAllText("Export.txt", allText);
                MessageBox.Show("Exported items " + FurniToBuy.Count() + " to 'Export.txt'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (cbBotOn.Toggled)
            {
                MessageBox.Show("Please disable bot first!");
                return;
            }
            int basicType = tbFurniType.Text == "Floor Item" ? 0 : 1;
            int index = FurniToBuy.FindIndex(x => x.ID == int.Parse(tbFurniID.Text) && x.BasicType == basicType);
            if (index > -1)
            {
                FurniToBuy.RemoveAt(index);
                MessageBox.Show("Removed item from watch");
            }

            UpdateListBox();
        }

        private void MonoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {
           
        }

        private void mpPosted(DataInterceptedEventArgs obj)
        {
            obj.IsBlocked = true;
        }

        private void TbSearchFurni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbItems.Items.Clear();
                foreach(Furni item in FurniData.FindAll(x=> x.Name.ToLower().Contains(tbSearchFurni.Text.ToLower())))
                {
                    cbItems.Items.Add(item.ID + ":" + item.BasicType + ": -> " + item.Name);
                }
            }
            catch
            {

            }
        }

        private void CbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbItems.SelectedIndex > -1)
            {
                string[] parts =  cbItems.SelectedItem.ToString().Split(':');
                int id = int.Parse(parts[0]);
                int basicType = int.Parse(parts[1]);
                Furni furniSelected = FurniToBuy.Find(x=> x.ID == id && x.BasicType == basicType);

                if(furniSelected == null)
                {
                    furniSelected = FurniData.Find(x => x.ID == id && x.BasicType == basicType);
                }
                tbFurniName.Text = furniSelected.Name;
                tbFurniID.Text = furniSelected.ID.ToString();
                tbFurniType.Text = furniSelected.BasicType == 0 ? "Floor Item" : "Wall Item";
                tbFurniMaxPrice.Text = furniSelected.MaxBuyPrice.ToString();
            }
        }
    }

    public class Furni
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int SpecialType { get; set; }
        public string FurniLine { get; set; }
        public int BasicType { get; set; }
        public string NameTrimmed { get; set; }

        public int MaxBuyPrice = 0;

        public List<string> Queries = new List<string>();

        public int UniqueID { get; set; }
    }

}
