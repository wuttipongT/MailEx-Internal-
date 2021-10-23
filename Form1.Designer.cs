﻿
namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(253, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.textBox1, this.autocompleteMenu1);
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.Location = new System.Drawing.Point(81, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 37);
            this.textBox1.TabIndex = 1;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AllowsTabKey = true;
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "doc",
        "cat",
        "ant",
        "bee",
        "monkey",
        "buffalo"};
            this.autocompleteMenu1.MinFragmentLength = 1;
            this.autocompleteMenu1.SearchPattern = "[\\w\\.@]";
            this.autocompleteMenu1.TargetControlWrapper = null;
            this.autocompleteMenu1.Selected += new System.EventHandler<AutocompleteMenuNS.SelectedEventArgs>(this.autocompleteMenu1_Selected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send Mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(164, 268);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.advancedDataGridView1.TabIndex = 4;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
    }
}

