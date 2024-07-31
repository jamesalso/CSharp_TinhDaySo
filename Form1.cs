namespace CSharp_TinhDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                double startNum = double.Parse(input1.Text);
                double endNum = double.Parse(input2.Text);

                if (startNum > endNum)
                {
                    MessageBox.Show("Số bắt đầu phải nhỏ hơn hoặc bằng số kết thúc.", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                double sum = 0;
                double acc = 1;
                double sumEven = 0;
                double sumOdd = 0;

                for (double i = startNum; i <= endNum; i++)
                {
                    sum += i;
                    acc *= i;
                    if (i % 2 == 0)
                    {
                        sumEven += i;
                    }
                    else
                    {
                        sumOdd += i;
                    }
                }

                inputTong.Text = sum.ToString();
                inputTich.Text = acc.ToString();
                inputTongSoChan.Text = sumEven.ToString();
                inputTongSoLe.Text = sumOdd.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập các số hợp lệ.", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           input1.Clear();
           input2.Clear();
           inputTong.Clear();
           inputTich.Clear();
           inputTongSoChan.Clear();
           inputTongSoLe.Clear();

        }
    }
}
