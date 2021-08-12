
namespace Week6Assignment3
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblstatuenum = new System.Windows.Forms.Label();
            this.lblchar = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lbllic = new System.Windows.Forms.Label();
            this.lblscale = new System.Windows.Forms.Label();
            this.lbledition = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtchar = new System.Windows.Forms.TextBox();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.txtedition = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblstatuenum
            // 
            this.lblstatuenum.AutoSize = true;
            this.lblstatuenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuenum.Location = new System.Drawing.Point(50, 327);
            this.lblstatuenum.Name = "lblstatuenum";
            this.lblstatuenum.Size = new System.Drawing.Size(89, 13);
            this.lblstatuenum.TabIndex = 1;
            this.lblstatuenum.Text = "Statue number";
            // 
            // lblchar
            // 
            this.lblchar.AutoSize = true;
            this.lblchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchar.Location = new System.Drawing.Point(50, 383);
            this.lblchar.Name = "lblchar";
            this.lblchar.Size = new System.Drawing.Size(62, 13);
            this.lblchar.TabIndex = 2;
            this.lblchar.Text = "Character";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomp.Location = new System.Drawing.Point(50, 440);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(58, 13);
            this.lblcomp.TabIndex = 3;
            this.lblcomp.Text = "Company";
            // 
            // lbllic
            // 
            this.lbllic.AutoSize = true;
            this.lbllic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllic.Location = new System.Drawing.Point(50, 486);
            this.lbllic.Name = "lbllic";
            this.lbllic.Size = new System.Drawing.Size(51, 13);
            this.lbllic.TabIndex = 4;
            this.lbllic.Text = "License";
            // 
            // lblscale
            // 
            this.lblscale.AutoSize = true;
            this.lblscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscale.Location = new System.Drawing.Point(50, 530);
            this.lblscale.Name = "lblscale";
            this.lblscale.Size = new System.Drawing.Size(39, 13);
            this.lblscale.TabIndex = 5;
            this.lblscale.Text = "Scale";
            // 
            // lbledition
            // 
            this.lbledition.AutoSize = true;
            this.lbledition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledition.Location = new System.Drawing.Point(50, 579);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(74, 13);
            this.lbledition.TabIndex = 6;
            this.lbledition.Text = "Edition Size";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(238, 320);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(121, 20);
            this.txtnumber.TabIndex = 7;
            // 
            // txtchar
            // 
            this.txtchar.Location = new System.Drawing.Point(238, 376);
            this.txtchar.Name = "txtchar";
            this.txtchar.Size = new System.Drawing.Size(121, 20);
            this.txtchar.TabIndex = 8;
            // 
            // txtcompany
            // 
            this.txtcompany.Location = new System.Drawing.Point(238, 433);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(121, 20);
            this.txtcompany.TabIndex = 9;
            // 
            // txtlicense
            // 
            this.txtlicense.Location = new System.Drawing.Point(238, 479);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(121, 20);
            this.txtlicense.TabIndex = 10;
            // 
            // txtedition
            // 
            this.txtedition.Location = new System.Drawing.Point(238, 572);
            this.txtedition.Name = "txtedition";
            this.txtedition.Size = new System.Drawing.Size(121, 20);
            this.txtedition.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 522);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(458, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 57);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add New Statue";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(632, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 57);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(632, 320);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(120, 57);
            this.btnrefresh.TabIndex = 15;
            this.btnrefresh.Text = "Refresh Data";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(458, 414);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 57);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(549, 503);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 57);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "Select To Edit";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(233, 652);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(270, 27);
            this.lblFormName.TabIndex = 18;
            this.lblFormName.Text = "One Stop Statue Shop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 739);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtedition);
            this.Controls.Add(this.txtlicense);
            this.Controls.Add(this.txtcompany);
            this.Controls.Add(this.txtchar);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lbledition);
            this.Controls.Add(this.lblscale);
            this.Controls.Add(this.lbllic);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblchar);
            this.Controls.Add(this.lblstatuenum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblstatuenum;
        private System.Windows.Forms.Label lblchar;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lbllic;
        private System.Windows.Forms.Label lblscale;
        private System.Windows.Forms.Label lbledition;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtchar;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox txtlicense;
        private System.Windows.Forms.TextBox txtedition;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFormName;
    }
}

