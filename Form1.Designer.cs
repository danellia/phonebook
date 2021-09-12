
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
            this.listViewAll = new System.Windows.Forms.ListView();
            this.indexColumnAll = new System.Windows.Forms.ColumnHeader();
            this.nameColumnAll = new System.Windows.Forms.ColumnHeader();
            this.phoneColumnAll = new System.Windows.Forms.ColumnHeader();
            this.yearColumnAll = new System.Windows.Forms.ColumnHeader();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.listViewChoose = new System.Windows.Forms.ListView();
            this.indexColumnChoose = new System.Windows.Forms.ColumnHeader();
            this.nameColumnChoose = new System.Windows.Forms.ColumnHeader();
            this.phoneColumnChoose = new System.Windows.Forms.ColumnHeader();
            this.yearColumnChoose = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewAll
            // 
            this.listViewAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexColumnAll,
            this.nameColumnAll,
            this.phoneColumnAll,
            this.yearColumnAll});
            this.listViewAll.FullRowSelect = true;
            this.listViewAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAll.HideSelection = false;
            this.listViewAll.Location = new System.Drawing.Point(12, 12);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(395, 401);
            this.listViewAll.TabIndex = 0;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            this.listViewAll.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            // 
            // indexColumnAll
            // 
            this.indexColumnAll.Text = "#";
            this.indexColumnAll.Width = 0;
            // 
            // nameColumnAll
            // 
            this.nameColumnAll.Text = "Фамилия";
            this.nameColumnAll.Width = 120;
            // 
            // phoneColumnAll
            // 
            this.phoneColumnAll.Text = "Телефон";
            this.phoneColumnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneColumnAll.Width = 120;
            // 
            // yearColumnAll
            // 
            this.yearColumnAll.Text = "Год установки";
            this.yearColumnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearColumnAll.Width = 120;
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
            this.buttonChoose.Enabled = false;
            this.buttonChoose.Location = new System.Drawing.Point(413, 419);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(395, 29);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "Выборка";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // listViewChoose
            // 
            this.listViewChoose.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexColumnChoose,
            this.nameColumnChoose,
            this.phoneColumnChoose,
            this.yearColumnChoose});
            this.listViewChoose.FullRowSelect = true;
            this.listViewChoose.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewChoose.HideSelection = false;
            this.listViewChoose.Location = new System.Drawing.Point(413, 12);
            this.listViewChoose.Name = "listViewChoose";
            this.listViewChoose.Size = new System.Drawing.Size(395, 401);
            this.listViewChoose.TabIndex = 3;
            this.listViewChoose.UseCompatibleStateImageBehavior = false;
            this.listViewChoose.View = System.Windows.Forms.View.Details;
            // 
            // indexColumnChoose
            // 
            this.indexColumnChoose.Text = "#";
            this.indexColumnChoose.Width = 0;
            // 
            // nameColumnChoose
            // 
            this.nameColumnChoose.Text = "Фамилия";
            this.nameColumnChoose.Width = 120;
            // 
            // phoneColumnChoose
            // 
            this.phoneColumnChoose.Text = "Телефон";
            this.phoneColumnChoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneColumnChoose.Width = 120;
            // 
            // yearColumnChoose
            // 
            this.yearColumnChoose.Text = "Год установки";
            this.yearColumnChoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearColumnChoose.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 458);
            this.Controls.Add(this.listViewChoose);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.listViewAll);
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.ColumnHeader nameColumnAll;
        private System.Windows.Forms.ColumnHeader phoneColumnAll;
        private System.Windows.Forms.ColumnHeader yearColumnAll;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.ColumnHeader indexColumnAll;
        private System.Windows.Forms.ListView listViewChoose;
        private System.Windows.Forms.ColumnHeader indexColumnChoose;
        private System.Windows.Forms.ColumnHeader nameColumnChoose;
        private System.Windows.Forms.ColumnHeader phoneColumnChoose;
        private System.Windows.Forms.ColumnHeader yearColumnChoose;
    }
}

