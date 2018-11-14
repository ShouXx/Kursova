namespace Drones
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxStatus = new System.Windows.Forms.ToolStripComboBox();
            this.відсортуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заМоделлюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заОператоромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заВисотоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заШвидкістюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заСтатусомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найкращийРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolContextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolContextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "Новий";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Відкрити";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsToolStripMenuItem.Text = "Зберегти як...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Закрити";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.очиститиToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.editToolStripMenuItem.Text = "Редагування";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addToolStripMenuItem.Text = "Додати";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.changeToolStripMenuItem.Text = "Змінити";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.очиститиToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.відсортуватиToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem,
            this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem,
            this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem,
            this.найкращийРезультатToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.filterToolStripMenuItem.Text = "Фільтр";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxStatus});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.statusToolStripMenuItem.Text = "Статус";
            // 
            // toolStripComboBoxStatus
            // 
            this.toolStripComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxStatus.Items.AddRange(new object[] {
            "Всі",
            "Успішне повернення",
            "Втрачено"});
            this.toolStripComboBoxStatus.Name = "toolStripComboBoxStatus";
            this.toolStripComboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxStatus_SelectedIndexChanged);
            // 
            // відсортуватиToolStripMenuItem
            // 
            this.відсортуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заМоделлюToolStripMenuItem,
            this.заОператоромToolStripMenuItem,
            this.заToolStripMenuItem,
            this.заВисотоюToolStripMenuItem,
            this.заШвидкістюToolStripMenuItem,
            this.заСтатусомToolStripMenuItem});
            this.відсортуватиToolStripMenuItem.Name = "відсортуватиToolStripMenuItem";
            this.відсортуватиToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.відсортуватиToolStripMenuItem.Text = "Відсортувати";
            // 
            // заМоделлюToolStripMenuItem
            // 
            this.заМоделлюToolStripMenuItem.Name = "заМоделлюToolStripMenuItem";
            this.заМоделлюToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.заМоделлюToolStripMenuItem.Text = "За моделлю";
            this.заМоделлюToolStripMenuItem.Click += new System.EventHandler(this.заМоделлюToolStripMenuItem_Click);
            // 
            // заОператоромToolStripMenuItem
            // 
            this.заОператоромToolStripMenuItem.Name = "заОператоромToolStripMenuItem";
            this.заОператоромToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.заОператоромToolStripMenuItem.Text = "За оператором";
            this.заОператоромToolStripMenuItem.Click += new System.EventHandler(this.заОператоромToolStripMenuItem_Click);
            // 
            // заToolStripMenuItem
            // 
            this.заToolStripMenuItem.Name = "заToolStripMenuItem";
            this.заToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.заToolStripMenuItem.Text = "За дистанцією польоту";
            this.заToolStripMenuItem.Click += new System.EventHandler(this.заToolStripMenuItem_Click);
            // 
            // заВисотоюToolStripMenuItem
            // 
            this.заВисотоюToolStripMenuItem.Name = "заВисотоюToolStripMenuItem";
            this.заВисотоюToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.заВисотоюToolStripMenuItem.Text = "За висотою";
            this.заВисотоюToolStripMenuItem.Click += new System.EventHandler(this.заВисотоюToolStripMenuItem_Click);
            // 
            // заШвидкістюToolStripMenuItem
            // 
            this.заШвидкістюToolStripMenuItem.Name = "заШвидкістюToolStripMenuItem";
            this.заШвидкістюToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.заШвидкістюToolStripMenuItem.Text = "За швидкістю";
            this.заШвидкістюToolStripMenuItem.Click += new System.EventHandler(this.заШвидкістюToolStripMenuItem_Click);
            // 
            // заСтатусомToolStripMenuItem
            // 
            this.заСтатусомToolStripMenuItem.Name = "заСтатусомToolStripMenuItem";
            this.заСтатусомToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.заСтатусомToolStripMenuItem.Text = "За статусом";
            this.заСтатусомToolStripMenuItem.Click += new System.EventHandler(this.заСтатусомToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.showAllToolStripMenuItem.Text = "Показати всі";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem
            // 
            this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem.Name = "успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem";
            this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem.Text = "Успішне повернення та найкраща швидкість";
            this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem.Click += new System.EventHandler(this.успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem_Click);
            // 
            // однаковаВисотаЗВідхиленням7359ToolStripMenuItem
            // 
            this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem.Name = "однаковаВисотаЗВідхиленням7359ToolStripMenuItem";
            this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem.Text = "Однакова висота з відхиленням 7,359%";
            this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem.Click += new System.EventHandler(this.однаковаВисотаЗВідхиленням7359ToolStripMenuItem_Click);
            // 
            // середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem
            // 
            this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem.Name = "середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem";
            this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem.Text = "Середній результат дистанція та статус потрачено";
            this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem.Click += new System.EventHandler(this.середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem_Click);
            // 
            // найкращийРезультатToolStripMenuItem
            // 
            this.найкращийРезультатToolStripMenuItem.Name = "найкращийРезультатToolStripMenuItem";
            this.найкращийРезультатToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.найкращийРезультатToolStripMenuItem.Text = "Найкращий результат";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.допомогаToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Довідка";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "Про програму";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(713, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "№";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Модель";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Оператор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дистанція польоту";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Висота";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Швидкість";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Статус";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripContextMenuItem,
            this.editToolContextStripMenuItem,
            this.deleteToolContextStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
            // 
            // addToolStripContextMenuItem
            // 
            this.addToolStripContextMenuItem.Name = "addToolStripContextMenuItem";
            this.addToolStripContextMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addToolStripContextMenuItem.Text = "Додати";
            this.addToolStripContextMenuItem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // editToolContextStripMenuItem
            // 
            this.editToolContextStripMenuItem.Name = "editToolContextStripMenuItem";
            this.editToolContextStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editToolContextStripMenuItem.Text = "Змінити";
            this.editToolContextStripMenuItem.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // deleteToolContextStripMenuItem
            // 
            this.deleteToolContextStripMenuItem.Name = "deleteToolContextStripMenuItem";
            this.deleteToolContextStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.deleteToolContextStripMenuItem.Text = "Видалити";
            this.deleteToolContextStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "drn";
            this.saveFileDialog1.FileName = "NewDrones";
            this.saveFileDialog1.Filter = "Drones files(*.drn)|*.drn|All files(*.*)|*.*";
            this.saveFileDialog1.Title = "Зберегти";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Drones files(*.drn)|*.drn|All files(*.*)|*.*";
            this.openFileDialog1.Title = "Відкрити";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(93, 85);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Змінити";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(174, 85);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(255, 85);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(100, 23);
            this.buttonShowAll.TabIndex = 5;
            this.buttonShowAll.Text = "Показати всі";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Дрони";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStatus;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolContextStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolContextStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відсортуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заМоделлюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заОператоромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заВисотоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заШвидкістюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заСтатусомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однаковаВисотаЗВідхиленням7359ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найкращийРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
    }
}

