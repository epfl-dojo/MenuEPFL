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
            this.labelCombo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
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
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.Location = new System.Drawing.Point(47, 58);
            this.labelCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(119, 17);
            this.labelCombo.TabIndex = 1;
            this.labelCombo.Text = "Quel restaurant ?";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(102, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 375);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.labelCombo);
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
        private System.Windows.Forms.Label labelCombo;
        private System.Windows.Forms.Label lblResult;
    }
}

