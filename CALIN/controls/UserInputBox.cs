using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALIN.Controls
{
    public class UserInputBox : Form
    {
        private TextBox? txtInput1;
        private Button? btnOk;
        private Label? label1;
        private Label? label2;
        private TextBox? txtInput2;
        private Button? btnCancel;
        private int max, min;
        private int? max1, min1;
        private Label label3;
        private TextBox txtInput3;

        /// <summary>
        /// 給使用者輸入一個數值用，可自訂數值的極限值和給使用者看的文字說明
        /// </summary>
        /// <param name="labelstring">給使用者看的文字說明</param>
        /// <param name="defaultValue">預設的數值</param>
        public UserInputBox(string labelstring2, int defaultValue1)
        {
            InitializeComponent();
            this.SetdefaultValue1 = defaultValue1;
            this.Setlabel2 = labelstring2;
        }
        /// <summary>
        /// 給使用者輸入兩個數值
        /// </summary>
        public UserInputBox(string labelstring1, int defaultValue1, string labelstring2, int defaultValue2)
        {
            InitializeComponent();
            this.SetdefaultValue1 = defaultValue1;
            this.Setlabel2 = labelstring2;
            this.txtInput2.Enabled = true;
            this.SetdefaultValue2 = defaultValue2;
            this.Setlabel1 = labelstring2;
        }
        public UserInputBox(string labelstring1, int defaultValue1, string labelstring2, int defaultValue2,string labelstring3,int defaultValue3)
        {
            InitializeComponent();
            this.SetdefaultValue1 = defaultValue1;
            this.Setlabel1 = labelstring1;
            this.txtInput2.Enabled = true;
            this.SetdefaultValue2 = defaultValue2;
            this.Setlabel2 = labelstring2;
        }

        private String Setlabel1
        {
            set { label1.Text = value; }
        }
        private int SetdefaultValue1
        {
            set { txtInput1.Text = value.ToString(); }
            get { return int.Parse(txtInput1.Text); }
        }
        public int getinput1
        {
            get { return int.Parse(txtInput1.Text); }
        }
        private String Setlabel2
        {
            set { label2.Text = value; }
        }
        private int SetdefaultValue2
        {
            set { txtInput2.Text = value.ToString(); }
        }
        public int getinput2
        {
            get { return int.Parse(txtInput2.Text); }
        }
        /// <summary>
        /// 設定使用者可輸入的極限值
        /// </summary>
        public void SetmaxAndmin(int Max, int Min, int? Max1, int? Min1)
        {
            max = Max;
            min = Min;
            this.max1 = Max1;
            this.min1 = Min1;
        }
        private void InitializeComponent()
        {
            btnOk = new Button();
            btnCancel = new Button();
            txtInput1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtInput2 = new TextBox();
            label3 = new Label();
            txtInput3 = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(188, 219);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 33);
            btnOk.TabIndex = 0;
            btnOk.Text = "确定";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(100, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 33);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(12, 32);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(254, 27);
            txtInput1.TabIndex = 0;
            txtInput1.KeyPress += txtInput_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 3;
            // 
            // txtInput2
            // 
            txtInput2.Enabled = false;
            txtInput2.Location = new Point(12, 99);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(254, 27);
            txtInput2.TabIndex = 2;
            txtInput2.KeyPress += txtInput_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 154);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 5;
            // 
            // txtInput3
            // 
            txtInput3.Enabled = false;
            txtInput3.Location = new Point(16, 177);
            txtInput3.Name = "txtInput3";
            txtInput3.Size = new Size(254, 27);
            txtInput3.TabIndex = 4;
            // 
            // UserInputBox
            // 
            ClientSize = new Size(278, 264);
            Controls.Add(label3);
            Controls.Add(txtInput3);
            Controls.Add(label2);
            Controls.Add(txtInput2);
            Controls.Add(label1);
            Controls.Add(txtInput1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "UserInputBox";
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// 判斷使用者有無輸入正確數值
        /// </summary>
        public bool IsValidInput()
        {
            int input1 = int.Parse(txtInput1.Text);
            if (input1 <= max && input1 >= min)
            {
                if (txtInput2.Enabled)
                {
                    int input2 = int.Parse(txtInput2.Text);
                    if (input2 <= max1 && input2 >= min1)
                        return true;
                    else
                        return false;
                }
                return true;
            }
            else
                return false;
        }
        /// <returns>獲取使用者輸入的數值</returns>
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
