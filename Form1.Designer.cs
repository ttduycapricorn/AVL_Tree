namespace AVL_Tree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd_Node = new System.Windows.Forms.Button();
            this.labelX5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete_Node = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate_Node = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.domNumberNode = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnThongtin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1357, 671);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw AVL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1345, 637);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(336, 33);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(128, 42);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd_Node
            // 
            this.btnAdd_Node.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd_Node.Location = new System.Drawing.Point(170, 93);
            this.btnAdd_Node.Name = "btnAdd_Node";
            this.btnAdd_Node.Size = new System.Drawing.Size(128, 76);
            this.btnAdd_Node.TabIndex = 3;
            this.btnAdd_Node.Text = "Add Node";
            this.btnAdd_Node.UseVisualStyleBackColor = false;
            this.btnAdd_Node.Click += new System.EventHandler(this.btnAdd_Node_Click);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(320, 108);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(47, 20);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Node Value:";
            // 
            // btnDelete_Node
            // 
            this.btnDelete_Node.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete_Node.Location = new System.Drawing.Point(336, 93);
            this.btnDelete_Node.Name = "btnDelete_Node";
            this.btnDelete_Node.Size = new System.Drawing.Size(128, 76);
            this.btnDelete_Node.TabIndex = 6;
            this.btnDelete_Node.Text = "Delete Node";
            this.btnDelete_Node.UseVisualStyleBackColor = false;
            this.btnDelete_Node.Click += new System.EventHandler(this.btnDelete_Node_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(448, 26);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(48, 26);
            this.txtHeight.TabIndex = 11;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tree\'s Height:";
            // 
            // btnCreate_Node
            // 
            this.btnCreate_Node.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreate_Node.Location = new System.Drawing.Point(17, 93);
            this.btnCreate_Node.Name = "btnCreate_Node";
            this.btnCreate_Node.Size = new System.Drawing.Size(128, 76);
            this.btnCreate_Node.TabIndex = 2;
            this.btnCreate_Node.Text = "Create Node";
            this.btnCreate_Node.UseVisualStyleBackColor = false;
            this.btnCreate_Node.Click += new System.EventHandler(this.btnCreate_Node_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(21, 93);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(123, 76);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1240, 867);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "execution time:";
            // 
            // domNumberNode
            // 
            this.domNumberNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domNumberNode.Items.Add("1");
            this.domNumberNode.Items.Add("2");
            this.domNumberNode.Items.Add("3");
            this.domNumberNode.Items.Add("4");
            this.domNumberNode.Items.Add("5");
            this.domNumberNode.Items.Add("6");
            this.domNumberNode.Items.Add("7");
            this.domNumberNode.Items.Add("8");
            this.domNumberNode.Items.Add("9");
            this.domNumberNode.Items.Add("10");
            this.domNumberNode.Items.Add("11");
            this.domNumberNode.Items.Add("12");
            this.domNumberNode.Items.Add("13");
            this.domNumberNode.Items.Add("14");
            this.domNumberNode.Items.Add("15");
            this.domNumberNode.Items.Add("16");
            this.domNumberNode.Items.Add("17");
            this.domNumberNode.Items.Add("18");
            this.domNumberNode.Items.Add("19");
            this.domNumberNode.Items.Add("20");
            this.domNumberNode.Location = new System.Drawing.Point(215, 23);
            this.domNumberNode.Name = "domNumberNode";
            this.domNumberNode.ReadOnly = true;
            this.domNumberNode.Size = new System.Drawing.Size(89, 26);
            this.domNumberNode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số Node cần random:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Location = new System.Drawing.Point(487, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 76);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search Node ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnDelete_Node);
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Controls.Add(this.btnAdd_Node);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCreate_Node);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 728);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 190);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity Tree";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btnReadFile);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.labelX5);
            this.groupBox3.Controls.Add(this.domNumberNode);
            this.groupBox3.Controls.Add(this.txtHeight);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnRandom);
            this.groupBox3.Location = new System.Drawing.Point(671, 728);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(171, 93);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(123, 76);
            this.btnReadFile.TabIndex = 19;
            this.btnReadFile.Text = "Read FIle";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnThongtin
            // 
            this.btnThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongtin.Location = new System.Drawing.Point(1240, 810);
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.Size = new System.Drawing.Size(123, 45);
            this.btnThongtin.TabIndex = 21;
            this.btnThongtin.Text = "Hướng dẫn";
            this.btnThongtin.UseVisualStyleBackColor = true;
            this.btnThongtin.Click += new System.EventHandler(this.btnThongtin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(164, 689);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1064, 26);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 692);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Danh sách Node";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1379, 911);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnThongtin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVL Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd_Node;
        private System.Windows.Forms.Label labelX5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete_Node;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate_Node;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domNumberNode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnThongtin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

