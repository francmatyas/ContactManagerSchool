
namespace ContactManager
{
    partial class ContactWindow
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
            this.contactsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsGrid
            // 
            this.contactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGrid.Location = new System.Drawing.Point(12, 12);
            this.contactsGrid.Name = "contactsGrid";
            this.contactsGrid.RowTemplate.Height = 25;
            this.contactsGrid.Size = new System.Drawing.Size(159, 426);
            this.contactsGrid.TabIndex = 0;
            // 
            // ContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactsGrid);
            this.Name = "ContactWindow";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.ContactWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactsGrid;
    }
}