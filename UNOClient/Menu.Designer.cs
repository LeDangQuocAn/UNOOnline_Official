namespace UnoOnline
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnJoinGame = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnStore = new System.Windows.Forms.Button();
            this.BtnRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnJoinGame
            // 
            this.BtnJoinGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoinGame.Location = new System.Drawing.Point(329, 187);
            this.BtnJoinGame.Name = "BtnJoinGame";
            this.BtnJoinGame.Size = new System.Drawing.Size(140, 140);
            this.BtnJoinGame.TabIndex = 0;
            this.BtnJoinGame.Text = "Join room";
            this.BtnJoinGame.UseVisualStyleBackColor = true;
            this.BtnJoinGame.Click += new System.EventHandler(this.BtnJoinGame_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(303, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnStore
            // 
            this.BtnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStore.Location = new System.Drawing.Point(541, 212);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Size = new System.Drawing.Size(100, 100);
            this.BtnStore.TabIndex = 2;
            this.BtnStore.Text = "Store";
            this.BtnStore.UseVisualStyleBackColor = true;
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // BtnRules
            // 
            this.BtnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRules.Location = new System.Drawing.Point(160, 213);
            this.BtnRules.Name = "BtnRules";
            this.BtnRules.Size = new System.Drawing.Size(100, 100);
            this.BtnRules.TabIndex = 3;
            this.BtnRules.Text = "Rules";
            this.BtnRules.UseVisualStyleBackColor = true;
            this.BtnRules.Click += new System.EventHandler(this.BtnRules_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRules);
            this.Controls.Add(this.BtnStore);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnJoinGame);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnJoinGame;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnStore;
        private System.Windows.Forms.Button BtnRules;
    }
}