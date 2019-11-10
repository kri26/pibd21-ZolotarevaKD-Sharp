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
            this.buttonSetSportBoat = new System.Windows.Forms.Button();
            this.buttonSetBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxPickUpBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(995, 493);
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
            // buttonSetSportBoat
            // 
            this.buttonSetSportBoat.Location = new System.Drawing.Point(1055, 91);
            this.buttonSetSportBoat.Name = "buttonSetSportBoat";
            this.buttonSetSportBoat.Size = new System.Drawing.Size(120, 67);
            this.buttonSetSportBoat.TabIndex = 5;
            this.buttonSetSportBoat.Text = "Припарковать спортивный катер";
            this.buttonSetSportBoat.UseVisualStyleBackColor = true;
            this.buttonSetSportBoat.Click += new System.EventHandler(this.buttonSetSportBoat_Click);
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(1055, 31);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(120, 54);
            this.buttonSetBoat.TabIndex = 4;
            this.buttonSetBoat.Text = "Припарковать катер";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 517);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBoxPickUpBoat);
            this.Controls.Add(this.buttonSetSportBoat);
            this.Controls.Add(this.buttonSetBoat);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxPickUpBoat.ResumeLayout(false);
            this.groupBoxPickUpBoat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxPickUpBoat;
        private System.Windows.Forms.PictureBox pictureBoxTakeBoat;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonSetSportBoat;
        private System.Windows.Forms.Button buttonSetBoat;
    }
}