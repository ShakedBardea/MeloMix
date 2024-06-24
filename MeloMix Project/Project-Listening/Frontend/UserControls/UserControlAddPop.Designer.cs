
namespace Project_Listening.Frontend.UserControls
{
    partial class UserControlAddPop
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
            this.textBoxGeographicAffiliation = new System.Windows.Forms.TextBox();
            this.Local = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGeographicAffiliation
            // 
            this.textBoxGeographicAffiliation.Location = new System.Drawing.Point(206, 25);
            this.textBoxGeographicAffiliation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGeographicAffiliation.Multiline = true;
            this.textBoxGeographicAffiliation.Name = "textBoxGeographicAffiliation";
            this.textBoxGeographicAffiliation.Size = new System.Drawing.Size(102, 25);
            this.textBoxGeographicAffiliation.TabIndex = 0;
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Location = new System.Drawing.Point(5, 28);
            this.Local.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(193, 22);
            this.Local.TabIndex = 1;
            this.Local.Text = "Geographic Affiliation:";
            // 
            // UserControlAddPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.Local);
            this.Controls.Add(this.textBoxGeographicAffiliation);
            this.Font = new System.Drawing.Font("Levenim MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAddPop";
            this.Size = new System.Drawing.Size(423, 93);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGeographicAffiliation;
        private System.Windows.Forms.Label Local;
    }
}
