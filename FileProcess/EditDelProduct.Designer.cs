
namespace FileProcess
{
    partial class EditDelProduct
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
            this.cboxProlist = new System.Windows.Forms.ComboBox();
            this.dgwProlist = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProlist)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxProlist
            // 
            this.cboxProlist.FormattingEnabled = true;
            this.cboxProlist.Location = new System.Drawing.Point(12, 12);
            this.cboxProlist.Name = "cboxProlist";
            this.cboxProlist.Size = new System.Drawing.Size(199, 23);
            this.cboxProlist.TabIndex = 0;
            this.cboxProlist.SelectedIndexChanged += new System.EventHandler(this.cboxProlist_SelectedIndexChanged);
            // 
            // dgwProlist
            // 
            this.dgwProlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProlist.Location = new System.Drawing.Point(12, 70);
            this.dgwProlist.Name = "dgwProlist";
            this.dgwProlist.RowTemplate.Height = 25;
            this.dgwProlist.Size = new System.Drawing.Size(398, 220);
            this.dgwProlist.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Satış";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditDelProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 302);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgwProlist);
            this.Controls.Add(this.cboxProlist);
            this.Name = "EditDelProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditDelProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxProlist;
        private System.Windows.Forms.DataGridView dgwProlist;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}