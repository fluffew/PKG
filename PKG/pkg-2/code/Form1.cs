using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKG_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            list = new List<string>();
            setTable();
            lvwColumnSorter = new ListViewColumnSorter();
            listView1.ListViewItemSorter = lvwColumnSorter;
        }
        private ListViewColumnSorter lvwColumnSorter;
        private string filePath = "D:";
        private List<string> list;

        private void button1_Click(object sender, EventArgs e)
        {
            if (list.IndexOf(filePath) >= 0)
            {
                filePath = textBox1.Text;
                list.Add(filePath);
            }
            loadFilesAndDirectories(filePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = filePath;
            list.Add(filePath);
            loadFilesAndDirectories(filePath);
        }

        private void setTable()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Name", 300);
            listView1.Columns.Add("Size", 100);
            listView1.Columns.Add("Resolution", 100);
            listView1.Columns.Add("Color depth", 100);
            listView1.Columns.Add("Compression", 100);
            for (int i = 1; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].TextAlign = HorizontalAlignment.Center;
            }
        }

        private Image createThumbnail(Image img)
        {
            if (img.Width <= img.Height)
            {
                return img.GetThumbnailImage(img.Width, img.Height, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero);
            }
            return img.GetThumbnailImage(img.Width, img.Height, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero);
        }

        private void loadFilesAndDirectories(string str)
        {
            
            DirectoryInfo fileList = new DirectoryInfo(str);
            FileInfo[] files = { };
            DirectoryInfo[] directories = { };
            try
            {
                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                files = fileList.GetFiles();
                directories = fileList.GetDirectories();

                removeAll();
                var curFiles = files.Where(item => item.Extension == ".jpg" ||
                item.Extension == ".gif" ||
                item.Extension == ".tif" ||
                item.Extension == ".bmp" ||
                item.Extension == ".png" ||
                item.Extension == ".pcx").Select(item => item).ToArray();
                for (int i = 0; i < directories.Length; i++)
                {
                    add(directories[i]);
                }
                for (int i = 0; i < curFiles.Length; i++)
                {
                    add(curFiles[i]);
                }
                watch.Stop();
                textBox2.Text = watch.Elapsed.TotalMilliseconds.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", "The path is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                list.Remove(list.ElementAt(list.Count - 1));
                textBox1.Text = list.ElementAt(list.Count - 1);
            }
        }

        private void add(FileInfo info)
        {
            Image img = Image.FromFile(info.FullName);
            string str = img.PixelFormat.ToString();
            String[] row = { info.Name, img.Width + "x" + img.Height, img.HorizontalResolution.ToString(), str[6..^6], compressionAlgorithm(info.Extension) };
            imageList1.Images.Add(createThumbnail(img));
            ListViewItem lv = new ListViewItem(row, 0);
            listView1.Items.Add(lv);
            listView1.Items[listView1.Items.Count - 1].ImageIndex = listView1.Items.Count;
            listView1.SmallImageList = imageList1;
        }

        private string compressionAlgorithm(string type)
        {
            switch (type)
            {
                case ".bmp":
                    {
                        return "RLE";
                    }
                case ".png":
                    {
                        return "Deflate";
                    }
                case ".gif":
                    {
                        return "LZW";
                    }
                case ".jpeg":
                    {
                        return "JPEG";
                    }
                case ".tiff":
                    {
                        return "ZIP/LZW/JPEG";
                    }
                default:
                    {
                        return "-";
                    }
            }
        }
        private void add(DirectoryInfo info)
        {
            String[] row = { info.Name };
            ListViewItem lv = new ListViewItem(row, 0);
            listView1.Items.Add(lv);
            listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;
            listView1.SmallImageList = imageList1;
        }
        private void removeAll()
        {
            listView1.Items.Clear();
            var imglist = imageList1;
            imageList1 = new ImageList();
            imageList1.Images.Add(imglist.Images[0]);
            imageList1.Images.Add(imglist.Images[1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int ind = list.IndexOf(textBox1.Text);
            if (ind >= 1)
            {
                removeAll();
                filePath = list.ElementAt(ind - 1);
                list.Remove(textBox1.Text);
                textBox1.Text = filePath;
                loadFilesAndDirectories(filePath);
                
            }

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1 && !listView1.SelectedItems[0].Text.Contains('.')) {
                textBox1.Text += "\\" + listView1.SelectedItems[0].Text;
                    filePath = textBox1.Text;
                    list.Add(filePath);
                loadFilesAndDirectories(filePath);
                textBox1.Text = filePath;
            }
        }
    }
}