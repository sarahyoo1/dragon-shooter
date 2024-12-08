
namespace cs_final
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.StartGame_btn = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.startMenuMusic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMenuMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // StartGame_btn
            // 
            this.StartGame_btn.Font = new System.Drawing.Font("HY견고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartGame_btn.Location = new System.Drawing.Point(328, 314);
            this.StartGame_btn.Name = "StartGame_btn";
            this.StartGame_btn.Size = new System.Drawing.Size(152, 48);
            this.StartGame_btn.TabIndex = 0;
            this.StartGame_btn.Text = "Start Game";
            this.StartGame_btn.UseVisualStyleBackColor = true;
            this.StartGame_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(149, 208);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(512, 54);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "The Dragon Shooter";
            // 
            // startMenuMusic
            // 
            this.startMenuMusic.Enabled = true;
            this.startMenuMusic.Location = new System.Drawing.Point(12, 12);
            this.startMenuMusic.Name = "startMenuMusic";
            this.startMenuMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("startMenuMusic.OcxState")));
            this.startMenuMusic.Size = new System.Drawing.Size(75, 23);
            this.startMenuMusic.TabIndex = 5;
            this.startMenuMusic.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startMenuMusic);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.StartGame_btn);
            this.Name = "Form2";
            this.Text = "Dragon Shooter";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMenuMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button StartGame_btn;
        private AxWMPLib.AxWindowsMediaPlayer startMenuMusic;
    }
}