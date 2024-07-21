namespace DogCareFormApp
{
    partial class InvoiceGen
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
            this.btnAddCost = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.lstTreatmentCosts = new System.Windows.Forms.ListBox();
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGenerateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnAddCost
            // 
            this.btnAddCost.Location = new System.Drawing.Point(399, 394);
            this.btnAddCost.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(110, 25);
            this.btnAddCost.TabIndex = 35;
            this.btnAddCost.Text = "Add Cost";
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(399, 252);
            this.btnAddTreatment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(110, 25);
            this.btnAddTreatment.TabIndex = 34;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // lstTreatmentCosts
            // 
            this.lstTreatmentCosts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstTreatmentCosts.FormattingEnabled = true;
            this.lstTreatmentCosts.Location = new System.Drawing.Point(257, 294);
            this.lstTreatmentCosts.Name = "lstTreatmentCosts";
            this.lstTreatmentCosts.Size = new System.Drawing.Size(252, 95);
            this.lstTreatmentCosts.TabIndex = 32;
            // 
            // lstTreatments
            // 
            this.lstTreatments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.Location = new System.Drawing.Point(257, 152);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.Size = new System.Drawing.Size(252, 95);
            this.lstTreatments.TabIndex = 31;
            this.lstTreatments.SelectedIndexChanged += new System.EventHandler(this.lstTreatments_SelectedIndexChanged_1);
            // 
            // txtPetID
            // 
            this.txtPetID.Location = new System.Drawing.Point(294, -27);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(264, 20);
            this.txtPetID.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Treatment Costs :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Additional Treatments :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Check-Out Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Check-In Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pet id";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Animated = true;
            this.dtpCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.dtpCheckIn.BorderRadius = 10;
            this.dtpCheckIn.BorderThickness = 1;
            this.dtpCheckIn.Checked = true;
            this.dtpCheckIn.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpCheckIn.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckIn.Location = new System.Drawing.Point(257, 29);
            this.dtpCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(252, 33);
            this.dtpCheckIn.TabIndex = 36;
            this.dtpCheckIn.UseTransparentBackground = true;
            this.dtpCheckIn.Value = new System.DateTime(2024, 7, 20, 21, 35, 39, 804);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Animated = true;
            this.dtpCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.dtpCheckOut.BorderRadius = 10;
            this.dtpCheckOut.BorderThickness = 1;
            this.dtpCheckOut.Checked = true;
            this.dtpCheckOut.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpCheckOut.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.dtpCheckOut.ForeColor = System.Drawing.Color.Black;
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckOut.Location = new System.Drawing.Point(257, 86);
            this.dtpCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(252, 33);
            this.dtpCheckOut.TabIndex = 37;
            this.dtpCheckOut.UseTransparentBackground = true;
            this.dtpCheckOut.Value = new System.DateTime(2024, 7, 20, 21, 35, 39, 804);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Animated = true;
            this.btnGenerateInvoice.BorderRadius = 10;
            this.btnGenerateInvoice.BorderThickness = 1;
            this.btnGenerateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateInvoice.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerateInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateInvoice.HoverState.FillColor = System.Drawing.Color.White;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(237, 438);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.ShadowDecoration.BorderRadius = 10;
            this.btnGenerateInvoice.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.btnGenerateInvoice.Size = new System.Drawing.Size(134, 43);
            this.btnGenerateInvoice.TabIndex = 85;
            this.btnGenerateInvoice.Text = "Print Invoice";
            this.btnGenerateInvoice.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // InvoiceGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 510);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.btnAddCost);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.lstTreatmentCosts);
            this.Controls.Add(this.lstTreatments);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceGen";
            this.Load += new System.EventHandler(this.InvoiceGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.ListBox lstTreatmentCosts;
        private System.Windows.Forms.ListBox lstTreatments;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnGenerateInvoice;
    }
}