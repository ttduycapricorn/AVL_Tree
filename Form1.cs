using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows.Markup;

namespace AVL_Tree
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graph;
        TreeAVL tree;
        Node selectNode;
        DrawTreeAVL draw;
        Stopwatch sw;
        public Label[] lb;
        List<int> listvalue = new List<int>();

        public int[] KeyArr;        // Mang chua cac key cua cay
        public float[,] PosArr, PosArr2;
        public int n;              // So phan tu cua mang 
        public int r = 16;
        public int R = 16;
        int value;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            graph = Graphics.FromImage(bitmap);
            graph.CompositingQuality = CompositingQuality.HighQuality;
            pictureBox1.Image = bitmap;
            pictureBox1.Show();
            draw = new DrawTreeAVL();
            //groupPanel2.Enabled = false;
        }

        public void GetPos()
        {
            tree.root.x = pictureBox1.Width / 2;
            tree.root.y = 45;
            tree.root.Father = pictureBox1.Width;
            tree.root.GetPos(tree.root.pLeft, this);
            tree.root.GetPos(tree.root.pRight, this);
        }

        public void UpdateDel(int delKey)
        {
            int[] newArr = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                if (KeyArr[i] != delKey)
                    newArr[i] = KeyArr[i];
            }
            KeyArr = new int[--n];
            KeyArr = newArr;
        }

        public void LoadPos(Node root, float[,] PosArr)
        {
            for (int j = 0; j < KeyArr.Length; j++)
            {
                if (root.key == (int)PosArr[j, 0])
                {
                    root.x = PosArr[j, 1]; root.y = PosArr[j, 2]; //root.Father = PosArr[j, 3];
                    break;
                }
            }
            if (root.pLeft != null)
                LoadPos(root.pLeft, PosArr);
            if (root.pRight != null)
                LoadPos(root.pRight, PosArr);
        }
        public void UpdateAdd(int value)
        {
            n++;
            int[] newArr = new int[n];
            for (int i = 0; i < n - 1; i++)
                newArr[i] = KeyArr[i];
            newArr[n - 1] = value;
            KeyArr = new int[n];
            KeyArr = newArr;
        }

        public void SavePos(Node root, float[,] PosArr, ref int i)
        {
            if (root != null)
            {
                PosArr[i, 0] = (float)root.key; PosArr[i, 1] = root.x; PosArr[i, 2] = root.y; PosArr[i++, 3] = root.Father;
                if (root.pLeft != null)
                    SavePos(root.pLeft, PosArr, ref i);
                if (root.pRight != null)
                    SavePos(root.pRight, PosArr, ref i);
            }
        }
        private void btnAdd_Node_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new Stopwatch();
                sw.Start();
                int value = Convert.ToInt32(txtValue.Text.ToString());
                listvalue.Add(value);
                //textBox1.Text = textBox1.Text + "   " + value;
                if (tree == null)
                {
                    tree = new TreeAVL();
                    tree.insertNode(ref tree.root, value, tree, draw, graph, bitmap, this);
                    UpdateAdd(value);

                    tree.root.x = pictureBox1.Width / 2;
                    tree.root.y = 45;
                    tree.root.Father = pictureBox1.Width;

                    graph.SmoothingMode = SmoothingMode.HighQuality;
                    float x = 15, y = 45;
                    draw.DrawNode(value, 15, 45, graph, bitmap, this);
                    pictureBox1.Image = bitmap;
                    while (x < (pictureBox1.Width / 2))
                    {
                        x += 2; if (x > pictureBox1.Width / 2) x = pictureBox1.Width / 2;

                        graph.Clear(Color.Honeydew);
                        draw.DrawNode(value, x, y, graph, bitmap, this);
                        Thread.Sleep(1);
                        Application.DoEvents();
                        pictureBox1.Image = bitmap;
                    }

                    graph.Clear(Color.Honeydew);
                    draw.DrawTree(tree, graph, bitmap, this);
                    pictureBox1.Image = bitmap;

                    selectNode = tree.root;
                    draw.DrawSelectNode_1(selectNode, graph, bitmap, this);
                    pictureBox1.Image = bitmap;

                    MessageBox.Show("Add Successful", "Message");
                    txtValue.Clear();
                }
                else
                {
                    selectNode = tree.root;
                    int i = 0;
                    float[,] PosArr = new float[KeyArr.Length + 1, 4];
                    SavePos(tree.root, PosArr, ref i);

                    int k = tree.insertNode(ref tree.root, value, tree, draw, graph, bitmap, this);

                    PosArr[i, 0] = (float)value; PosArr[i, 1] = tree.xAdd; PosArr[i, 2] = tree.yAdd; PosArr[i++, 3] = tree.xFatherAdd;

                    float[,] PosArr2 = new float[KeyArr.Length + 1, 4];
                    if (k != 0)
                    {
                        UpdateAdd(value);

                        tree.root.x = pictureBox1.Width / 2;
                        tree.root.y = 45;
                        tree.root.Father = pictureBox1.Width;
                        tree.root.GetPos(tree.root.pLeft, this);
                        tree.root.GetPos(tree.root.pRight, this);

                        i = 0;
                        SavePos(tree.root, PosArr2, ref i);
                        LoadPos(tree.root, PosArr);

                        draw.MoveNode(ref tree, PosArr2, graph, bitmap, this);

                        MessageBox.Show("Add Successful", "Message");
                        txtValue.Clear();
                    }
                    else
                        MessageBox.Show("Node has existed, Please!!! Add Another Value Node ", "Message");

                    graph.Clear(Color.Honeydew);
                    draw.DrawTree(tree, graph, bitmap, this);
                    pictureBox1.Image = bitmap;

                    selectNode = tree.root;
                    //draw.DrawSelectNode(selectNode, graph, bitmap, this);
                    pictureBox1.Image = bitmap;
                    txtValue.Clear();
                }
                sw.Stop();
                labelX5.Text = sw.Elapsed.ToString();
                txtHeight.Text = tree.Get_Height(ref tree.root).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error add Node!", "Error");
                txtValue.Clear();
            }
        }

        private void Delete(int value)
        {
            //string s = textBox1.Text;
            //textBox1.Text = s.Replace(textBox1.Text, " ");
            PosArr = new float[KeyArr.Length, 4];
            int i = 0;
            SavePos(tree.root, PosArr, ref i);
            draw.DrawNode(value, tree.root.x, tree.root.y, graph, bitmap, this);

            tree.delNode(ref tree.root, value, tree, draw, graph, bitmap, this);

            UpdateDel(value);

            if (tree.root == null)
            {
                graph.Clear(Color.Honeydew);
                pictureBox1.Image = bitmap;
            }
            else
            {

                GetPos();

                PosArr2 = new float[KeyArr.Length, 4]; i = 0;
                SavePos(tree.root, PosArr2, ref i);
                LoadPos(tree.root, PosArr);

                draw.MoveNode(ref tree, PosArr2, graph, bitmap, this);

                graph.Clear(Color.Honeydew);
                draw.DrawTree(tree, graph, bitmap, this);

                selectNode = tree.root;
                draw.DrawSelectNode_1(selectNode, graph, bitmap, this);
                pictureBox1.Image = bitmap;
                //MessageBox.Show("Delete Successful", "Message");
            }
        }
        private void CreateNode()
        {
            value = Convert.ToInt32(txtValue.Text.ToString());
            //textBox1.Text = textBox1.Text + "     " + value;
            listvalue.Add(value);
            if (tree == null)
            {
                tree = new TreeAVL();
                tree.insertNode(ref tree.root, value, tree, draw, graph, bitmap, this);
                UpdateAdd(value);

                tree.root.x = pictureBox1.Width / 2;
                tree.root.y = 45;
                tree.root.Father = pictureBox1.Width;

                graph.SmoothingMode = SmoothingMode.HighQuality;
                float x = 15, y = 45;
                draw.DrawNode(value, 15, 45, graph, bitmap, this);
                pictureBox1.Image = bitmap;
                while (x < (pictureBox1.Width / 2))
                {
                    x += 2; if (x > pictureBox1.Width / 2) x = pictureBox1.Width / 2;

                    graph.Clear(Color.Honeydew);
                    draw.DrawNode(value, x, y, graph, bitmap, this);
                    Thread.Sleep(1);
                    Application.DoEvents();
                    pictureBox1.Image = bitmap;
                }

                graph.Clear(Color.Honeydew);
                draw.DrawTree(tree, graph, bitmap, this);
                pictureBox1.Image = bitmap;

                selectNode = tree.root;
                draw.DrawSelectNode_1(selectNode, graph, bitmap, this);
                pictureBox1.Image = bitmap;
            }
            else
            {
                selectNode = tree.root;
                int i = 0;
                float[,] PosArr = new float[KeyArr.Length + 1, 4];
                SavePos(tree.root, PosArr, ref i);

                int k = tree.insertNode(ref tree.root, value, tree, draw, graph, bitmap, this);

                PosArr[i, 0] = (float)value; PosArr[i, 1] = tree.xAdd; PosArr[i, 2] = tree.yAdd; PosArr[i++, 3] = tree.xFatherAdd;

                float[,] PosArr2 = new float[KeyArr.Length + 1, 4];

                if (k != 0)
                {
                    UpdateAdd(value);

                    GetPos();

                    i = 0;
                    SavePos(tree.root, PosArr2, ref i);
                    LoadPos(tree.root, PosArr);

                    draw.MoveNode(ref tree, PosArr2, graph, bitmap, this);
                }

                graph.Clear(Color.Honeydew);
                draw.DrawTree(tree, graph, bitmap, this);
                pictureBox1.Image = bitmap;

                selectNode = tree.root;
                //draw.DrawSelectNode(selectNode, graph, bitmap, this);
                pictureBox1.Image = bitmap;

            }
            //}
            //textBox1.Text = "";
        }

        private void btnCreate_Node_Click(object sender, EventArgs e)
        {
            try
            {
             sw = new Stopwatch();
             sw.Start();
             CreateNode();
             sw.Stop();
             labelX5.Text = sw.Elapsed.ToString();
                MessageBox.Show("Create successful!", "Message");
                txtHeight.Text = tree.Get_Height(ref tree.root).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error create Node!", "Error");
            }
            txtValue.Clear();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new Stopwatch();
                sw.Start();
                int n = Convert.ToInt32(domNumberNode.Text.ToString());
                Random r = new Random();
                for (int j = 0; j < n; j++)
                {
                    int addKey = r.Next(99);
                    listvalue.Add(addKey);
                    if (tree == null)
                    {
                        tree = new TreeAVL();
                        tree.insertNode(ref tree.root, addKey, tree, draw, graph, bitmap, this);
                        UpdateAdd(addKey);

                        tree.root.x = pictureBox1.Width / 2;
                        tree.root.y = 45;
                        tree.root.Father = pictureBox1.Width;

                        graph.SmoothingMode = SmoothingMode.HighQuality;
                        float x = 15, y = 45;
                        draw.DrawNode(addKey, 15, 45, graph, bitmap, this);
                        pictureBox1.Image = bitmap;
                        while (x < (pictureBox1.Width / 2))
                        {
                            x += 2; if (x > pictureBox1.Width / 2) x = pictureBox1.Width / 2;

                            graph.Clear(Color.Honeydew);
                            draw.DrawNode(addKey, x, y, graph, bitmap, this);
                            Thread.Sleep(1);
                            Application.DoEvents();
                            pictureBox1.Image = bitmap;
                        }

                        graph.Clear(Color.Honeydew);
                        draw.DrawTree(tree, graph, bitmap, this);
                        pictureBox1.Image = bitmap;

                        selectNode = tree.root;
                        draw.DrawSelectNode(selectNode, graph, bitmap, this);
                        pictureBox1.Image = bitmap;
                        txtHeight.Text = tree.Get_Height(ref tree.root).ToString();
                    }
                    else
                    {
                        selectNode = tree.root;
                        int i = 0;
                        float[,] PosArr = new float[KeyArr.Length + 1, 4];
                        SavePos(tree.root, PosArr, ref i);

                        int k = tree.insertNode(ref tree.root, addKey, tree, draw, graph, bitmap, this);

                        PosArr[i, 0] = (float)addKey; PosArr[i, 1] = tree.xAdd; PosArr[i, 2] = tree.yAdd; PosArr[i++, 3] = tree.xFatherAdd;

                        float[,] PosArr2 = new float[KeyArr.Length + 1, 4];
                        txtHeight.Text = tree.Get_Height(ref tree.root).ToString();

                        if (k != 0)
                        {
                            UpdateAdd(addKey);

                            GetPos();

                            i = 0;
                            SavePos(tree.root, PosArr2, ref i);
                            LoadPos(tree.root, PosArr);

                            draw.MoveNode(ref tree, PosArr2, graph, bitmap, this);
                        }

                        graph.Clear(Color.Honeydew);
                        draw.DrawTree(tree, graph, bitmap, this);
                        pictureBox1.Image = bitmap;

                        selectNode = tree.root;
                        draw.DrawSelectNode_1(selectNode, graph, bitmap, this);
                        pictureBox1.Image = bitmap;
                        txtHeight.Text = tree.Get_Height(ref tree.root).ToString();
                    }
                    //textBox1.Text = textBox1.Text + "   " + addKey.ToString();
                }
                sw.Stop();
                labelX5.Text = sw.Elapsed.ToString();
                MessageBox.Show("Complete random!", "Message");
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Random function execution error!" +ex.Message, "Error");
            }
        }

            private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new Stopwatch();
                sw.Start();
                value = Convert.ToInt32(txtValue.Text.ToString());
                draw.DrawNode(value, tree.root.x, tree.root.y, graph, bitmap, this);
                Node p = tree.SearchNode(value, tree.root, graph, bitmap, draw, tree, this);
                graph.Clear(Color.Honeydew);
                draw.DrawTree(tree, graph, bitmap, this);
                pictureBox1.Image = bitmap;

                if (p == null)
                {
                    selectNode = tree.root;
                    Thread.Sleep(500);
                    MessageBox.Show("Node Không tồn tại!", "Message");
                    draw.DrawSelectNode(tree.root, graph, bitmap, this);
                }
                else
                {
                    tree = new TreeAVL();
                    tree.HieuUng(p, draw, graph, bitmap, this);
                    selectNode = tree.root;
                    Thread.Sleep(500);
                    MessageBox.Show("Đã tìm thấy Node!", "Message");
                    //pictureBox1.Image = bitmap;
                }
                sw.Stop();
                labelX5.Text = sw.Elapsed.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện chức năng!" + ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\cay_2.txt",  FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                string soluong = sr.ReadLine();
                int n = Convert.ToInt32(soluong);
                for(int u=0; u<n; u++) {
                    sw = new Stopwatch();
                    sw.Start();
                    string giatri = sr.ReadLine();
                    int value = Convert.ToInt32(giatri);
                    
                    textBox1.Text =  textBox1.Text + "      " + value.ToString();
                    listvalue.Add(value);
                    //textBox1.Text = textBox1.Text + "   " + value;
                    if (tree == null)
                    {
                        tree = new TreeAVL();
                        tree.insertNode(ref tree.root, value, tree, draw, graph, bitmap, this);
                        UpdateAdd(value);
                       
                        tree.root.x = pictureBox1.Width / 2;
                        tree.root.y = 45;
                        tree.root.Father = pictureBox1.Width;

                        graph.SmoothingMode = SmoothingMode.HighQuality;
                        float x = 15, y = 45;
                        draw.DrawNode(value, 15, 45, graph, bitmap, this);
                        pictureBox1.Image = bitmap;
                        while (x < (pictureBox1.Width / 2))
                        {
                            x += 2; if (x > pictureBox1.Width / 2) x = pictureBox1.Width / 2;

                            graph.Clear(Color.Honeydew);
                            draw.DrawNode(value, x, y, graph, bitmap, this);
                            Thread.Sleep(1);
                            Application.DoEvents();
                            pictureBox1.Image = bitmap;
                        }

                        graph.Clear(Color.Honeydew);
                        draw.DrawTree(tree, graph, bitmap, this);
                        pictureBox1.Image = bitmap;

                        selectNode = tree.root;
                        draw.DrawSelectNode_1(selectNode, graph, bitmap, this);
                        pictureBox1.Image = bitmap;

                        //MessageBox.Show("Add Successful", "Message");
                        txtValue.Clear();
                    }
                    else
                    {
                        selectNode = tree.root;
                        int i = 0;
                        float[,] PosArr = new float[KeyArr.Length + 1, 4];
                        SavePos(tree.root, PosArr, ref i);

                        int k = tree.insertNode(ref tree.root, value, tree, draw, graph, bitmap, this);

                        PosArr[i, 0] = (float)value; PosArr[i, 1] = tree.xAdd; PosArr[i, 2] = tree.yAdd; PosArr[i++, 3] = tree.xFatherAdd;

                        float[,] PosArr2 = new float[KeyArr.Length + 1, 4];
                        if (k != 0)
                        {
                            UpdateAdd(value);

                            tree.root.x = pictureBox1.Width / 2;
                            tree.root.y = 45;
                            tree.root.Father = pictureBox1.Width;
                            tree.root.GetPos(tree.root.pLeft, this);
                            tree.root.GetPos(tree.root.pRight, this);

                            i = 0;
                            SavePos(tree.root, PosArr2, ref i);
                            LoadPos(tree.root, PosArr);

                            draw.MoveNode(ref tree, PosArr2, graph, bitmap, this);

                            //MessageBox.Show("Add Successful", "Message");
                            txtValue.Clear();
                        }
                        else
                            //MessageBox.Show("Node has existed, Please!!! Add Another Value Node ", "Message");

                            graph.Clear(Color.Honeydew);
                        draw.DrawTree(tree, graph, bitmap, this);
                        pictureBox1.Image = bitmap;

                        selectNode = tree.root;
                        //draw.DrawSelectNode(selectNode, graph, bitmap, this);
                        pictureBox1.Image = bitmap;
                        txtValue.Clear();
                    }
               
                    sw.Stop();
                    labelX5.Text = sw.Elapsed.ToString();
                    txtHeight.Text = tree.Get_Height(ref tree.root).ToString();
                }
                sr.Close();
                MessageBox.Show("Read File successful!", "Message");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Read File! " + ex.Message, "Message");
            }
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Nếu muốn tạo Node mới thì chúng ta nhập giá trị Node vào \ntrong textBox 'Node Value' và nhấn vào button 'Create Node' hoặc button 'Add Node'.\n\n" +
                            "- Nếu muốn xóa 1 Node trong cây thì cũng nhập giá trí vào trong textbox 'Node Value' và nhấn button 'Delete Node'\n\n" +
                            "- Nếu muốn tìm 1 Node trong cây thì cũng nhập giá trí vào trong textbox 'Node Value' và nhấn button 'Search Node'\n\n" +
                            "- Nếu muốn Random Node thì ta nhập số lượng Node vào trong Numneric updown 'Số Node cần random' và nhấn button 'Search Node'\n\n" +
                            "- Lưu ý: nếu muốn search Node thêm nữa thì phải tạo ra cây mới bằng cách chọn chức năng thêm Node hoặc tạo Node mới cho cây");
        }

        private void btnDelete_Node_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new Stopwatch();
                sw.Start();
                int value_delete = Convert.ToInt32(txtValue.Text.ToString());
                Delete(value_delete);
                sw.Stop();
                labelX5.Text = sw.Elapsed.ToString();
                //txtValue_delete.Clear();
                txtHeight.Text = tree.Get_Height(ref tree.root).ToString();
                MessageBox.Show("Delete Succesful!", "Message");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xóa Node", "Error");
            }
            txtValue.Clear();
        }
    }
}
