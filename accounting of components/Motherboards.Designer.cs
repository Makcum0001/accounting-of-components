namespace Accounting_of_component
{
    partial class Motherboards
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
            this.lblName = new System.Windows.Forms.Label();
            this.tBoxChipset = new System.Windows.Forms.TextBox();
            this.tBoxSocket = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxMaxMemory = new System.Windows.Forms.TextBox();
            this.tBoxNumOfSlots = new System.Windows.Forms.TextBox();
            this.lblSocket = new System.Windows.Forms.Label();
            this.lblChipset = new System.Windows.Forms.Label();
            this.lblMaxVolMem = new System.Windows.Forms.Label();
            this.lblNumOfMemSlots = new System.Windows.Forms.Label();
            this.btnSaveMb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // tBoxChipset
            // 
            this.tBoxChipset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxChipset.Location = new System.Drawing.Point(30, 111);
            this.tBoxChipset.Name = "tBoxChipset";
            this.tBoxChipset.Size = new System.Drawing.Size(194, 24);
            this.tBoxChipset.TabIndex = 1;
            this.tBoxChipset.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBoxSocket
            // 
            this.tBoxSocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxSocket.Location = new System.Drawing.Point(30, 68);
            this.tBoxSocket.Name = "tBoxSocket";
            this.tBoxSocket.Size = new System.Drawing.Size(194, 24);
            this.tBoxSocket.TabIndex = 2;
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxName.Location = new System.Drawing.Point(30, 25);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(194, 24);
            this.tBoxName.TabIndex = 3;
            // 
            // tBoxMaxMemory
            // 
            this.tBoxMaxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxMaxMemory.Location = new System.Drawing.Point(30, 154);
            this.tBoxMaxMemory.Name = "tBoxMaxMemory";
            this.tBoxMaxMemory.Size = new System.Drawing.Size(194, 24);
            this.tBoxMaxMemory.TabIndex = 5;
            // 
            // tBoxNumOfSlots
            // 
            this.tBoxNumOfSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxNumOfSlots.Location = new System.Drawing.Point(30, 197);
            this.tBoxNumOfSlots.Name = "tBoxNumOfSlots";
            this.tBoxNumOfSlots.Size = new System.Drawing.Size(194, 24);
            this.tBoxNumOfSlots.TabIndex = 6;
            // 
            // lblSocket
            // 
            this.lblSocket.AutoSize = true;
            this.lblSocket.Location = new System.Drawing.Point(30, 52);
            this.lblSocket.Name = "lblSocket";
            this.lblSocket.Size = new System.Drawing.Size(37, 13);
            this.lblSocket.TabIndex = 7;
            this.lblSocket.Text = "Сокет";
            // 
            // lblChipset
            // 
            this.lblChipset.AutoSize = true;
            this.lblChipset.Location = new System.Drawing.Point(27, 95);
            this.lblChipset.Name = "lblChipset";
            this.lblChipset.Size = new System.Drawing.Size(44, 13);
            this.lblChipset.TabIndex = 8;
            this.lblChipset.Text = "Чипсет";
            // 
            // lblMaxVolMem
            // 
            this.lblMaxVolMem.AutoSize = true;
            this.lblMaxVolMem.Location = new System.Drawing.Point(27, 138);
            this.lblMaxVolMem.Name = "lblMaxVolMem";
            this.lblMaxVolMem.Size = new System.Drawing.Size(113, 13);
            this.lblMaxVolMem.TabIndex = 9;
            this.lblMaxVolMem.Text = "Макс. объем памяти";
            // 
            // lblNumOfMemSlots
            // 
            this.lblNumOfMemSlots.AutoSize = true;
            this.lblNumOfMemSlots.Location = new System.Drawing.Point(27, 181);
            this.lblNumOfMemSlots.Name = "lblNumOfMemSlots";
            this.lblNumOfMemSlots.Size = new System.Drawing.Size(165, 13);
            this.lblNumOfMemSlots.TabIndex = 10;
            this.lblNumOfMemSlots.Text = "Количество слотов для памяти";
            // 
            // btnSaveMb
            // 
            this.btnSaveMb.Location = new System.Drawing.Point(70, 239);
            this.btnSaveMb.Name = "btnSaveMb";
            this.btnSaveMb.Size = new System.Drawing.Size(108, 37);
            this.btnSaveMb.TabIndex = 11;
            this.btnSaveMb.Text = "Сохранить";
            this.btnSaveMb.UseVisualStyleBackColor = true;
            // 
            // Motherboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 283);
            this.Controls.Add(this.btnSaveMb);
            this.Controls.Add(this.lblNumOfMemSlots);
            this.Controls.Add(this.lblMaxVolMem);
            this.Controls.Add(this.lblChipset);
            this.Controls.Add(this.lblSocket);
            this.Controls.Add(this.tBoxNumOfSlots);
            this.Controls.Add(this.tBoxMaxMemory);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.tBoxSocket);
            this.Controls.Add(this.tBoxChipset);
            this.Controls.Add(this.lblName);
            this.Name = "Motherboards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Motherboards";
            this.Load += new System.EventHandler(this.Motherboards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tBoxChipset;
        private System.Windows.Forms.TextBox tBoxSocket;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxMaxMemory;
        private System.Windows.Forms.TextBox tBoxNumOfSlots;
        private System.Windows.Forms.Label lblSocket;
        private System.Windows.Forms.Label lblChipset;
        private System.Windows.Forms.Label lblMaxVolMem;
        private System.Windows.Forms.Label lblNumOfMemSlots;
        private System.Windows.Forms.Button btnSaveMb;
    }
}