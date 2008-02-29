using System;
using System.Windows.Forms;

namespace TestPlugin
{
	public partial class Form1 : Form
	{
		private string m_FilePath;
		private RichTextBox m_RichTextBox;

		public Form1(params object[] args)
		{
			InitializeComponent();

			if (args.Length > 1)
			{
				m_FilePath = args[0].ToString();
				m_RichTextBox = args[1] as RichTextBox;
			}
			else
			{
				m_FilePath = "";
				m_RichTextBox = new RichTextBox();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.label1.Text = m_FilePath;
			this.textBox1.Text = m_RichTextBox.SelectedText;
		}
	}
}