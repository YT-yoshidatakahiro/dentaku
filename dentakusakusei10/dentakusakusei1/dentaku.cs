using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dentakusakusei1
{
    public partial class dentaku : Form
    {
        public dentaku()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        /// <summary>
        ///事前定義
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected string[] btnsymb1 = { "-", "+", "*", "/" };
        protected string[] btnsymb2 = { "." };
        protected string[] btnnum1 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };


        //ピリオドの個数を数えるため
        public static int CountChar(string str, string ch)
        {
            return str.Length - str.Replace(ch.ToString(), "").Length;
        }
        /// <summary>
        /// ボタンの設定：０～９のボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //ボタン1
        private void btn1_Click(object sender, EventArgs e)    
        {
                if (tbVal1.Text.Length.Equals(""))
                {
                    tbVal1.Text = "1";
                }
                else
                {
                    tbVal1.AppendText("1");
                }
        }

        //ボタン2
        private void btn2_Click(object sender, EventArgs e)  
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "2";
            }
            else
            {
                tbVal1.AppendText("2");
            }
        }

        //ボタン3
        private void btn3_Click(object sender, EventArgs e)  
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "3";
            }
            else
            {
                tbVal1.AppendText("3");
            }
        }

        //ボタン4
        private void btn4_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "4";
            }
            else
            {
                tbVal1.AppendText("4");
            }
        }

        //ボタン5
        private void btn5_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "5";
            }
            else
            {
                tbVal1.AppendText("5");
            }
        }
        
        //ボタン6
        private void btn6_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "6";
            }
            else
            {
                tbVal1.AppendText("6");
            }
        }

        //ボタン7
        private void btn7_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "7";
            }
            else
            {
                tbVal1.AppendText("7");
            }
        }

        //ボタン8
        private void btn8_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "8";
            }
            else
            {
                tbVal1.AppendText("8");
            }
        }

        //ボタン9
        private void btn9_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "9";
            }
            else
            {
                tbVal1.AppendText("9");
            }
        }

        //ボタン0
        private void btn0_Click(object sender, EventArgs e)     
        {
            if (tbVal1.Text.Length == 0)
            {
                tbVal1.Text = "0";
            }else if (tbVal1.Text.Length==1&&tbVal1.Text.StartsWith("0"))
            {
                tbVal1.AppendText("");
            }
            else
            {
                tbVal1.AppendText("0");
            }
        }

        //ピリオド「.」
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!(tbVal1.Text.Contains(".")))
            {
                tbVal1.AppendText(".");
            }
            else
            {
                tbVal1.AppendText("");
            }
        }

        /// <summary>
        /// 四則演算ボタン・設置と計算処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //四則演算入力後の自動計算処理
        //記号 -
        private void btnSub_Click(object sender, EventArgs e)
        {
            if(tbVal1.Text.Length == 0)
            {
                if (tbVal2.Text.Length == 0 && tbArith.Text.Length == 0)
                {
                    tbVal1.Text = "-";
                }
                else if (tbVal2.Text.Length > 0)
                {
                    if (tbArith.Text.Length == 0)
                    {
                        tbArith.Text = "-";
                    }
                    else if (tbArith.Text.Length == 1)
                    {
                        tbVal1.Text = "-";
                    }
                }
            }
            else if (tbVal1.Text.Length > 0)
            {
                if (tbVal1.Text.StartsWith("-"))
                {
                    tbVal1.AppendText("");
                }
                else if (tbVal2.Text.Length == 0 && tbArith.Text.Length==0)
                {
                    tbVal2.Text = tbVal1.Text;

                    tbVal1.Text = "";

                    tbArith.Text = "-";
                }
                else if (tbVal2.Text.Length > 0 && tbArith.Text.Length == 1)
                {


                        string math = tbVal2.Text + tbArith.Text + tbVal1.Text;

                        string value = new DataTable().Compute(math, null).ToString();

                        tbVal2.Text = Convert.ToString(Math.Round(Convert.ToDouble(value), 8));

                        tbArith.Text = "-";

                        tbVal1.Text = "";
                    
                }
            }
        }

        //記号 +
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbVal1.Text.Length == 0)
            {
                if (tbVal2.Text.Length > 0)
                {
                    if (tbArith.Text.Length == 0)
                    {
                        tbArith.Text = "+";
                    }
                }
            }
            else if (tbVal1.Text.Length > 0)
            {
                if (tbVal2.Text.Length == 0 && tbArith.Text.Length == 0)
                {
                    tbVal2.Text = tbVal1.Text;

                    tbVal1.Text = "";

                    tbArith.Text = "+";
                }
                else if (tbVal2.Text.Length > 0 && tbArith.Text.Length == 1)
                {
                    if (!(tbVal1.Text=="-"))
                    {
                        string math = tbVal2.Text + tbArith.Text + tbVal1.Text;

                        string value = new DataTable().Compute(math, null).ToString();

                        tbVal2.Text = Convert.ToString(Math.Round(Convert.ToDouble(value), 8));

                        tbArith.Text = "+";

                        tbVal1.Text = "";
                    }
                }
            }
        }

        //積 ×
        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (tbVal1.Text.Length == 0)
            {
                if (tbVal2.Text.Length > 0)
                {
                    if (tbArith.Text.Length == 0)
                    {
                        tbArith.Text = "*";
                    }
                }
            }
            else if (tbVal1.Text.Length > 0)
            {
                if (tbVal2.Text.Length == 0 && tbArith.Text.Length == 0)
                {
                    tbVal2.Text = tbVal1.Text;

                    tbVal1.Text = "";

                    tbArith.Text = "*";
                }
                else if (tbVal2.Text.Length > 0 && tbArith.Text.Length == 1)
                {
                        if (!(tbVal1.Text=="-"))
                        {
                            string math = tbVal2.Text + tbArith.Text + tbVal1.Text;

                            string value = new DataTable().Compute(math, null).ToString();

                            tbVal2.Text = Convert.ToString(Math.Round(Convert.ToDouble(value), 8));

                            tbArith.Text = "*";

                            tbVal1.Text = "";
                        }
                }
            }
        }
        //除 ÷
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (tbVal1.Text.Length == 0)
            {
                if (tbVal2.Text.Length > 0)
                {
                    if (tbArith.Text.Length == 0)
                    {
                        tbArith.Text = "/";
                    }
                }
            }
            else if (tbVal1.Text.Length > 0)
            {
                if (tbVal2.Text.Length == 0 && tbArith.Text.Length == 0)
                {
                    tbVal2.Text = tbVal1.Text;

                    tbVal1.Text = "";

                    tbArith.Text = "/";
                }
                else if (tbVal2.Text.Length > 0 && tbArith.Text.Length == 1)
                {
                        if (!(tbVal1.Text=="-"))
                        {
                            string math = tbVal2.Text + tbArith.Text + tbVal1.Text;

                            string value = new DataTable().Compute(math, null).ToString();

                            tbVal2.Text = Convert.ToString(Math.Round(Convert.ToDouble(value), 8));

                            tbArith.Text = "/";

                            tbVal1.Text = "";
                        }
                }
            }
        }


        /// <summary>
        /// ボタン配置：一つ文字を消す，キャンセルC，キャンセルCE、イコール
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //1文字消す
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbVal1.TextLength > 0)
            {
                tbVal1.Text = tbVal1.Text.Remove(tbVal1.TextLength - 1, 1);
            }
        }

        //ボタンCE
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbVal1.Text = "";
        }

        //キャンセルC
        private void btnC_Click(object sender, EventArgs e)
        {
            tbVal1.Text = "";

            tbVal2.Text = "";
            
            tbArith.Text = "";
        }

        //イコール
        private void btnEq_Click(object sender, EventArgs e)
        {
            if (tbVal2.Text.Length>0)
            {
                if (tbArith.Text.Length >0)
                {
                    if (tbVal1.Text.Length>0&&!(tbVal1.Text == "-"))
                    {
                        string math = tbVal2.Text + tbArith.Text + tbVal1.Text;

                        string value = new DataTable().Compute(math, null).ToString();

                        tbVal2.Text = Math.Round(Convert.ToDouble(value), 8).ToString();

                        tbVal1.Text = "";

                        tbArith.Text = "";
                    }
                }
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// パーセント表示ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPer_Click(object sender, EventArgs e)
        {
            if (tbVal1.Text.Length > 0)
            {
                string math = tbVal1.Text;

                string value = new DataTable().Compute(math, null).ToString();

                string value2 = Convert.ToString(Convert.ToDouble(value) / 100);

                tbVal1.Text = Math.Round(Convert.ToDouble(value2), 8).ToString();
            }
        }

        /// <summary>
        /// 結果の表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbVal1_TextChanged(object sender, EventArgs e)
        {

            //最初の文字列01（例）の回避
            for (int j = 0; j < btnnum1.Length; j++)
            {
                if (tbVal1.Text.Length >= 1 && tbVal1.Text.StartsWith("0" + btnnum1[j]))
                {
                    tbVal1.Text = tbVal1.Text.Remove(0, 1);
                }
            }
            if (tbVal1.Text.Length >= 11)
            {
                tbVal1.Text = tbVal1.Text.Substring(0, 10);
            }

            if (tbVal2.Text.Length==0)
            {
                if(tbVal1.Text.Length == 10)
                {
                    tbVal2.Text = tbVal1.Text;

                    tbVal1.Text = "";
                }
            }
            if (tbVal2.Text.Length>0)
            {
                if (tbArith.Text.Length==0 && tbVal1.Text.Length>0)
                {
                    tbVal1.Text = "";

                }

            }
        }

        private void tbVal2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArith_TextChanged(object sender, EventArgs e)
        {

        }

        private void dentaku_Load(object sender, EventArgs e)
        {
        }

    }

}