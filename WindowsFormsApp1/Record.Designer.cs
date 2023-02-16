
namespace WindowsFormsApp1
{
    partial class Record
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateOrderOptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new WindowsFormsApp1.schoolDataSet();
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new WindowsFormsApp1.schoolDataSet1();
            this.clientBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp1.schoolDataSet1TableAdapters.ClientTableAdapter();
            this.clientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new WindowsFormsApp1.DataSet1();
            this.RecordServicesDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new WindowsFormsApp1.schoolDataSetTableAdapters.ServiceTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startLessonHr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startLessonMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.endLessonButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.endLessonMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.endLessonHr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordServicesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.button1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 601);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(662, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(662, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Выбор услуги";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(WindowsFormsApp1.Client);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(WindowsFormsApp1.Client);
            // 
            // updateOrderOptionBindingSource
            // 
            this.updateOrderOptionBindingSource.DataSource = typeof(WindowsFormsApp1.schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // updateOrderOptionBindingSource1
            // 
            this.updateOrderOptionBindingSource1.DataSource = typeof(WindowsFormsApp1.schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSetBindingSource
            // 
            this.schoolDataSetBindingSource.DataSource = this.schoolDataSet;
            this.schoolDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource5, "ID", true));
            this.comboBox1.DataSource = this.clientBindingSource6;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(875, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "ID";
            // 
            // clientBindingSource5
            // 
            this.clientBindingSource5.DataMember = "Client";
            this.clientBindingSource5.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource6
            // 
            this.clientBindingSource6.DataMember = "Client";
            this.clientBindingSource6.DataSource = this.schoolDataSet1;
            // 
            // clientBindingSource4
            // 
            this.clientBindingSource4.DataMember = "Client";
            this.clientBindingSource4.DataSource = this.schoolDataSet1;
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "Client";
            this.clientBindingSource2.DataSource = this.schoolDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource3
            // 
            this.clientBindingSource3.DataMember = "Client";
            this.clientBindingSource3.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1BindingSource
            // 
            this.schoolDataSet1BindingSource.DataSource = this.schoolDataSet1;
            this.schoolDataSet1BindingSource.Position = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RecordServicesDataGrid
            // 
            this.RecordServicesDataGrid.AllowUserToDeleteRows = false;
            this.RecordServicesDataGrid.AutoGenerateColumns = false;
            this.RecordServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordServicesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn});
            this.RecordServicesDataGrid.DataSource = this.serviceBindingSource;
            this.RecordServicesDataGrid.Location = new System.Drawing.Point(859, 110);
            this.RecordServicesDataGrid.Name = "RecordServicesDataGrid";
            this.RecordServicesDataGrid.ReadOnly = true;
            this.RecordServicesDataGrid.RowHeadersWidth = 51;
            this.RecordServicesDataGrid.RowTemplate.Height = 24;
            this.RecordServicesDataGrid.Size = new System.Drawing.Size(545, 289);
            this.RecordServicesDataGrid.TabIndex = 21;
            this.RecordServicesDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.services_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "Продолжительность (мс)";
            this.durationInSecondsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            this.durationInSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationInSecondsDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "Изображение (путь)";
            this.mainImagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            this.mainImagePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.mainImagePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.schoolDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label3.Location = new System.Drawing.Point(641, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Время начала занятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label4.Location = new System.Drawing.Point(641, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Длительность занятия";
            // 
            // startLessonHr
            // 
            this.startLessonHr.Location = new System.Drawing.Point(842, 485);
            this.startLessonHr.Name = "startLessonHr";
            this.startLessonHr.Size = new System.Drawing.Size(147, 22);
            this.startLessonHr.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label5.Location = new System.Drawing.Point(995, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "часов";
            // 
            // startLessonMin
            // 
            this.startLessonMin.Location = new System.Drawing.Point(1057, 485);
            this.startLessonMin.Name = "startLessonMin";
            this.startLessonMin.Size = new System.Drawing.Size(147, 22);
            this.startLessonMin.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label6.Location = new System.Drawing.Point(1222, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "минут";
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(842, 536);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(147, 22);
            this.Duration.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label7.Location = new System.Drawing.Point(995, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "секунд";
            // 
            // endLessonButton
            // 
            this.endLessonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.endLessonButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold);
            this.endLessonButton.ForeColor = System.Drawing.Color.Black;
            this.endLessonButton.Location = new System.Drawing.Point(641, 588);
            this.endLessonButton.Name = "endLessonButton";
            this.endLessonButton.Size = new System.Drawing.Size(237, 79);
            this.endLessonButton.TabIndex = 31;
            this.endLessonButton.Text = "Окончание занятия";
            this.endLessonButton.UseVisualStyleBackColor = false;
            this.endLessonButton.Click += new System.EventHandler(this.endLessonButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label8.Location = new System.Drawing.Point(1264, 614);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "минут";
            // 
            // endLessonMin
            // 
            this.endLessonMin.Location = new System.Drawing.Point(1099, 617);
            this.endLessonMin.Name = "endLessonMin";
            this.endLessonMin.Size = new System.Drawing.Size(147, 22);
            this.endLessonMin.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label9.Location = new System.Drawing.Point(1037, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "часов";
            // 
            // endLessonHr
            // 
            this.endLessonHr.Location = new System.Drawing.Point(884, 617);
            this.endLessonHr.Name = "endLessonHr";
            this.endLessonHr.Size = new System.Drawing.Size(147, 22);
            this.endLessonHr.TabIndex = 32;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 694);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endLessonMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.endLessonHr);
            this.Controls.Add(this.endLessonButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startLessonMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startLessonHr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecordServicesDataGrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "Запись клиента";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordServicesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource1;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private schoolDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource4;
        private System.Windows.Forms.BindingSource clientBindingSource3;
        private System.Windows.Forms.BindingSource clientBindingSource5;
        private System.Windows.Forms.BindingSource schoolDataSet1BindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView RecordServicesDataGrid;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private schoolDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startLessonHr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox startLessonMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button endLessonButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox endLessonMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox endLessonHr;
    }
}