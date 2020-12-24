﻿namespace BlackJackWinform
{
    partial class BlackJackForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDoubleDown = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBankroll = new System.Windows.Forms.Label();
            this.tbBet = new System.Windows.Forms.MaskedTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dealerLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvCountingScenarios = new System.Windows.Forms.DataGridView();
            this.dgvShoeRemaining = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.colMethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTwoThroughNine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenThroughKing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountingScenarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoeRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(23, 7);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Location = new System.Drawing.Point(104, 7);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 4;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDoubleDown
            // 
            this.btnDoubleDown.Enabled = false;
            this.btnDoubleDown.Location = new System.Drawing.Point(266, 7);
            this.btnDoubleDown.Name = "btnDoubleDown";
            this.btnDoubleDown.Size = new System.Drawing.Size(84, 23);
            this.btnDoubleDown.TabIndex = 5;
            this.btnDoubleDown.Text = "Double Down";
            this.btnDoubleDown.UseVisualStyleBackColor = true;
            this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Enabled = false;
            this.btnSplit.Location = new System.Drawing.Point(185, 7);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(313, 585);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(131, 23);
            this.btnBet.TabIndex = 11;
            this.btnBet.Text = "Bet and Deal!";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(301, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bankroll:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(215, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dealer hits on 16, stands on soft 17";
            // 
            // lblBankroll
            // 
            this.lblBankroll.AutoSize = true;
            this.lblBankroll.BackColor = System.Drawing.Color.Transparent;
            this.lblBankroll.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankroll.ForeColor = System.Drawing.Color.Yellow;
            this.lblBankroll.Location = new System.Drawing.Point(397, 638);
            this.lblBankroll.Name = "lblBankroll";
            this.lblBankroll.Size = new System.Drawing.Size(41, 29);
            this.lblBankroll.TabIndex = 20;
            this.lblBankroll.Text = "[0]";
            this.lblBankroll.Click += new System.EventHandler(this.lblBankroll_Click);
            // 
            // tbBet
            // 
            this.tbBet.BackColor = System.Drawing.Color.Black;
            this.tbBet.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBet.ForeColor = System.Drawing.Color.Yellow;
            this.tbBet.Location = new System.Drawing.Point(331, 613);
            this.tbBet.Mask = "#####";
            this.tbBet.Name = "tbBet";
            this.tbBet.Size = new System.Drawing.Size(75, 26);
            this.tbBet.TabIndex = 22;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cards.bmp");
            // 
            // dealerLayoutPanel
            // 
            this.dealerLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.dealerLayoutPanel.Location = new System.Drawing.Point(183, 12);
            this.dealerLayoutPanel.Name = "dealerLayoutPanel";
            this.dealerLayoutPanel.Size = new System.Drawing.Size(481, 237);
            this.dealerLayoutPanel.TabIndex = 33;
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.Location = new System.Drawing.Point(183, 281);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(486, 253);
            this.layout.TabIndex = 34;
            // 
            // dgvCountingScenarios
            // 
            this.dgvCountingScenarios.AllowUserToAddRows = false;
            this.dgvCountingScenarios.AllowUserToDeleteRows = false;
            this.dgvCountingScenarios.AllowUserToResizeColumns = false;
            this.dgvCountingScenarios.AllowUserToResizeRows = false;
            this.dgvCountingScenarios.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCountingScenarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCountingScenarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCountingScenarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle97.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle97.Font = new System.Drawing.Font("HP Simplified", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle97.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle97.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle97.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle97.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCountingScenarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle97;
            this.dgvCountingScenarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountingScenarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMethodName,
            this.colCurrentCount});
            dataGridViewCellStyle100.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle100.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle100.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle100.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle100.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle100.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCountingScenarios.DefaultCellStyle = dataGridViewCellStyle100;
            this.dgvCountingScenarios.EnableHeadersVisualStyles = false;
            this.dgvCountingScenarios.GridColor = System.Drawing.Color.Black;
            this.dgvCountingScenarios.Location = new System.Drawing.Point(14, 281);
            this.dgvCountingScenarios.MultiSelect = false;
            this.dgvCountingScenarios.Name = "dgvCountingScenarios";
            this.dgvCountingScenarios.ReadOnly = true;
            this.dgvCountingScenarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle101.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle101.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCountingScenarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle101;
            this.dgvCountingScenarios.RowHeadersWidth = 4;
            this.dgvCountingScenarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCountingScenarios.RowTemplate.ReadOnly = true;
            this.dgvCountingScenarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCountingScenarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCountingScenarios.ShowCellErrors = false;
            this.dgvCountingScenarios.ShowCellToolTips = false;
            this.dgvCountingScenarios.ShowEditingIcon = false;
            this.dgvCountingScenarios.ShowRowErrors = false;
            this.dgvCountingScenarios.Size = new System.Drawing.Size(275, 269);
            this.dgvCountingScenarios.TabIndex = 36;
            // 
            // dgvShoeRemaining
            // 
            this.dgvShoeRemaining.AllowUserToAddRows = false;
            this.dgvShoeRemaining.AllowUserToDeleteRows = false;
            this.dgvShoeRemaining.AllowUserToResizeColumns = false;
            this.dgvShoeRemaining.AllowUserToResizeRows = false;
            this.dgvShoeRemaining.BackgroundColor = System.Drawing.Color.Black;
            this.dgvShoeRemaining.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvShoeRemaining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle102.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("HP Simplified", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle102.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShoeRemaining.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle102;
            this.dgvShoeRemaining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoeRemaining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSuit,
            this.colTwoThroughNine,
            this.colTenThroughKing,
            this.colAce});
            this.dgvShoeRemaining.EnableHeadersVisualStyles = false;
            this.dgvShoeRemaining.GridColor = System.Drawing.Color.Black;
            this.dgvShoeRemaining.Location = new System.Drawing.Point(3, 87);
            this.dgvShoeRemaining.Name = "dgvShoeRemaining";
            this.dgvShoeRemaining.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle107.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle107.Font = new System.Drawing.Font("HP Simplified", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle107.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle107.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle107.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShoeRemaining.RowHeadersDefaultCellStyle = dataGridViewCellStyle107;
            this.dgvShoeRemaining.RowHeadersWidth = 4;
            this.dgvShoeRemaining.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle108.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle108.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle108.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle108.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle108.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dgvShoeRemaining.RowsDefaultCellStyle = dataGridViewCellStyle108;
            this.dgvShoeRemaining.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvShoeRemaining.ShowCellErrors = false;
            this.dgvShoeRemaining.ShowCellToolTips = false;
            this.dgvShoeRemaining.ShowEditingIcon = false;
            this.dgvShoeRemaining.ShowRowErrors = false;
            this.dgvShoeRemaining.Size = new System.Drawing.Size(312, 174);
            this.dgvShoeRemaining.TabIndex = 37;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 672);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Panel1.Controls.Add(this.pnlAction);
            this.splitContainer.Panel1.Controls.Add(this.dealerLayoutPanel);
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.tbBet);
            this.splitContainer.Panel1.Controls.Add(this.layout);
            this.splitContainer.Panel1.Controls.Add(this.lblBankroll);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.btnBet);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.dgvShoeRemaining);
            this.splitContainer.Panel2.Controls.Add(this.dgvCountingScenarios);
            this.splitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer.Size = new System.Drawing.Size(995, 672);
            this.splitContainer.SplitterDistance = 673;
            this.splitContainer.TabIndex = 39;
            // 
            // colMethodName
            // 
            this.colMethodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMethodName.DataPropertyName = "StrategyName";
            dataGridViewCellStyle98.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMethodName.DefaultCellStyle = dataGridViewCellStyle98;
            this.colMethodName.HeaderText = "Strategy";
            this.colMethodName.Name = "colMethodName";
            this.colMethodName.ReadOnly = true;
            this.colMethodName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCurrentCount
            // 
            this.colCurrentCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurrentCount.DataPropertyName = "CurrentCount";
            dataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCurrentCount.DefaultCellStyle = dataGridViewCellStyle99;
            this.colCurrentCount.HeaderText = "Count";
            this.colCurrentCount.Name = "colCurrentCount";
            this.colCurrentCount.ReadOnly = true;
            // 
            // colSuit
            // 
            this.colSuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuit.DataPropertyName = "Suit";
            dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle103.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle103.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle103.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle103.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle103.SelectionForeColor = System.Drawing.Color.Yellow;
            this.colSuit.DefaultCellStyle = dataGridViewCellStyle103;
            this.colSuit.HeaderText = "Suit";
            this.colSuit.Name = "colSuit";
            this.colSuit.ReadOnly = true;
            this.colSuit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTwoThroughNine
            // 
            this.colTwoThroughNine.DataPropertyName = "TwoThroughNineCount";
            dataGridViewCellStyle104.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle104.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle104.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle104.SelectionForeColor = System.Drawing.Color.Yellow;
            this.colTwoThroughNine.DefaultCellStyle = dataGridViewCellStyle104;
            this.colTwoThroughNine.HeaderText = "2 - 9";
            this.colTwoThroughNine.Name = "colTwoThroughNine";
            this.colTwoThroughNine.ReadOnly = true;
            this.colTwoThroughNine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTwoThroughNine.Width = 65;
            // 
            // colTenThroughKing
            // 
            this.colTenThroughKing.DataPropertyName = "TenThroughKingCount";
            dataGridViewCellStyle105.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenThroughKing.DefaultCellStyle = dataGridViewCellStyle105;
            this.colTenThroughKing.HeaderText = "10 - K";
            this.colTenThroughKing.Name = "colTenThroughKing";
            this.colTenThroughKing.ReadOnly = true;
            this.colTenThroughKing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenThroughKing.Width = 75;
            // 
            // colAce
            // 
            this.colAce.DataPropertyName = "AcesCount";
            dataGridViewCellStyle106.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAce.DefaultCellStyle = dataGridViewCellStyle106;
            this.colAce.HeaderText = "Aces";
            this.colAce.Name = "colAce";
            this.colAce.ReadOnly = true;
            this.colAce.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAce.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cards Remaining:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(10, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Counts:";
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnStand);
            this.pnlAction.Controls.Add(this.btnSplit);
            this.pnlAction.Controls.Add(this.btnHit);
            this.pnlAction.Controls.Add(this.btnDoubleDown);
            this.pnlAction.Location = new System.Drawing.Point(206, 545);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(373, 35);
            this.pnlAction.TabIndex = 35;
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 672);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BlackJackForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackJackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountingScenarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoeRemaining)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnHit;
        public System.Windows.Forms.Button btnStand;
        public System.Windows.Forms.Button btnDoubleDown;
        public System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBankroll;
        private System.Windows.Forms.MaskedTextBox tbBet;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel dealerLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.DataGridView dgvCountingScenarios;
        private System.Windows.Forms.DataGridView dgvShoeRemaining;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMethodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTwoThroughNine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThroughKing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAction;
    }
}
