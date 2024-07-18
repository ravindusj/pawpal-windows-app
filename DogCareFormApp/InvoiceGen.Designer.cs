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
            this.lstTreatmentCosts = new System.Windows.Forms.ListBox();
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTreatmentCosts
            // 
            this.lstTreatmentCosts.FormattingEnabled = true;
            this.lstTreatmentCosts.Location = new System.Drawing.Point(541, 484);
            this.lstTreatmentCosts.Margin = new System.Windows.Forms.Padding(4);
            this.lstTreatmentCosts.Name = "lstTreatmentCosts";
            this.lstTreatmentCosts.Size = new System.Drawing.Size(325, 108);
            this.lstTreatmentCosts.TabIndex = 19;
            // 
            // lstTreatments
            // 
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.Location = new System.Drawing.Point(541, 305);
            this.lstTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.Size = new System.Drawing.Size(335, 121);
            this.lstTreatments.TabIndex = 18;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(541, 243);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(265, 20);
            this.dtpCheckOut.TabIndex = 17;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(541, 184);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(265, 20);
            this.dtpCheckIn.TabIndex = 16;
            // 
            // txtPetID
            // 
            this.txtPetID.Location = new System.Drawing.Point(541, 129);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(351, 20);
            this.txtPetID.TabIndex = 15;
            this.txtPetID.TextChanged += new System.EventHandler(this.txtPetID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Treatment Costs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Additional Treatments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Check-Out Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check-In Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pet id";
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.Location = new System.Drawing.Point(541, 660);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(298, 47);
            this.btnGenerateInvoice.TabIndex = 20;
            this.btnGenerateInvoice.Text = "Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            // 
            // InvoiceGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 855);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.lstTreatmentCosts);
            this.Controls.Add(this.lstTreatments);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceGen";
            this.Text = "InvoiceGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTreatmentCosts;
        private System.Windows.Forms.ListBox lstTreatments;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateInvoice;
    }
}