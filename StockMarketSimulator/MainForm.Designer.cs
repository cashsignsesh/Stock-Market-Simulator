﻿/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 1/4/2021
 * Time: 2:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StockMarketSimulator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.marketTabs = new System.Windows.Forms.TabControl();
			this.portfolioPanel = new System.Windows.Forms.Panel();
			this.cashAddedLbl = new System.Windows.Forms.Label();
			this.lockAddingCashBtn = new System.Windows.Forms.Button();
			this.toggleWatchingBtn = new System.Windows.Forms.Button();
			this.addMarketTextBox = new System.Windows.Forms.TextBox();
			this.addMarketBtn = new System.Windows.Forms.Button();
			this.addCashTextBox = new System.Windows.Forms.TextBox();
			this.yourCashLabel = new System.Windows.Forms.Label();
			this.addCashBtn = new System.Windows.Forms.Button();
			this.portfolioTitleLabel = new System.Windows.Forms.Label();
			this.statsLbl = new System.Windows.Forms.Label();
			this.stocksPurchasedLbl = new System.Windows.Forms.Label();
			this.profitLbl = new System.Windows.Forms.Label();
			this.portfolioPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// marketTabs
			// 
			this.marketTabs.Location = new System.Drawing.Point(12, 12);
			this.marketTabs.Name = "marketTabs";
			this.marketTabs.SelectedIndex = 0;
			this.marketTabs.Size = new System.Drawing.Size(554, 505);
			this.marketTabs.TabIndex = 0;
			// 
			// portfolioPanel
			// 
			this.portfolioPanel.Controls.Add(this.profitLbl);
			this.portfolioPanel.Controls.Add(this.stocksPurchasedLbl);
			this.portfolioPanel.Controls.Add(this.statsLbl);
			this.portfolioPanel.Controls.Add(this.cashAddedLbl);
			this.portfolioPanel.Controls.Add(this.lockAddingCashBtn);
			this.portfolioPanel.Controls.Add(this.toggleWatchingBtn);
			this.portfolioPanel.Controls.Add(this.addMarketTextBox);
			this.portfolioPanel.Controls.Add(this.addMarketBtn);
			this.portfolioPanel.Controls.Add(this.addCashTextBox);
			this.portfolioPanel.Controls.Add(this.yourCashLabel);
			this.portfolioPanel.Controls.Add(this.addCashBtn);
			this.portfolioPanel.Controls.Add(this.portfolioTitleLabel);
			this.portfolioPanel.Location = new System.Drawing.Point(572, 12);
			this.portfolioPanel.Name = "portfolioPanel";
			this.portfolioPanel.Size = new System.Drawing.Size(229, 505);
			this.portfolioPanel.TabIndex = 1;
			// 
			// cashAddedLbl
			// 
			this.cashAddedLbl.Location = new System.Drawing.Point(3, 89);
			this.cashAddedLbl.Name = "cashAddedLbl";
			this.cashAddedLbl.Size = new System.Drawing.Size(223, 15);
			this.cashAddedLbl.TabIndex = 8;
			this.cashAddedLbl.Text = "Cash added: 0";
			// 
			// lockAddingCashBtn
			// 
			this.lockAddingCashBtn.Location = new System.Drawing.Point(117, 42);
			this.lockAddingCashBtn.Name = "lockAddingCashBtn";
			this.lockAddingCashBtn.Size = new System.Drawing.Size(109, 33);
			this.lockAddingCashBtn.TabIndex = 7;
			this.lockAddingCashBtn.Text = "Lock adding cash";
			this.lockAddingCashBtn.UseVisualStyleBackColor = true;
			this.lockAddingCashBtn.Click += new System.EventHandler(this.LockAddingCashBtnClick);
			// 
			// toggleWatchingBtn
			// 
			this.toggleWatchingBtn.Location = new System.Drawing.Point(117, 3);
			this.toggleWatchingBtn.Name = "toggleWatchingBtn";
			this.toggleWatchingBtn.Size = new System.Drawing.Size(109, 33);
			this.toggleWatchingBtn.TabIndex = 6;
			this.toggleWatchingBtn.Text = "Stop watching";
			this.toggleWatchingBtn.UseVisualStyleBackColor = true;
			this.toggleWatchingBtn.Click += new System.EventHandler(this.ToggleWatchingBtnClick);
			// 
			// addMarketTextBox
			// 
			this.addMarketTextBox.Location = new System.Drawing.Point(3, 419);
			this.addMarketTextBox.Name = "addMarketTextBox";
			this.addMarketTextBox.Size = new System.Drawing.Size(125, 20);
			this.addMarketTextBox.TabIndex = 5;
			// 
			// addMarketBtn
			// 
			this.addMarketBtn.Location = new System.Drawing.Point(134, 419);
			this.addMarketBtn.Name = "addMarketBtn";
			this.addMarketBtn.Size = new System.Drawing.Size(92, 20);
			this.addMarketBtn.TabIndex = 4;
			this.addMarketBtn.Text = "Add market";
			this.addMarketBtn.UseVisualStyleBackColor = true;
			this.addMarketBtn.Click += new System.EventHandler(this.AddMarketBtnClick);
			// 
			// addCashTextBox
			// 
			this.addCashTextBox.Location = new System.Drawing.Point(3, 445);
			this.addCashTextBox.Name = "addCashTextBox";
			this.addCashTextBox.Size = new System.Drawing.Size(125, 20);
			this.addCashTextBox.TabIndex = 3;
			// 
			// yourCashLabel
			// 
			this.yourCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yourCashLabel.Location = new System.Drawing.Point(1, 474);
			this.yourCashLabel.Name = "yourCashLabel";
			this.yourCashLabel.Size = new System.Drawing.Size(225, 29);
			this.yourCashLabel.TabIndex = 2;
			this.yourCashLabel.Text = "Your cash:";
			// 
			// addCashBtn
			// 
			this.addCashBtn.Location = new System.Drawing.Point(134, 445);
			this.addCashBtn.Name = "addCashBtn";
			this.addCashBtn.Size = new System.Drawing.Size(92, 20);
			this.addCashBtn.TabIndex = 1;
			this.addCashBtn.Text = "Add cash";
			this.addCashBtn.UseVisualStyleBackColor = true;
			this.addCashBtn.Click += new System.EventHandler(this.AddCashBtnClick);
			// 
			// portfolioTitleLabel
			// 
			this.portfolioTitleLabel.Location = new System.Drawing.Point(3, 3);
			this.portfolioTitleLabel.Name = "portfolioTitleLabel";
			this.portfolioTitleLabel.Size = new System.Drawing.Size(59, 17);
			this.portfolioTitleLabel.TabIndex = 0;
			this.portfolioTitleLabel.Text = "Portfolio";
			// 
			// statsLbl
			// 
			this.statsLbl.Location = new System.Drawing.Point(3, 76);
			this.statsLbl.Name = "statsLbl";
			this.statsLbl.Size = new System.Drawing.Size(223, 13);
			this.statsLbl.TabIndex = 9;
			this.statsLbl.Text = "Stats";
			// 
			// stocksPurchasedLbl
			// 
			this.stocksPurchasedLbl.Location = new System.Drawing.Point(3, 104);
			this.stocksPurchasedLbl.Name = "stocksPurchasedLbl";
			this.stocksPurchasedLbl.Size = new System.Drawing.Size(223, 15);
			this.stocksPurchasedLbl.TabIndex = 10;
			this.stocksPurchasedLbl.Text = "Stocks purchased: 0";
			// 
			// profitLbl
			// 
			this.profitLbl.Location = new System.Drawing.Point(3, 119);
			this.profitLbl.Name = "profitLbl";
			this.profitLbl.Size = new System.Drawing.Size(223, 15);
			this.profitLbl.TabIndex = 11;
			this.profitLbl.Text = "Profit: 0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(813, 530);
			this.Controls.Add(this.portfolioPanel);
			this.Controls.Add(this.marketTabs);
			this.Name = "MainForm";
			this.Text = "StockMarketSimulator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.portfolioPanel.ResumeLayout(false);
			this.portfolioPanel.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label profitLbl;
		private System.Windows.Forms.Label statsLbl;
		private System.Windows.Forms.Label stocksPurchasedLbl;
		private System.Windows.Forms.Label cashAddedLbl;
		private System.Windows.Forms.Button lockAddingCashBtn;
		private System.Windows.Forms.Button toggleWatchingBtn;
		private System.Windows.Forms.Button addCashBtn;
		private System.Windows.Forms.Label yourCashLabel;
		private System.Windows.Forms.TextBox addCashTextBox;
		private System.Windows.Forms.Button addMarketBtn;
		private System.Windows.Forms.TextBox addMarketTextBox;
		private System.Windows.Forms.Label portfolioTitleLabel;
		private System.Windows.Forms.Panel portfolioPanel;
		private System.Windows.Forms.TabControl marketTabs;
		
	}
}
