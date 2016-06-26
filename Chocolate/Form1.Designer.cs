namespace Chocolate
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Sortbutton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.SNoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Name of the Manufacturer";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox.Location = new System.Drawing.Point(238, 25);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(255, 20);
            this.TextBox.TabIndex = 1;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(15, 62);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Insertbutton
            // 
            this.Insertbutton.Location = new System.Drawing.Point(116, 61);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 23);
            this.Insertbutton.TabIndex = 3;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(217, 61);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Sortbutton
            // 
            this.Sortbutton.Location = new System.Drawing.Point(318, 61);
            this.Sortbutton.Name = "Sortbutton";
            this.Sortbutton.Size = new System.Drawing.Size(75, 23);
            this.Sortbutton.TabIndex = 5;
            this.Sortbutton.Text = "SORT";
            this.Sortbutton.UseVisualStyleBackColor = true;
            this.Sortbutton.Click += new System.EventHandler(this.Sortbutton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(417, 62);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SNoColumn,
            this.NameColumn});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(15, 124);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(477, 207);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // SNoColumn
            // 
            this.SNoColumn.Text = "SNo";
            this.SNoColumn.Width = 84;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 388;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 359);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Sortbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "ChocolateManufacturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Insertbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Sortbutton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader SNoColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
    }
}

