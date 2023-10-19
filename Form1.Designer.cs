namespace Otel
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
            this.btnShowBookings = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnShowRooms = new System.Windows.Forms.Button();
            this.btnShowServices = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.otelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new Otel.OtelDataSet();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelName4 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxServiceID = new System.Windows.Forms.TextBox();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.btnSql = new System.Windows.Forms.Button();
            this.dataGridViewSecond = new System.Windows.Forms.DataGridView();
            this.otelDataSet1 = new Otel.OtelDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.Location = new System.Drawing.Point(209, 359);
            this.btnShowBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(135, 39);
            this.btnShowBookings.TabIndex = 0;
            this.btnShowBookings.Text = "Бронирования";
            this.btnShowBookings.UseVisualStyleBackColor = true;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(23, 359);
            this.btnShowUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(141, 39);
            this.btnShowUsers.TabIndex = 1;
            this.btnShowUsers.Text = "Клиенты";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnShowRooms
            // 
            this.btnShowRooms.Location = new System.Drawing.Point(387, 359);
            this.btnShowRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowRooms.Name = "btnShowRooms";
            this.btnShowRooms.Size = new System.Drawing.Size(143, 39);
            this.btnShowRooms.TabIndex = 2;
            this.btnShowRooms.Text = "Номера";
            this.btnShowRooms.UseVisualStyleBackColor = true;
            this.btnShowRooms.Click += new System.EventHandler(this.btnShowRooms_Click);
            // 
            // btnShowServices
            // 
            this.btnShowServices.Location = new System.Drawing.Point(567, 359);
            this.btnShowServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowServices.Name = "btnShowServices";
            this.btnShowServices.Size = new System.Drawing.Size(143, 39);
            this.btnShowServices.TabIndex = 4;
            this.btnShowServices.Text = "Услуги";
            this.btnShowServices.UseVisualStyleBackColor = true;
            this.btnShowServices.Click += new System.EventHandler(this.btnShowServices_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(65, 481);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактитровать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // otelDataSetBindingSource
            // 
            this.otelDataSetBindingSource.DataSource = this.otelDataSet;
            this.otelDataSetBindingSource.Position = 0;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(6, 5);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(739, 333);
            this.dataGridViewMain.TabIndex = 6;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick);
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(13, 421);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(0, 16);
            this.labelName1.TabIndex = 7;
            // 
            // labelName4
            // 
            this.labelName4.AutoSize = true;
            this.labelName4.Location = new System.Drawing.Point(556, 421);
            this.labelName4.Name = "labelName4";
            this.labelName4.Size = new System.Drawing.Size(0, 16);
            this.labelName4.TabIndex = 7;
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(197, 421);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(0, 16);
            this.labelName2.TabIndex = 7;
            // 
            // labelName3
            // 
            this.labelName3.AutoSize = true;
            this.labelName3.Location = new System.Drawing.Point(375, 421);
            this.labelName3.Name = "labelName3";
            this.labelName3.Size = new System.Drawing.Size(0, 16);
            this.labelName3.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 440);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(371, 440);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(552, 440);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(746, 440);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 11;
            this.textBoxID.Visible = false;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(769, 421);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(0, 16);
            this.label0.TabIndex = 12;
            this.label0.Visible = false;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(746, 468);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserID.TabIndex = 11;
            this.textBoxUserID.Visible = false;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(746, 498);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoomID.TabIndex = 11;
            this.textBoxRoomID.Visible = false;
            // 
            // textBoxServiceID
            // 
            this.textBoxServiceID.Location = new System.Drawing.Point(746, 526);
            this.textBoxServiceID.Name = "textBoxServiceID";
            this.textBoxServiceID.Size = new System.Drawing.Size(100, 22);
            this.textBoxServiceID.TabIndex = 11;
            this.textBoxServiceID.Visible = false;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tab2);
            this.tab1.Location = new System.Drawing.Point(0, 3);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(753, 561);
            this.tab1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dataGridViewMain);
            this.tabPage1.Controls.Add(this.label0);
            this.tabPage1.Controls.Add(this.btnShowUsers);
            this.tabPage1.Controls.Add(this.labelName3);
            this.tabPage1.Controls.Add(this.labelName2);
            this.tabPage1.Controls.Add(this.textBoxServiceID);
            this.tabPage1.Controls.Add(this.labelName4);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.labelName1);
            this.tabPage1.Controls.Add(this.btnShowBookings);
            this.tabPage1.Controls.Add(this.textBoxRoomID);
            this.tabPage1.Controls.Add(this.btnShowRooms);
            this.tabPage1.Controls.Add(this.textBoxUserID);
            this.tabPage1.Controls.Add(this.btnShowServices);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 481);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.button6);
            this.tab2.Controls.Add(this.button5);
            this.tab2.Controls.Add(this.button4);
            this.tab2.Controls.Add(this.button3);
            this.tab2.Controls.Add(this.button2);
            this.tab2.Controls.Add(this.button1);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Controls.Add(this.textBoxSql);
            this.tab2.Controls.Add(this.btnSql);
            this.tab2.Controls.Add(this.dataGridViewSecond);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(745, 532);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "SQL";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите запрос";
            // 
            // textBoxSql
            // 
            this.textBoxSql.Location = new System.Drawing.Point(12, 369);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(723, 126);
            this.textBoxSql.TabIndex = 2;
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(627, 501);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(108, 28);
            this.btnSql.TabIndex = 1;
            this.btnSql.Text = "Выполнить";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // dataGridViewSecond
            // 
            this.dataGridViewSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecond.Location = new System.Drawing.Point(9, 7);
            this.dataGridViewSecond.Name = "dataGridViewSecond";
            this.dataGridViewSecond.RowHeadersWidth = 51;
            this.dataGridViewSecond.RowTemplate.Height = 24;
            this.dataGridViewSecond.Size = new System.Drawing.Size(730, 336);
            this.dataGridViewSecond.TabIndex = 0;
            // 
            // otelDataSet1
            // 
            this.otelDataSet1.DataSetName = "OtelDataSet";
            this.otelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Case";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Подзапрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Коррелированный";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 504);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Having";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Any";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(509, 503);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "All";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 564);
            this.Controls.Add(this.tab1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "OtelDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowBookings;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnShowRooms;
        private System.Windows.Forms.Button btnShowServices;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource otelDataSetBindingSource;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelName4;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxServiceID;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.DataGridView dataGridViewSecond;
        private OtelDataSet otelDataSet1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}

