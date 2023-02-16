
namespace WindowsFormsApp1
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.button1 = new System.Windows.Forms.Button();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.serviceCost = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.dsada = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.sdsada = new System.Windows.Forms.Label();
            this.фывыв = new System.Windows.Forms.Label();
            this.serviceDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.button1.Location = new System.Drawing.Point(12, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serviceName
            // 
            this.serviceName.Location = new System.Drawing.Point(1106, 66);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(232, 22);
            this.serviceName.TabIndex = 3;
            // 
            // serviceCost
            // 
            this.serviceCost.Location = new System.Drawing.Point(1106, 117);
            this.serviceCost.Name = "serviceCost";
            this.serviceCost.Size = new System.Drawing.Size(232, 22);
            this.serviceCost.TabIndex = 4;
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(1106, 237);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(232, 22);
            this.discount.TabIndex = 6;
            // 
            // dsada
            // 
            this.dsada.AutoSize = true;
            this.dsada.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.dsada.Location = new System.Drawing.Point(993, 66);
            this.dsada.Name = "dsada";
            this.dsada.Size = new System.Drawing.Size(78, 20);
            this.dsada.TabIndex = 9;
            this.dsada.Text = "Название";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.cost.Location = new System.Drawing.Point(993, 117);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(86, 20);
            this.cost.TabIndex = 10;
            this.cost.Text = "Стоимость";
            // 
            // sdsada
            // 
            this.sdsada.AutoSize = true;
            this.sdsada.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sdsada.Location = new System.Drawing.Point(993, 175);
            this.sdsada.Name = "sdsada";
            this.sdsada.Size = new System.Drawing.Size(83, 20);
            this.sdsada.TabIndex = 11;
            this.sdsada.Text = "Описание";
            // 
            // фывыв
            // 
            this.фывыв.AutoSize = true;
            this.фывыв.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фывыв.Location = new System.Drawing.Point(993, 237);
            this.фывыв.Name = "фывыв";
            this.фывыв.Size = new System.Drawing.Size(59, 20);
            this.фывыв.TabIndex = 12;
            this.фывыв.Text = "Скидка";
            // 
            // serviceDescription
            // 
            this.serviceDescription.Location = new System.Drawing.Point(1106, 164);
            this.serviceDescription.Name = "serviceDescription";
            this.serviceDescription.Size = new System.Drawing.Size(232, 67);
            this.serviceDescription.TabIndex = 15;
            this.serviceDescription.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 568);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Beige;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(949, 638);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 42);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Coral;
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.deleteButton.Location = new System.Drawing.Point(1138, 638);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(143, 42);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 713);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.serviceDescription);
            this.Controls.Add(this.фывыв);
            this.Controls.Add(this.sdsada);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.dsada);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.serviceCost);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.TextBox serviceCost;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label dsada;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label sdsada;
        private System.Windows.Forms.Label фывыв;
        private System.Windows.Forms.RichTextBox serviceDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}