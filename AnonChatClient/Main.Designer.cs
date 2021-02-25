
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
            this.list_messages = new System.Windows.Forms.ListBox();
            this.txtbox_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_messages
            // 
            this.list_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_messages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_messages.FormattingEnabled = true;
            this.list_messages.ImeMode = System.Windows.Forms.ImeMode.On;
            this.list_messages.ItemHeight = 19;
            this.list_messages.Location = new System.Drawing.Point(12, 12);
            this.list_messages.Name = "list_messages";
            this.list_messages.Size = new System.Drawing.Size(639, 346);
            this.list_messages.TabIndex = 0;
            // 
            // txtbox_message
            // 
            this.txtbox_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_message.Location = new System.Drawing.Point(12, 389);
            this.txtbox_message.MaxLength = 200;
            this.txtbox_message.Name = "txtbox_message";
            this.txtbox_message.Size = new System.Drawing.Size(515, 20);
            this.txtbox_message.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(543, 374);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(93, 40);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.BtnSendClick);
            // 
            // Main
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 459);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtbox_message);
            this.Controls.Add(this.list_messages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnonChat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_messages;
        private System.Windows.Forms.TextBox txtbox_message;
        private System.Windows.Forms.Button btn_send;
    }
}

