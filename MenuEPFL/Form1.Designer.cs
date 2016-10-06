namespace MenuEPFL
{
    partial class Main
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
            this.selectRestaurant = new System.Windows.Forms.ComboBox();
            this.lblResto = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.selectMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkResto = new System.Windows.Forms.LinkLabel();
            this.menuText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectRestaurant
            // 
            this.selectRestaurant.FormattingEnabled = true;
            this.selectRestaurant.Location = new System.Drawing.Point(198, 55);
            this.selectRestaurant.Margin = new System.Windows.Forms.Padding(2);
            this.selectRestaurant.Name = "selectRestaurant";
            this.selectRestaurant.Size = new System.Drawing.Size(267, 24);
            this.selectRestaurant.TabIndex = 0;
            this.selectRestaurant.SelectedIndexChanged += new System.EventHandler(this.selectRestaurant_SelectedIndexChanged);
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(47, 58);
            this.lblResto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(119, 17);
            this.lblResto.TabIndex = 1;
            this.lblResto.Text = "Quel restaurant ?";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(105, 293);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(50, 111);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(89, 17);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Quel menu ?";
            // 
            // selectMenu
            // 
            this.selectMenu.FormattingEnabled = true;
            this.selectMenu.Location = new System.Drawing.Point(198, 102);
            this.selectMenu.Name = "selectMenu";
            this.selectMenu.Size = new System.Drawing.Size(267, 24);
            this.selectMenu.TabIndex = 4;
            this.selectMenu.SelectedIndexChanged += new System.EventHandler(this.selectMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lien du restaurant :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkResto
            // 
            this.linkResto.AutoSize = true;
            this.linkResto.Location = new System.Drawing.Point(198, 286);
            this.linkResto.Name = "linkResto";
            this.linkResto.Size = new System.Drawing.Size(72, 17);
            this.linkResto.TabIndex = 6;
            this.linkResto.TabStop = true;
            this.linkResto.Text = "linkLabel1";
            // 
            // menuText
            // 
            this.menuText.Location = new System.Drawing.Point(50, 151);
            this.menuText.Multiline = true;
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(415, 132);
            this.menuText.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 375);
            this.Controls.Add(this.menuText);
            this.Controls.Add(this.linkResto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.selectRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectRestaurant;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ComboBox selectMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkResto;
        private System.Windows.Forms.TextBox menuText;
    }
}

