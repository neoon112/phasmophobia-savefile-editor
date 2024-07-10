namespace Phasmo_Savefile_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            encryptBtn = new Button();
            decryptBtn = new Button();
            panel1 = new Panel();
            minimiseBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            textboxContextMenu = new ContextMenuStrip(components);
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            linkLabel1 = new LinkLabel();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            textboxContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.BackColor = Color.FromArgb(33, 33, 33);
            encryptBtn.Cursor = Cursors.Hand;
            encryptBtn.FlatAppearance.BorderSize = 0;
            encryptBtn.FlatStyle = FlatStyle.Flat;
            encryptBtn.Font = new Font("Segoe UI", 12F);
            encryptBtn.ForeColor = SystemColors.Control;
            encryptBtn.Location = new Point(23, 398);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(112, 40);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = false;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.BackColor = Color.FromArgb(33, 33, 33);
            decryptBtn.Cursor = Cursors.Hand;
            decryptBtn.FlatAppearance.BorderSize = 0;
            decryptBtn.FlatStyle = FlatStyle.Flat;
            decryptBtn.Font = new Font("Segoe UI", 12F);
            decryptBtn.ForeColor = SystemColors.Control;
            decryptBtn.Location = new Point(141, 398);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(112, 40);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = false;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 27, 27);
            panel1.Controls.Add(minimiseBtn);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 51);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // minimiseBtn
            // 
            minimiseBtn.Cursor = Cursors.Hand;
            minimiseBtn.FlatAppearance.BorderSize = 0;
            minimiseBtn.FlatStyle = FlatStyle.Flat;
            minimiseBtn.ForeColor = SystemColors.Control;
            minimiseBtn.Location = new Point(447, 18);
            minimiseBtn.Name = "minimiseBtn";
            minimiseBtn.Size = new Size(26, 26);
            minimiseBtn.TabIndex = 1;
            minimiseBtn.Text = "-";
            minimiseBtn.UseVisualStyleBackColor = true;
            minimiseBtn.Click += minimiseBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = SystemColors.Control;
            exitBtn.Location = new Point(470, 18);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(26, 26);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 0;
            label1.Text = "Phasmophobia SaveFile Editor";
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // textboxContextMenu
            // 
            textboxContextMenu.BackColor = Color.FromArgb(23, 23, 23);
            textboxContextMenu.DropShadowEnabled = false;
            textboxContextMenu.ImeMode = ImeMode.Disable;
            textboxContextMenu.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem2, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem, toolStripMenuItem3, findToolStripMenuItem });
            textboxContextMenu.Name = "contextMenuStrip1";
            textboxContextMenu.Size = new Size(175, 202);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.BackColor = Color.FromArgb(27, 27, 27);
            undoToolStripMenuItem.ForeColor = SystemColors.Control;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(174, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.BackColor = Color.FromArgb(27, 27, 27);
            redoToolStripMenuItem.ForeColor = SystemColors.Control;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            redoToolStripMenuItem.Size = new Size(174, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.FromArgb(27, 27, 27);
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(174, 22);
            toolStripMenuItem2.Text = " ";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.BackColor = Color.FromArgb(27, 27, 27);
            cutToolStripMenuItem.ForeColor = SystemColors.Control;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(174, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.BackColor = Color.FromArgb(28, 28, 28);
            copyToolStripMenuItem.ForeColor = SystemColors.Control;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(174, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.BackColor = Color.FromArgb(28, 28, 28);
            pasteToolStripMenuItem.ForeColor = SystemColors.Control;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(174, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.BackColor = Color.FromArgb(27, 27, 27);
            selectAllToolStripMenuItem.ForeColor = SystemColors.Control;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(174, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.FromArgb(27, 27, 27);
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(174, 22);
            toolStripMenuItem3.Text = " ";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.BackColor = Color.FromArgb(27, 27, 27);
            findToolStripMenuItem.ForeColor = SystemColors.Control;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.Size = new Size(174, 22);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(35, 35, 185);
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkColor = Color.FromArgb(35, 35, 150);
            linkLabel1.Location = new Point(350, 443);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(150, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Scratchamophobia.com.au";
            linkLabel1.VisitedLinkColor = Color.FromArgb(35, 35, 150);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(33, 33, 33);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ContextMenuStrip = textboxContextMenu;
            richTextBox1.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(12, 59);
            richTextBox1.Size = new Size(488, 306);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(512, 467);
            Controls.Add(richTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(decryptBtn);
            Controls.Add(encryptBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Phasmophobia Savefile Editor";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            textboxContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptBtn;
        private Button decryptBtn;
        private Panel panel1;
        private Button minimiseBtn;
        private Button exitBtn;
        private Label label1;
        private ContextMenuStrip textboxContextMenu;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private LinkLabel linkLabel1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem findToolStripMenuItem;
    }
}
