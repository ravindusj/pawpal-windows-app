namespace DogCareFormApp
{
    partial class Inventoryr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Product = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.TextBox();
            this.Qt = new System.Windows.Forms.TextBox();
            this.NOPT = new System.Windows.Forms.TextBox();
            this.DT = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Cate = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.NOP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(592, 379);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 20);
            this.Product.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Data View*";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(547, 466);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(100, 20);
            this.Category.TabIndex = 51;
            // 
            // Qt
            // 
            this.Qt.Location = new System.Drawing.Point(547, 509);
            this.Qt.Name = "Qt";
            this.Qt.Size = new System.Drawing.Size(100, 20);
            this.Qt.TabIndex = 50;
            // 
            // NOPT
            // 
            this.NOPT.Location = new System.Drawing.Point(547, 419);
            this.NOPT.Name = "NOPT";
            this.NOPT.Size = new System.Drawing.Size(100, 20);
            this.NOPT.TabIndex = 49;
            // 
            // DT
            // 
            this.DT.Location = new System.Drawing.Point(547, 550);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(100, 20);
            this.DT.TabIndex = 48;
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(451, 373);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(58, 13);
            this.ProductID.TabIndex = 47;
            this.ProductID.Text = "Product ID";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(497, 553);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 46;
            this.Date.Text = "Date";
            // 
            // Cate
            // 
            this.Cate.AutoSize = true;
            this.Cate.Location = new System.Drawing.Point(460, 469);
            this.Cate.Name = "Cate";
            this.Cate.Size = new System.Drawing.Size(49, 13);
            this.Cate.TabIndex = 45;
            this.Cate.Text = "Category";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(479, 516);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(48, 13);
            this.Quantity.TabIndex = 44;
            this.Quantity.Text = "Quantitly";
            // 
            // NOP
            // 
            this.NOP.AutoSize = true;
            this.NOP.Location = new System.Drawing.Point(440, 422);
            this.NOP.Name = "NOP";
            this.NOP.Size = new System.Drawing.Size(87, 13);
            this.NOP.TabIndex = 43;
            this.NOP.Text = "Name of Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Inventory Management";
            // 
            // Inventoryr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.Product);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Qt);
            this.Controls.Add(this.NOPT);
            this.Controls.Add(this.DT);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Cate);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.NOP);
            this.Controls.Add(this.label1);
            this.Name = "Inventoryr";
            this.Size = new System.Drawing.Size(1024, 778);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Qt;
        private System.Windows.Forms.TextBox NOPT;
        private System.Windows.Forms.TextBox DT;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Cate;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label NOP;
        private System.Windows.Forms.Label label1;
    }
}
