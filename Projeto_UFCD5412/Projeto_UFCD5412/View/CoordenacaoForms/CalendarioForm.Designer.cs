﻿using System.Windows.Forms;

using System.Drawing;
using System;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    partial class CalendarioForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.retroceder_btn = new System.Windows.Forms.Button();
            this.avancar_btn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(52, 32, 52, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(45, 49, 45, 49);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // retroceder_btn
            // 
            this.retroceder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.retroceder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.retroceder_btn.FlatAppearance.BorderSize = 0;
            this.retroceder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder_btn.ForeColor = System.Drawing.Color.White;
            this.retroceder_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retroceder_btn.Location = new System.Drawing.Point(540, 520);
            this.retroceder_btn.Margin = new System.Windows.Forms.Padding(2);
            this.retroceder_btn.Name = "retroceder_btn";
            this.retroceder_btn.Size = new System.Drawing.Size(112, 32);
            this.retroceder_btn.TabIndex = 1;
            this.retroceder_btn.Text = "Retroceder";
            this.retroceder_btn.UseVisualStyleBackColor = false;
            this.retroceder_btn.Click += new System.EventHandler(this.retroceder_btn_Click);
            // 
            // avancar_btn
            // 
            this.avancar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.avancar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.avancar_btn.FlatAppearance.BorderSize = 0;
            this.avancar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avancar_btn.ForeColor = System.Drawing.Color.White;
            this.avancar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avancar_btn.Location = new System.Drawing.Point(675, 520);
            this.avancar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.avancar_btn.Name = "avancar_btn";
            this.avancar_btn.Size = new System.Drawing.Size(112, 32);
            this.avancar_btn.TabIndex = 2;
            this.avancar_btn.Text = "Avançar";
            this.avancar_btn.UseVisualStyleBackColor = false;
            this.avancar_btn.Click += new System.EventHandler(this.avancar_btn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(9, 7);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(124, 30);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Calendário";
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.avancar_btn);
            this.Controls.Add(this.retroceder_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalendarioForm";
            this.Text = "Calendário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button retroceder_btn;
        private System.Windows.Forms.Button avancar_btn;
        private System.Windows.Forms.Label titleLabel;

        private void Retroceder_btn_MouseEnter(object sender, EventArgs e)
        {
            retroceder_btn.BackColor = Color.FromArgb(0, 83, 173);
        }

        private void Retroceder_btn_MouseLeave(object sender, EventArgs e)
        {
            retroceder_btn.BackColor = Color.FromArgb(0, 123, 255);
        }

        private void Avancar_btn_MouseEnter(object sender, EventArgs e)
        {
            avancar_btn.BackColor = Color.FromArgb(0, 83, 173);
        }

        private void Avancar_btn_MouseLeave(object sender, EventArgs e)
        {
            avancar_btn.BackColor = Color.FromArgb(0, 123, 255);
        }
    }
}
