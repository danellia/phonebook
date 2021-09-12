
namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.indexColumn = new System.Windows.Forms.ColumnHeader();
            this.NameColumn = new System.Windows.Forms.ColumnHeader();
            this.PhoneColumn = new System.Windows.Forms.ColumnHeader();
            this.YearColumn = new System.Windows.Forms.ColumnHeader();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexColumn,
            this.NameColumn,
            this.PhoneColumn,
            this.YearColumn});
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(395, 401);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // indexColumn
            // 
            this.indexColumn.Text = "#";
            this.indexColumn.Width = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Фамилия";
            this.NameColumn.Width = 120;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.Text = "Телефон";
            this.PhoneColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneColumn.Width = 120;
            // 
            // YearColumn
            // 
            this.YearColumn.Text = "Год установки";
            this.YearColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YearColumn.Width = 120;
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Location = new System.Drawing.Point(12, 419);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(395, 29);
            this.buttonViewAll.TabIndex = 1;
            this.buttonViewAll.Text = "Огласите весь список";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(12, 454);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(395, 29);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "Выборка";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 495);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PhoneColumn;
        private System.Windows.Forms.ColumnHeader YearColumn;
        private System.Windows.Forms.ColumnHeader indexColumn;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonChoose;
    }
}

