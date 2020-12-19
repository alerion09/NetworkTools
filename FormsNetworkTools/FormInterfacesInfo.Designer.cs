namespace FormsNetworkTools
{
    partial class FormInterfacesInfo
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
            this.buttonReturnToMain = new System.Windows.Forms.Button();
            this.labelInterfacesInformationsMain = new System.Windows.Forms.Label();
            this.textBoxFullInterfacesInformationsOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReturnToMain
            // 
            this.buttonReturnToMain.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonReturnToMain.Location = new System.Drawing.Point(630, 12);
            this.buttonReturnToMain.Name = "buttonReturnToMain";
            this.buttonReturnToMain.Size = new System.Drawing.Size(69, 54);
            this.buttonReturnToMain.TabIndex = 7;
            this.buttonReturnToMain.Text = "Menu";
            this.buttonReturnToMain.UseVisualStyleBackColor = true;
            this.buttonReturnToMain.Click += new System.EventHandler(this.buttonReturnToMain_Click);
            // 
            // labelInterfacesInformationsMain
            // 
            this.labelInterfacesInformationsMain.AutoSize = true;
            this.labelInterfacesInformationsMain.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInterfacesInformationsMain.Location = new System.Drawing.Point(130, 24);
            this.labelInterfacesInformationsMain.Name = "labelInterfacesInformationsMain";
            this.labelInterfacesInformationsMain.Size = new System.Drawing.Size(431, 42);
            this.labelInterfacesInformationsMain.TabIndex = 9;
            this.labelInterfacesInformationsMain.Text = "INTERFACES INFORMATIONS";
            // 
            // textBoxFullInterfacesInformationsOutput
            // 
            this.textBoxFullInterfacesInformationsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFullInterfacesInformationsOutput.Location = new System.Drawing.Point(137, 101);
            this.textBoxFullInterfacesInformationsOutput.Multiline = true;
            this.textBoxFullInterfacesInformationsOutput.Name = "textBoxFullInterfacesInformationsOutput";
            this.textBoxFullInterfacesInformationsOutput.ReadOnly = true;
            this.textBoxFullInterfacesInformationsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFullInterfacesInformationsOutput.Size = new System.Drawing.Size(443, 398);
            this.textBoxFullInterfacesInformationsOutput.TabIndex = 10;
            // 
            // FormInterfacesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 511);
            this.Controls.Add(this.textBoxFullInterfacesInformationsOutput);
            this.Controls.Add(this.labelInterfacesInformationsMain);
            this.Controls.Add(this.buttonReturnToMain);
            this.Name = "FormInterfacesInfo";
            this.ShowIcon = false;
            this.Text = "Interfaces Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnToMain;
        private System.Windows.Forms.Label labelInterfacesInformationsMain;
        private System.Windows.Forms.TextBox textBoxFullInterfacesInformationsOutput;
    }
}