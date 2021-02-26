
namespace AnonChatClient {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.list_messages = new System.Windows.Forms.ListBox();
            this.txtbox_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txtBox_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_symbols = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_messages
            // 
            this.list_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_messages.BackColor = System.Drawing.Color.DimGray;
            this.list_messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_messages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.list_messages.Font = new System.Drawing.Font("FixedsysTTF", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_messages.ForeColor = System.Drawing.Color.White;
            this.list_messages.FormattingEnabled = true;
            this.list_messages.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.list_messages.ItemHeight = 20;
            this.list_messages.Items.AddRange(new object[] {
            "Enter a server\'s IP and hit connect."});
            this.list_messages.Location = new System.Drawing.Point(12, 50);
            this.list_messages.Name = "list_messages";
            this.list_messages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_messages.Size = new System.Drawing.Size(758, 342);
            this.list_messages.TabIndex = 0;
            this.list_messages.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListMessagesDrawItem);
            this.list_messages.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListMessagesMeasureItem);
            // 
            // txtbox_message
            // 
            this.txtbox_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_message.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_message.Font = new System.Drawing.Font("FixedsysTTF", 13F, System.Drawing.FontStyle.Bold);
            this.txtbox_message.ForeColor = System.Drawing.Color.White;
            this.txtbox_message.Location = new System.Drawing.Point(12, 449);
            this.txtbox_message.MaxLength = 200;
            this.txtbox_message.Name = "txtbox_message";
            this.txtbox_message.Size = new System.Drawing.Size(634, 27);
            this.txtbox_message.TabIndex = 1;
            this.txtbox_message.TextChanged += new System.EventHandler(this.TxtMessageTextChanged);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.BackColor = System.Drawing.Color.DimGray;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("FixedsysTTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(660, 446);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(93, 37);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.BtnSendClick);
            // 
            // txtBox_ip
            // 
            this.txtBox_ip.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBox_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ip.Font = new System.Drawing.Font("FixedsysTTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ip.ForeColor = System.Drawing.Color.White;
            this.txtBox_ip.Location = new System.Drawing.Point(53, 13);
            this.txtBox_ip.Name = "txtBox_ip";
            this.txtBox_ip.Size = new System.Drawing.Size(145, 25);
            this.txtBox_ip.TabIndex = 3;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("FixedsysTTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.ForeColor = System.Drawing.Color.White;
            this.lbl_ip.Location = new System.Drawing.Point(8, 15);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(35, 18);
            this.lbl_ip.TabIndex = 4;
            this.lbl_ip.Text = "IP:";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.DimGray;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(210, 9);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(105, 35);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.BtnConnectClick);
            // 
            // lbl_symbols
            // 
            this.lbl_symbols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_symbols.AutoSize = true;
            this.lbl_symbols.Font = new System.Drawing.Font("FixedsysTTF", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_symbols.ForeColor = System.Drawing.Color.White;
            this.lbl_symbols.Location = new System.Drawing.Point(13, 483);
            this.lbl_symbols.Name = "lbl_symbols";
            this.lbl_symbols.Size = new System.Drawing.Size(71, 18);
            this.lbl_symbols.TabIndex = 6;
            this.lbl_symbols.Text = "0 / 200";
            // 
            // Main
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 519);
            this.Controls.Add(this.lbl_symbols);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.txtBox_ip);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtbox_message);
            this.Controls.Add(this.list_messages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(438, 471);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnonChat Client";
            this.Resize += new System.EventHandler(this.MainResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_messages;
        private System.Windows.Forms.TextBox txtbox_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txtBox_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_symbols;
    }
}

