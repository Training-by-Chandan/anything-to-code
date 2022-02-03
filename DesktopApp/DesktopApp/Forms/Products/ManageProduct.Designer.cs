namespace DesktopApp.Forms.Products
{
    partial class ManageProduct
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.unitCombo = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(218, 26);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(397, 30);
            this.nameTxt.TabIndex = 1;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(218, 80);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(397, 30);
            this.quantityTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(218, 203);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(397, 30);
            this.priceTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(218, 259);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(397, 30);
            this.codeTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(510, 338);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(105, 56);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(365, 338);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 56);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // productGrid
            // 
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Location = new System.Drawing.Point(47, 519);
            this.productGrid.MultiSelect = false;
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.Size = new System.Drawing.Size(568, 192);
            this.productGrid.TabIndex = 12;
            // 
            // unitCombo
            // 
            this.unitCombo.FormattingEnabled = true;
            this.unitCombo.Items.AddRange(new object[] {
            "Piece",
            "Litres",
            "Kg",
            "Cartoon",
            "Dozen",
            "Quintal",
            "Tonnes"});
            this.unitCombo.Location = new System.Drawing.Point(218, 137);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.Size = new System.Drawing.Size(397, 33);
            this.unitCombo.TabIndex = 13;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(510, 338);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(105, 56);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Location = new System.Drawing.Point(45, 338);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Size = new System.Drawing.Size(0, 25);
            this.lblSelectedId.TabIndex = 15;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(365, 338);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 56);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(413, 462);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(202, 30);
            this.searchTxt.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(641, 80);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Records";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(339, 300);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 723);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.lblSelectedId);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.unitCombo);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.ComboBox unitCombo;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}