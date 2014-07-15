namespace Manufaktura.Controls.Winforms.Test
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
            this.noteViewer1 = new Manufaktura.Controls.WinForms.NoteViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.noteViewer2 = new Manufaktura.Controls.WinForms.NoteViewer();
            this.noteViewer3 = new Manufaktura.Controls.WinForms.NoteViewer();
            this.SuspendLayout();
            // 
            // noteViewer1
            // 
            this.noteViewer1.DataSource = null;
            this.noteViewer1.Location = new System.Drawing.Point(12, 12);
            this.noteViewer1.Name = "noteViewer1";
            this.noteViewer1.Size = new System.Drawing.Size(760, 88);
            this.noteViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(697, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wczytaj ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noteViewer2
            // 
            this.noteViewer2.DataSource = null;
            this.noteViewer2.Location = new System.Drawing.Point(12, 106);
            this.noteViewer2.Name = "noteViewer2";
            this.noteViewer2.Size = new System.Drawing.Size(760, 88);
            this.noteViewer2.TabIndex = 2;
            // 
            // noteViewer3
            // 
            this.noteViewer3.DataSource = null;
            this.noteViewer3.Location = new System.Drawing.Point(12, 221);
            this.noteViewer3.Name = "noteViewer3";
            this.noteViewer3.Size = new System.Drawing.Size(760, 88);
            this.noteViewer3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 360);
            this.Controls.Add(this.noteViewer3);
            this.Controls.Add(this.noteViewer2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noteViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WinForms.NoteViewer noteViewer1;
        private System.Windows.Forms.Button button1;
        private WinForms.NoteViewer noteViewer2;
        private WinForms.NoteViewer noteViewer3;
    }
}

