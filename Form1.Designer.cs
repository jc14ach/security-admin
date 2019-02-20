namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tOPSUSERSDataSet = new WindowsFormsApp1.TOPSUSERSDataSet();
            this.tUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_UserTableAdapter = new WindowsFormsApp1.TOPSUSERSDataSetTableAdapters.t_UserTableAdapter();
            this.tUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tOPSUSERSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tOPSUSERSDataSet
            // 
            this.tOPSUSERSDataSet.DataSetName = "TOPSUSERSDataSet";
            this.tOPSUSERSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUserBindingSource
            // 
            this.tUserBindingSource.DataMember = "t_User";
            this.tUserBindingSource.DataSource = this.tOPSUSERSDataSet;
            // 
            // t_UserTableAdapter
            // 
            this.t_UserTableAdapter.ClearBeforeFill = true;
            // 
            // tUserBindingSource1
            // 
            this.tUserBindingSource1.DataMember = "t_User";
            this.tUserBindingSource1.DataSource = this.tOPSUSERSDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOPSUSERSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUserBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TOPSUSERSDataSet tOPSUSERSDataSet;
        private System.Windows.Forms.BindingSource tUserBindingSource;
        private TOPSUSERSDataSetTableAdapters.t_UserTableAdapter t_UserTableAdapter;
        private System.Windows.Forms.BindingSource tUserBindingSource1;
    }
}

