namespace helpdesk
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reqRecBox = new System.Windows.Forms.TextBox();
            this.reqDeadBox = new System.Windows.Forms.TextBox();
            this.reqStatBox = new System.Windows.Forms.ComboBox();
            this.reqImpBox = new System.Windows.Forms.ComboBox();
            this.reqPrioBox = new System.Windows.Forms.ComboBox();
            this.reqClientBox = new System.Windows.Forms.ComboBox();
            this.reqOperBox = new System.Windows.Forms.ComboBox();
            this.reqCatBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reqDesBox = new System.Windows.Forms.TextBox();
            this.reqNameBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.clientEmailBox = new System.Windows.Forms.TextBox();
            this.clientPhonBox = new System.Windows.Forms.TextBox();
            this.clientAddrBox = new System.Windows.Forms.TextBox();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.workPostBox = new System.Windows.Forms.ComboBox();
            this.workDepBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.workPhonBox = new System.Windows.Forms.TextBox();
            this.workAddrBox = new System.Windows.Forms.TextBox();
            this.workNameBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.depNameBox = new System.Windows.Forms.TextBox();
            this.depEmailBox = new System.Windows.Forms.TextBox();
            this.depPhonBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.catDesBox = new System.Windows.Forms.TextBox();
            this.catNameBox = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.postDesBox = new System.Windows.Forms.TextBox();
            this.postNameBox = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.prioNameBox = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.statNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grid.Location = new System.Drawing.Point(-12, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(594, 406);
            this.grid.TabIndex = 0;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip2;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(604, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 406);
            this.tabControl1.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.отменитьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(133, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Enabled = false;
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reqRecBox);
            this.tabPage1.Controls.Add(this.reqDeadBox);
            this.tabPage1.Controls.Add(this.reqStatBox);
            this.tabPage1.Controls.Add(this.reqImpBox);
            this.tabPage1.Controls.Add(this.reqPrioBox);
            this.tabPage1.Controls.Add(this.reqClientBox);
            this.tabPage1.Controls.Add(this.reqOperBox);
            this.tabPage1.Controls.Add(this.reqCatBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.reqDesBox);
            this.tabPage1.Controls.Add(this.reqNameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заявки";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // reqRecBox
            // 
            this.reqRecBox.Location = new System.Drawing.Point(168, 97);
            this.reqRecBox.Name = "reqRecBox";
            this.reqRecBox.Size = new System.Drawing.Size(255, 20);
            this.reqRecBox.TabIndex = 6;
            // 
            // reqDeadBox
            // 
            this.reqDeadBox.Location = new System.Drawing.Point(168, 123);
            this.reqDeadBox.Name = "reqDeadBox";
            this.reqDeadBox.Size = new System.Drawing.Size(255, 20);
            this.reqDeadBox.TabIndex = 6;
            // 
            // reqStatBox
            // 
            this.reqStatBox.FormattingEnabled = true;
            this.reqStatBox.Location = new System.Drawing.Point(168, 284);
            this.reqStatBox.Name = "reqStatBox";
            this.reqStatBox.Size = new System.Drawing.Size(255, 21);
            this.reqStatBox.TabIndex = 5;
            // 
            // reqImpBox
            // 
            this.reqImpBox.FormattingEnabled = true;
            this.reqImpBox.Location = new System.Drawing.Point(168, 257);
            this.reqImpBox.Name = "reqImpBox";
            this.reqImpBox.Size = new System.Drawing.Size(255, 21);
            this.reqImpBox.TabIndex = 5;
            // 
            // reqPrioBox
            // 
            this.reqPrioBox.FormattingEnabled = true;
            this.reqPrioBox.Location = new System.Drawing.Point(168, 230);
            this.reqPrioBox.Name = "reqPrioBox";
            this.reqPrioBox.Size = new System.Drawing.Size(255, 21);
            this.reqPrioBox.TabIndex = 5;
            // 
            // reqClientBox
            // 
            this.reqClientBox.FormattingEnabled = true;
            this.reqClientBox.Location = new System.Drawing.Point(168, 203);
            this.reqClientBox.Name = "reqClientBox";
            this.reqClientBox.Size = new System.Drawing.Size(255, 21);
            this.reqClientBox.TabIndex = 5;
            // 
            // reqOperBox
            // 
            this.reqOperBox.FormattingEnabled = true;
            this.reqOperBox.Location = new System.Drawing.Point(168, 176);
            this.reqOperBox.Name = "reqOperBox";
            this.reqOperBox.Size = new System.Drawing.Size(255, 21);
            this.reqOperBox.TabIndex = 5;
            // 
            // reqCatBox
            // 
            this.reqCatBox.FormattingEnabled = true;
            this.reqCatBox.Location = new System.Drawing.Point(168, 149);
            this.reqCatBox.Name = "reqCatBox";
            this.reqCatBox.Size = new System.Drawing.Size(255, 21);
            this.reqCatBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Статус";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Исполнитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Приоритет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Клиент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Оператор";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Дата приема";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Крайний срок выполнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            // 
            // reqDesBox
            // 
            this.reqDesBox.Location = new System.Drawing.Point(168, 40);
            this.reqDesBox.Multiline = true;
            this.reqDesBox.Name = "reqDesBox";
            this.reqDesBox.Size = new System.Drawing.Size(255, 51);
            this.reqDesBox.TabIndex = 2;
            this.reqDesBox.TextChanged += new System.EventHandler(this.reqDesBox_TextChanged);
            // 
            // reqNameBox
            // 
            this.reqNameBox.Location = new System.Drawing.Point(168, 14);
            this.reqNameBox.Name = "reqNameBox";
            this.reqNameBox.Size = new System.Drawing.Size(255, 20);
            this.reqNameBox.TabIndex = 2;
            this.reqNameBox.TextChanged += new System.EventHandler(this.reqNameBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.clientEmailBox);
            this.tabPage2.Controls.Add(this.clientPhonBox);
            this.tabPage2.Controls.Add(this.clientAddrBox);
            this.tabPage2.Controls.Add(this.clientNameBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Телефон";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Адрес";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "ФИО";
            // 
            // clientEmailBox
            // 
            this.clientEmailBox.Location = new System.Drawing.Point(164, 92);
            this.clientEmailBox.Name = "clientEmailBox";
            this.clientEmailBox.Size = new System.Drawing.Size(244, 20);
            this.clientEmailBox.TabIndex = 0;
            // 
            // clientPhonBox
            // 
            this.clientPhonBox.Location = new System.Drawing.Point(164, 66);
            this.clientPhonBox.Name = "clientPhonBox";
            this.clientPhonBox.Size = new System.Drawing.Size(244, 20);
            this.clientPhonBox.TabIndex = 0;
            // 
            // clientAddrBox
            // 
            this.clientAddrBox.Location = new System.Drawing.Point(164, 40);
            this.clientAddrBox.Name = "clientAddrBox";
            this.clientAddrBox.Size = new System.Drawing.Size(244, 20);
            this.clientAddrBox.TabIndex = 0;
            // 
            // clientNameBox
            // 
            this.clientNameBox.Location = new System.Drawing.Point(164, 14);
            this.clientNameBox.Name = "clientNameBox";
            this.clientNameBox.Size = new System.Drawing.Size(244, 20);
            this.clientNameBox.TabIndex = 0;
            this.clientNameBox.TextChanged += new System.EventHandler(this.clientNameBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.workPostBox);
            this.tabPage3.Controls.Add(this.workDepBox);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.workPhonBox);
            this.tabPage3.Controls.Add(this.workAddrBox);
            this.tabPage3.Controls.Add(this.workNameBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(508, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сотрудники";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // workPostBox
            // 
            this.workPostBox.FormattingEnabled = true;
            this.workPostBox.Location = new System.Drawing.Point(166, 119);
            this.workPostBox.Name = "workPostBox";
            this.workPostBox.Size = new System.Drawing.Size(244, 21);
            this.workPostBox.TabIndex = 14;
            this.workPostBox.SelectedIndexChanged += new System.EventHandler(this.workPostBox_SelectedIndexChanged);
            // 
            // workDepBox
            // 
            this.workDepBox.FormattingEnabled = true;
            this.workDepBox.Location = new System.Drawing.Point(166, 93);
            this.workDepBox.Name = "workDepBox";
            this.workDepBox.Size = new System.Drawing.Size(244, 21);
            this.workDepBox.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Должность";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Отдел";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Телефон";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Адрес";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "ФИО";
            // 
            // workPhonBox
            // 
            this.workPhonBox.Location = new System.Drawing.Point(166, 67);
            this.workPhonBox.Name = "workPhonBox";
            this.workPhonBox.Size = new System.Drawing.Size(244, 20);
            this.workPhonBox.TabIndex = 7;
            // 
            // workAddrBox
            // 
            this.workAddrBox.Location = new System.Drawing.Point(166, 41);
            this.workAddrBox.Name = "workAddrBox";
            this.workAddrBox.Size = new System.Drawing.Size(244, 20);
            this.workAddrBox.TabIndex = 8;
            // 
            // workNameBox
            // 
            this.workNameBox.Location = new System.Drawing.Point(166, 15);
            this.workNameBox.Name = "workNameBox";
            this.workNameBox.Size = new System.Drawing.Size(244, 20);
            this.workNameBox.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.depNameBox);
            this.tabPage4.Controls.Add(this.depEmailBox);
            this.tabPage4.Controls.Add(this.depPhonBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(508, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отделы";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Наименование";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Телефон";
            // 
            // depNameBox
            // 
            this.depNameBox.Location = new System.Drawing.Point(168, 17);
            this.depNameBox.Name = "depNameBox";
            this.depNameBox.Size = new System.Drawing.Size(244, 20);
            this.depNameBox.TabIndex = 7;
            // 
            // depEmailBox
            // 
            this.depEmailBox.Location = new System.Drawing.Point(168, 71);
            this.depEmailBox.Name = "depEmailBox";
            this.depEmailBox.Size = new System.Drawing.Size(244, 20);
            this.depEmailBox.TabIndex = 6;
            // 
            // depPhonBox
            // 
            this.depPhonBox.Location = new System.Drawing.Point(168, 45);
            this.depPhonBox.Name = "depPhonBox";
            this.depPhonBox.Size = new System.Drawing.Size(244, 20);
            this.depPhonBox.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.catDesBox);
            this.tabPage5.Controls.Add(this.catNameBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(508, 380);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Категории заявок";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Описание";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Наименование";
            // 
            // catDesBox
            // 
            this.catDesBox.Location = new System.Drawing.Point(166, 44);
            this.catDesBox.Multiline = true;
            this.catDesBox.Name = "catDesBox";
            this.catDesBox.Size = new System.Drawing.Size(244, 62);
            this.catDesBox.TabIndex = 10;
            // 
            // catNameBox
            // 
            this.catNameBox.Location = new System.Drawing.Point(166, 18);
            this.catNameBox.Name = "catNameBox";
            this.catNameBox.Size = new System.Drawing.Size(244, 20);
            this.catNameBox.TabIndex = 10;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Controls.Add(this.label26);
            this.tabPage6.Controls.Add(this.postDesBox);
            this.tabPage6.Controls.Add(this.postNameBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(508, 380);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Должность";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            this.tabPage6.Enter += new System.EventHandler(this.tabPage6_Enter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "Описание";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Наименование";
            // 
            // postDesBox
            // 
            this.postDesBox.Location = new System.Drawing.Point(167, 41);
            this.postDesBox.Multiline = true;
            this.postDesBox.Name = "postDesBox";
            this.postDesBox.Size = new System.Drawing.Size(244, 61);
            this.postDesBox.TabIndex = 12;
            // 
            // postNameBox
            // 
            this.postNameBox.Location = new System.Drawing.Point(167, 15);
            this.postNameBox.Name = "postNameBox";
            this.postNameBox.Size = new System.Drawing.Size(244, 20);
            this.postNameBox.TabIndex = 13;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.prioNameBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(508, 380);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Приоритет";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Enter += new System.EventHandler(this.tabPage7_Enter);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Наименование";
            // 
            // prioNameBox
            // 
            this.prioNameBox.Location = new System.Drawing.Point(167, 20);
            this.prioNameBox.Name = "prioNameBox";
            this.prioNameBox.Size = new System.Drawing.Size(244, 20);
            this.prioNameBox.TabIndex = 16;
            this.prioNameBox.TextChanged += new System.EventHandler(this.prioNameBox_TextChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label28);
            this.tabPage8.Controls.Add(this.statNameBox);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(508, 380);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Статус";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Enter += new System.EventHandler(this.tabPage8_Enter);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 13);
            this.label28.TabIndex = 17;
            this.label28.Text = "Наименование";
            // 
            // statNameBox
            // 
            this.statNameBox.Location = new System.Drawing.Point(168, 23);
            this.statNameBox.Name = "statNameBox";
            this.statNameBox.Size = new System.Drawing.Size(244, 20);
            this.statNameBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "HelpDesk";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ComboBox reqStatBox;
        private System.Windows.Forms.ComboBox reqImpBox;
        private System.Windows.Forms.ComboBox reqPrioBox;
        private System.Windows.Forms.ComboBox reqClientBox;
        private System.Windows.Forms.ComboBox reqOperBox;
        private System.Windows.Forms.ComboBox reqCatBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reqDesBox;
        private System.Windows.Forms.TextBox reqNameBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox clientEmailBox;
        private System.Windows.Forms.TextBox clientPhonBox;
        private System.Windows.Forms.TextBox clientAddrBox;
        private System.Windows.Forms.TextBox clientNameBox;
        private System.Windows.Forms.ComboBox workPostBox;
        private System.Windows.Forms.ComboBox workDepBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox workPhonBox;
        private System.Windows.Forms.TextBox workAddrBox;
        private System.Windows.Forms.TextBox workNameBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox depNameBox;
        private System.Windows.Forms.TextBox depEmailBox;
        private System.Windows.Forms.TextBox depPhonBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox catDesBox;
        private System.Windows.Forms.TextBox catNameBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox postDesBox;
        private System.Windows.Forms.TextBox postNameBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox prioNameBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox statNameBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.TextBox reqDeadBox;
        private System.Windows.Forms.TextBox reqRecBox;
        private System.Windows.Forms.Label label29;
    }
}

