using System.Security.Policy;

namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculatwbutton_Click(object sender, EventArgs e)
        {
            double distance, gas, average; // �ŧi�ϰ��ܼ�
            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas; // �p�⥭���o��
                    averageLabel.Text = "�����o��:" + average.ToString("f2") + "����/����"; // �ץ��ܼƦW�٩M�y�k���~
                    logListBox.Items.Add(average.ToString("f2") + "����/����"); // �ץ��ܼƦW�٩M�y�k���~
                }
                else
                {
                    MessageBox.Show("�o�ӽп�J�Ʀr");
                    gasTextBox.Focus(); // �N�ƹ���лE�J���J��
                    gasTextBox.Text = ""; // �M�ſ�J��
                }
            }
            else
            {
                MessageBox.Show("���{�п�J�Ʀr");
                distanceTextBox.Focus(); // �N�ƹ���лE�J���J��
                distanceTextBox.Text = ""; // �M�ſ�J��
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // ��������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("�����o�Ӭ���:");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (logListBox.Items.Count > 1)
            {
                for (int i = 1; i < logListBox.Items.Count; i++)
                {
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("����/����", "")); 
                }
                logListBox.Items.Add("�����o��:" + (sum / (logListBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}