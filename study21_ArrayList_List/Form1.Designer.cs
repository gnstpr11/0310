﻿
namespace study21_ArrayList_List
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "※ 선호하는 항목을 선택해 주세요.";
            // 
            // pbox4
            // 
            this.pbox4.Image = global::study21_ArrayList_List.Properties.Resources._444;
            this.pbox4.Location = new System.Drawing.Point(309, 3);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(98, 121);
            this.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox4.TabIndex = 3;
            this.pbox4.TabStop = false;
            this.pbox4.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox3
            // 
            this.pbox3.Image = global::study21_ArrayList_List.Properties.Resources._333;
            this.pbox3.Location = new System.Drawing.Point(207, 3);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(96, 121);
            this.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox3.TabIndex = 2;
            this.pbox3.TabStop = false;
            this.pbox3.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox2
            // 
            this.pbox2.Image = global::study21_ArrayList_List.Properties.Resources._222;
            this.pbox2.Location = new System.Drawing.Point(105, 3);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(96, 121);
            this.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox2.TabIndex = 1;
            this.pbox2.TabStop = false;
            this.pbox2.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox1
            // 
            this.pbox1.Image = global::study21_ArrayList_List.Properties.Resources._111;
            this.pbox1.Location = new System.Drawing.Point(3, 3);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(96, 121);
            this.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox1.TabIndex = 0;
            this.pbox1.TabStop = false;
            this.pbox1.Click += new System.EventHandler(this.pbox_Click);
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.Location = new System.Drawing.Point(3, 130);
            this.lblPick1.Margin = new System.Windows.Forms.Padding(3);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(96, 14);
            this.lblPick1.TabIndex = 5;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.Location = new System.Drawing.Point(105, 130);
            this.lblPick2.Margin = new System.Windows.Forms.Padding(3);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(96, 14);
            this.lblPick2.TabIndex = 6;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.Location = new System.Drawing.Point(207, 130);
            this.lblPick3.Margin = new System.Windows.Forms.Padding(3);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(96, 14);
            this.lblPick3.TabIndex = 7;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick4
            // 
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.Location = new System.Drawing.Point(309, 130);
            this.lblPick4.Margin = new System.Windows.Forms.Padding(3);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(98, 14);
            this.lblPick4.TabIndex = 8;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Count : ";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(98, 209);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(11, 12);
            this.lblTotalCount.TabIndex = 10;
            this.lblTotalCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "※ List의 Data를 화면에 보여줍니다.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pbox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 147);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(100, 263);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 23;
            this.dgViewList.Size = new System.Drawing.Size(240, 150);
            this.dgViewList.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 431);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.PictureBox pbox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPick1;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgViewList;
    }
}

