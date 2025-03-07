﻿namespace MissionPlanner.Controls
{
    partial class PluginUI
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
            this.labelWarning = new System.Windows.Forms.Label();
            this.but_errors = new MissionPlanner.Controls.MyButton();
            this.bSave = new MissionPlanner.Controls.MyButton();
            this.dgvPlugins = new MissionPlanner.Controls.MyDataGridView();
            this.pluginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginDll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlugins)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(103, 9);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(274, 30);
            this.labelWarning.TabIndex = 4;
            this.labelWarning.Text = "Enable/Disable settings changed, till restart \rnot loaded but enabled plugins wil" +
    "l not shown!";
            // 
            // but_errors
            // 
            this.but_errors.Location = new System.Drawing.Point(369, 9);
            this.but_errors.Margin = new System.Windows.Forms.Padding(2);
            this.but_errors.Name = "but_errors";
            this.but_errors.Size = new System.Drawing.Size(85, 36);
            this.but_errors.TabIndex = 5;
            this.but_errors.Text = "Show Errors";
            this.but_errors.UseVisualStyleBackColor = true;
            this.but_errors.Click += new System.EventHandler(this.but_errors_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(13, 9);
            this.bSave.Margin = new System.Windows.Forms.Padding(2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(85, 36);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save && Close";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dgvPlugins
            // 
            this.dgvPlugins.AllowUserToAddRows = false;
            this.dgvPlugins.AllowUserToDeleteRows = false;
            this.dgvPlugins.AllowUserToResizeRows = false;
            this.dgvPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlugins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlugins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pluginName,
            this.pluginAuthor,
            this.pluginVersion,
            this.pluginDll,
            this.pluginEnabled});
            this.dgvPlugins.Location = new System.Drawing.Point(10, 59);
            this.dgvPlugins.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlugins.Name = "dgvPlugins";
            this.dgvPlugins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPlugins.RowTemplate.Height = 24;
            this.dgvPlugins.Size = new System.Drawing.Size(764, 350);
            this.dgvPlugins.TabIndex = 0;
            this.dgvPlugins.RowHeadersWidthChanged += new System.EventHandler(this.dgvPlugins_RowHeadersWidthChanged);
            this.dgvPlugins.SelectionChanged += new System.EventHandler(this.dgvPlugins_SelectionChanged);
            // 
            // pluginName
            // 
            this.pluginName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pluginName.HeaderText = "Plugin Name";
            this.pluginName.MinimumWidth = 6;
            this.pluginName.Name = "pluginName";
            this.pluginName.ReadOnly = true;
            this.pluginName.Width = 106;
            // 
            // pluginAuthor
            // 
            this.pluginAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pluginAuthor.HeaderText = "Author";
            this.pluginAuthor.MinimumWidth = 6;
            this.pluginAuthor.Name = "pluginAuthor";
            this.pluginAuthor.ReadOnly = true;
            this.pluginAuthor.Width = 71;
            // 
            // pluginVersion
            // 
            this.pluginVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pluginVersion.HeaderText = "Version";
            this.pluginVersion.MinimumWidth = 6;
            this.pluginVersion.Name = "pluginVersion";
            this.pluginVersion.ReadOnly = true;
            this.pluginVersion.Width = 74;
            // 
            // pluginDll
            // 
            this.pluginDll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pluginDll.HeaderText = "FileName";
            this.pluginDll.MinimumWidth = 6;
            this.pluginDll.Name = "pluginDll";
            this.pluginDll.ReadOnly = true;
            this.pluginDll.Width = 87;
            // 
            // pluginEnabled
            // 
            this.pluginEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pluginEnabled.HeaderText = "Enabled";
            this.pluginEnabled.MinimumWidth = 6;
            this.pluginEnabled.Name = "pluginEnabled";
            this.pluginEnabled.Width = 60;
            // 
            // PluginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.but_errors);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dgvPlugins);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PluginUI";
            this.Text = "PluginManager";
            this.Shown += new System.EventHandler(this.PluginUI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlugins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDataGridView dgvPlugins;
        private MyButton bSave;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginDll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pluginEnabled;
        private MyButton but_errors;
    }
}