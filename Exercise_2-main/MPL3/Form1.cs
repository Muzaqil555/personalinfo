namespace MPL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            else if (radioButton3.Checked)
                gender = "Other";

            string city = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : "Not selected";
            string country = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "Not selected";

            string languages = "";
            if (checkBox1.Checked) languages += "C#, ";
            if (checkBox2.Checked) languages += "C++, ";
            if (checkBox3.Checked) languages += "Java, ";
            if (checkBox3.Checked) languages += "Other, ";

            if (languages.EndsWith(", "))
                languages = languages.Substring(0, languages.Length - 2);

            string result = $"Gender: {gender}\nCity: {city}\nCountry: {country}\nLanguages: {languages}";

            MessageBox.Show(result, "User Information");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
