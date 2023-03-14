namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Windows Mail");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Windows ", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("System32");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Program Files", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Диск C", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Labs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("UGATU", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("VisualStudio", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Everything");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Programs", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Диск D", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHover = new System.Windows.Forms.Button();
            this.btnPress = new System.Windows.Forms.Button();
            this.btnMsg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFirstImg = new System.Windows.Forms.RadioButton();
            this.rbSecondImg = new System.Windows.Forms.RadioButton();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelTrackBar = new System.Windows.Forms.Label();
            this.FirstImg = new System.Windows.Forms.PictureBox();
            this.btnClearLable = new System.Windows.Forms.Button();
            this.btnAddNewBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.btnTimerMode = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerPrgrsBar = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnShowTree = new System.Windows.Forms.Button();
            this.btnHideTree = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHover
            // 
            this.btnHover.Location = new System.Drawing.Point(12, 68);
            this.btnHover.Name = "btnHover";
            this.btnHover.Size = new System.Drawing.Size(120, 50);
            this.btnHover.TabIndex = 0;
            this.btnHover.Text = "Наведи на меня";
            this.btnHover.UseVisualStyleBackColor = true;
            this.btnHover.MouseLeave += new System.EventHandler(this.btnHover_MouseLeave);
            this.btnHover.MouseHover += new System.EventHandler(this.btnHover_MouseHover);
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(12, 12);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(120, 50);
            this.btnPress.TabIndex = 1;
            this.btnPress.Text = "Нажми на меня";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // btnMsg
            // 
            this.btnMsg.Location = new System.Drawing.Point(12, 415);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(120, 23);
            this.btnMsg.TabIndex = 2;
            this.btnMsg.Text = "Message";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(651, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbFirstImg
            // 
            this.rbFirstImg.AutoSize = true;
            this.rbFirstImg.Location = new System.Drawing.Point(12, 206);
            this.rbFirstImg.Name = "rbFirstImg";
            this.rbFirstImg.Size = new System.Drawing.Size(75, 17);
            this.rbFirstImg.TabIndex = 7;
            this.rbFirstImg.TabStop = true;
            this.rbFirstImg.Text = "First image";
            this.rbFirstImg.UseVisualStyleBackColor = true;
            this.rbFirstImg.CheckedChanged += new System.EventHandler(this.rbFirstImg_CheckedChanged);
            // 
            // rbSecondImg
            // 
            this.rbSecondImg.AutoSize = true;
            this.rbSecondImg.Location = new System.Drawing.Point(12, 229);
            this.rbSecondImg.Name = "rbSecondImg";
            this.rbSecondImg.Size = new System.Drawing.Size(93, 17);
            this.rbSecondImg.TabIndex = 8;
            this.rbSecondImg.TabStop = true;
            this.rbSecondImg.Text = "Second image";
            this.rbSecondImg.UseVisualStyleBackColor = true;
            this.rbSecondImg.CheckedChanged += new System.EventHandler(this.rbSecondImg_CheckedChanged);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(318, 12);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(149, 45);
            this.trackBar.TabIndex = 9;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labelTrackBar
            // 
            this.labelTrackBar.AutoSize = true;
            this.labelTrackBar.Location = new System.Drawing.Point(336, 49);
            this.labelTrackBar.Name = "labelTrackBar";
            this.labelTrackBar.Size = new System.Drawing.Size(0, 13);
            this.labelTrackBar.TabIndex = 10;
            // 
            // FirstImg
            // 
            this.FirstImg.Location = new System.Drawing.Point(12, 252);
            this.FirstImg.Name = "FirstImg";
            this.FirstImg.Size = new System.Drawing.Size(181, 157);
            this.FirstImg.TabIndex = 11;
            this.FirstImg.TabStop = false;
            // 
            // btnClearLable
            // 
            this.btnClearLable.Location = new System.Drawing.Point(651, 68);
            this.btnClearLable.Name = "btnClearLable";
            this.btnClearLable.Size = new System.Drawing.Size(137, 23);
            this.btnClearLable.TabIndex = 12;
            this.btnClearLable.Text = "Clear";
            this.btnClearLable.UseVisualStyleBackColor = true;
            this.btnClearLable.Click += new System.EventHandler(this.btnClearLable_Click);
            // 
            // btnAddNewBtn
            // 
            this.btnAddNewBtn.Location = new System.Drawing.Point(651, 122);
            this.btnAddNewBtn.Name = "btnAddNewBtn";
            this.btnAddNewBtn.Size = new System.Drawing.Size(137, 41);
            this.btnAddNewBtn.TabIndex = 13;
            this.btnAddNewBtn.Text = "Add new Button";
            this.btnAddNewBtn.UseVisualStyleBackColor = true;
            this.btnAddNewBtn.Click += new System.EventHandler(this.btnAddNewBtn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTimer.Location = new System.Drawing.Point(647, 350);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(48, 20);
            this.labelTimer.TabIndex = 14;
            this.labelTimer.Text = "Timer";
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // btnTimerMode
            // 
            this.btnTimerMode.Location = new System.Drawing.Point(651, 399);
            this.btnTimerMode.Name = "btnTimerMode";
            this.btnTimerMode.Size = new System.Drawing.Size(137, 39);
            this.btnTimerMode.TabIndex = 15;
            this.btnTimerMode.Text = "Start / Stop";
            this.btnTimerMode.UseVisualStyleBackColor = true;
            this.btnTimerMode.Click += new System.EventHandler(this.btnTimerMode_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(651, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(328, 386);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(149, 23);
            this.progressBar.TabIndex = 17;
            // 
            // timerPrgrsBar
            // 
            this.timerPrgrsBar.Tick += new System.EventHandler(this.timerPrgrsBar_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Click!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(301, 92);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Узел11";
            treeNode1.Text = "Windows Mail";
            treeNode2.Name = "Узел8";
            treeNode2.Text = "Windows ";
            treeNode3.Name = "Узел10";
            treeNode3.Text = "System32";
            treeNode4.Name = "Узел9";
            treeNode4.Text = "Program Files";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Диск C";
            treeNode6.Name = "Узел14";
            treeNode6.Text = "Labs";
            treeNode7.Name = "Узел13";
            treeNode7.Text = "UGATU";
            treeNode8.Name = "Узел12";
            treeNode8.Text = "VisualStudio";
            treeNode9.Name = "Узел16";
            treeNode9.Text = "Everything";
            treeNode10.Name = "Узел15";
            treeNode10.Text = "Programs";
            treeNode11.Name = "Узел7";
            treeNode11.Text = "Диск D";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode11});
            this.treeView.Size = new System.Drawing.Size(211, 169);
            this.treeView.TabIndex = 19;
            // 
            // btnShowTree
            // 
            this.btnShowTree.Location = new System.Drawing.Point(328, 267);
            this.btnShowTree.Name = "btnShowTree";
            this.btnShowTree.Size = new System.Drawing.Size(75, 23);
            this.btnShowTree.TabIndex = 20;
            this.btnShowTree.Text = "Show Tree";
            this.btnShowTree.UseVisualStyleBackColor = true;
            this.btnShowTree.Click += new System.EventHandler(this.btnShowTree_Click);
            // 
            // btnHideTree
            // 
            this.btnHideTree.Location = new System.Drawing.Point(402, 267);
            this.btnHideTree.Name = "btnHideTree";
            this.btnHideTree.Size = new System.Drawing.Size(75, 23);
            this.btnHideTree.TabIndex = 21;
            this.btnHideTree.Text = "Hide Tree";
            this.btnHideTree.UseVisualStyleBackColor = true;
            this.btnHideTree.Click += new System.EventHandler(this.btnHideTree_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHideTree);
            this.Controls.Add(this.btnShowTree);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTimerMode);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.btnAddNewBtn);
            this.Controls.Add(this.btnClearLable);
            this.Controls.Add(this.FirstImg);
            this.Controls.Add(this.labelTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.rbSecondImg);
            this.Controls.Add(this.rbFirstImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMsg);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.btnHover);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHover;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFirstImg;
        private System.Windows.Forms.RadioButton rbSecondImg;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labelTrackBar;
        private System.Windows.Forms.PictureBox FirstImg;
        private System.Windows.Forms.Button btnClearLable;
        private System.Windows.Forms.Button btnAddNewBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button btnTimerMode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerPrgrsBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnShowTree;
        private System.Windows.Forms.Button btnHideTree;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

