namespace ExDragAndDrop
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
            this.listDestinatie = new System.Windows.Forms.ListBox();
            this.listSursa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listDestinatie
            // 
            this.listDestinatie.AllowDrop = true;
            this.listDestinatie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDestinatie.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDestinatie.FormattingEnabled = true;
            this.listDestinatie.ItemHeight = 27;
            this.listDestinatie.Items.AddRange(new object[] {
            "Destinatie"});
            this.listDestinatie.Location = new System.Drawing.Point(85, 231);
            this.listDestinatie.Name = "listDestinatie";
            this.listDestinatie.Size = new System.Drawing.Size(235, 108);
            this.listDestinatie.TabIndex = 15;
            this.listDestinatie.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDestinatie_DragDrop);
            this.listDestinatie.DragEnter += new System.Windows.Forms.DragEventHandler(this.listDestinatie_DragEnter);
            this.listDestinatie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listDestinatie_MouseDown);
            // 
            // listSursa
            // 
            this.listSursa.AllowDrop = true;
            this.listSursa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSursa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSursa.FormattingEnabled = true;
            this.listSursa.ItemHeight = 27;
            this.listSursa.Items.AddRange(new object[] {
            "Sursa"});
            this.listSursa.Location = new System.Drawing.Point(490, 231);
            this.listSursa.Name = "listSursa";
            this.listSursa.Size = new System.Drawing.Size(232, 108);
            this.listSursa.TabIndex = 15;
            this.listSursa.DragDrop += new System.Windows.Forms.DragEventHandler(this.listSursa_DragDrop);
            this.listSursa.DragEnter += new System.Windows.Forms.DragEventHandler(this.listSursa_DragEnter);
            this.listSursa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listSursa_MouseDown);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1018, 646);
            this.Controls.Add(this.listSursa);
            this.Controls.Add(this.listDestinatie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDestinatie;
        private System.Windows.Forms.ListBox listSursa;
    }
}

