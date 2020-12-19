namespace FormsNetworkTools
{
    partial class FormMain
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
            this.buttonRunPinger = new System.Windows.Forms.Button();
            this.labelNetworkInformations = new System.Windows.Forms.Label();
            this.labelNetworkInformationsOutput = new System.Windows.Forms.Label();
            this.buttonRunInterfacesInfo = new System.Windows.Forms.Button();
            this.labelInternetStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRunPinger
            // 
            this.buttonRunPinger.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonRunPinger.Location = new System.Drawing.Point(387, 51);
            this.buttonRunPinger.Name = "buttonRunPinger";
            this.buttonRunPinger.Size = new System.Drawing.Size(300, 77);
            this.buttonRunPinger.TabIndex = 0;
            this.buttonRunPinger.Text = "Pinger";
            this.buttonRunPinger.UseVisualStyleBackColor = true;
            this.buttonRunPinger.Click += new System.EventHandler(this.buttonRunPinger_Click);
            // 
            // labelNetworkInformations
            // 
            this.labelNetworkInformations.AutoSize = true;
            this.labelNetworkInformations.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNetworkInformations.Location = new System.Drawing.Point(12, 12);
            this.labelNetworkInformations.Name = "labelNetworkInformations";
            this.labelNetworkInformations.Size = new System.Drawing.Size(185, 23);
            this.labelNetworkInformations.TabIndex = 1;
            this.labelNetworkInformations.Text = "Network Informations";
            // 
            // labelNetworkInformationsOutput
            // 
            this.labelNetworkInformationsOutput.AutoSize = true;
            this.labelNetworkInformationsOutput.Location = new System.Drawing.Point(13, 51);
            this.labelNetworkInformationsOutput.Name = "labelNetworkInformationsOutput";
            this.labelNetworkInformationsOutput.Size = new System.Drawing.Size(158, 13);
            this.labelNetworkInformationsOutput.TabIndex = 3;
            this.labelNetworkInformationsOutput.Text = "labelNetworkInformationsOutput";
            // 
            // buttonRunInterfacesInfo
            // 
            this.buttonRunInterfacesInfo.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonRunInterfacesInfo.Location = new System.Drawing.Point(387, 178);
            this.buttonRunInterfacesInfo.Name = "buttonRunInterfacesInfo";
            this.buttonRunInterfacesInfo.Size = new System.Drawing.Size(300, 77);
            this.buttonRunInterfacesInfo.TabIndex = 4;
            this.buttonRunInterfacesInfo.Text = "Interfaces Info";
            this.buttonRunInterfacesInfo.UseVisualStyleBackColor = true;
            this.buttonRunInterfacesInfo.Click += new System.EventHandler(this.buttonRunInterfacesInfo_Click);
            // 
            // labelInternetStatus
            // 
            this.labelInternetStatus.AutoSize = true;
            this.labelInternetStatus.Location = new System.Drawing.Point(13, 77);
            this.labelInternetStatus.Name = "labelInternetStatus";
            this.labelInternetStatus.Size = new System.Drawing.Size(76, 13);
            this.labelInternetStatus.TabIndex = 5;
            this.labelInternetStatus.Text = "lnternet status:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.labelInternetStatus);
            this.Controls.Add(this.buttonRunInterfacesInfo);
            this.Controls.Add(this.labelNetworkInformationsOutput);
            this.Controls.Add(this.labelNetworkInformations);
            this.Controls.Add(this.buttonRunPinger);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Network Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunPinger;
        private System.Windows.Forms.Label labelNetworkInformations;
        private System.Windows.Forms.Label labelNetworkInformationsOutput;
        private System.Windows.Forms.Button buttonRunInterfacesInfo;
        private System.Windows.Forms.Label labelInternetStatus;
    }
}