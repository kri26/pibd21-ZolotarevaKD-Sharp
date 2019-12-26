namespace WindowsFormsBoat
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxPickUpBoat = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeBoat = new System.Windows.Forms.PictureBox();
            this.buttonTakeBoat = new System.Windows.Forms.Button();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.menuStripBoat = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogBoat = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBoat = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxPickUpBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBoat)).BeginInit();
            this.menuStripBoat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 26);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(995, 479);
            this.pictureBoxParking.TabIndex = 7;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxPickUpBoat
            // 
            this.groupBoxPickUpBoat.Controls.Add(this.pictureBoxTakeBoat);
            this.groupBoxPickUpBoat.Controls.Add(this.buttonTakeBoat);
            this.groupBoxPickUpBoat.Controls.Add(this.maskedTextBoxPosition);
            this.groupBoxPickUpBoat.Controls.Add(this.labelPosition);
            this.groupBoxPickUpBoat.Location = new System.Drawing.Point(1027, 269);
            this.groupBoxPickUpBoat.Name = "groupBoxPickUpBoat";
            this.groupBoxPickUpBoat.Size = new System.Drawing.Size(154, 236);
            this.groupBoxPickUpBoat.TabIndex = 6;
            this.groupBoxPickUpBoat.TabStop = false;
            this.groupBoxPickUpBoat.Text = "Забрать катер";
            // 
            // pictureBoxTakeBoat
            // 
            this.pictureBoxTakeBoat.Location = new System.Drawing.Point(9, 125);
            this.pictureBoxTakeBoat.Name = "pictureBoxTakeBoat";
            this.pictureBoxTakeBoat.Size = new System.Drawing.Size(139, 96);
            this.pictureBoxTakeBoat.TabIndex = 3;
            this.pictureBoxTakeBoat.TabStop = false;
            // 
            // buttonTakeBoat
            // 
            this.buttonTakeBoat.Location = new System.Drawing.Point(35, 79);
            this.buttonTakeBoat.Name = "buttonTakeBoat";
            this.buttonTakeBoat.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeBoat.TabIndex = 2;
            this.buttonTakeBoat.Text = "Забрать";
            this.buttonTakeBoat.UseVisualStyleBackColor = true;
            this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeBoat_Click);
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(79, 38);
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(57, 22);
            this.maskedTextBoxPosition.TabIndex = 1;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(6, 38);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(49, 17);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Место";
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(1043, 128);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(120, 54);
            this.buttonSetBoat.TabIndex = 4;
            this.buttonSetBoat.Text = "Припарковать катер";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1019, 26);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(168, 84);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // menuStripBoat
            // 
            this.menuStripBoat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripBoat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripBoat.Location = new System.Drawing.Point(0, 0);
            this.menuStripBoat.Name = "menuStripBoat";
            this.menuStripBoat.Size = new System.Drawing.Size(1199, 28);
            this.menuStripBoat.TabIndex = 9;
            this.menuStripBoat.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialogBoat
            // 
            this.openFileDialogBoat.FileName = "openFileDialog";
            this.openFileDialogBoat.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1043, 200);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(120, 45);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 517);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBoxPickUpBoat);
            this.Controls.Add(this.buttonSetBoat);
            this.Controls.Add(this.menuStripBoat);
            this.MainMenuStrip = this.menuStripBoat;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxPickUpBoat.ResumeLayout(false);
            this.groupBoxPickUpBoat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBoat)).EndInit();
            this.menuStripBoat.ResumeLayout(false);
            this.menuStripBoat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxPickUpBoat;
        private System.Windows.Forms.PictureBox pictureBoxTakeBoat;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.MenuStrip menuStripBoat;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBoat;
        private System.Windows.Forms.OpenFileDialog openFileDialogBoat;
        private System.Windows.Forms.Button buttonSort;
    }
}
